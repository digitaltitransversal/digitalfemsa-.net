// See https://aka.ms/new-console-template for more information
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;
using System.Net;
using System.Net.Sockets;
using System.Text;

static int GetFreeTcpPort()
{
    var listener = new TcpListener(IPAddress.Loopback, 0);
    listener.Start();
    var port = ((IPEndPoint)listener.LocalEndpoint).Port;
    listener.Stop();
    return port;
}

static async Task StartMockServerOnce(HttpListener listener)
{
    var context = await listener.GetContextAsync();

    Console.WriteLine("\n=== Incoming request ===");
    Console.WriteLine($"{context.Request.HttpMethod} {context.Request.RawUrl}");
    Console.WriteLine("\n--- Headers ---");
    foreach (var key in context.Request.Headers.AllKeys)
    {
        Console.WriteLine($"{key}: {context.Request.Headers[key]}");
    }

    Console.WriteLine("\n--- Body ---");
    string body;
    using (var reader = new StreamReader(context.Request.InputStream, context.Request.ContentEncoding ?? Encoding.UTF8))
    {
        body = await reader.ReadToEndAsync();
    }
    Console.WriteLine(body);

    // Minimal JSON so the SDK can deserialize OrderResponse.
    var responseJson = "{\"id\":\"ord_test\",\"object\":\"order\",\"currency\":\"MXN\",\"created_at\":0,\"updated_at\":0,\"livemode\":false}";
    var responseBytes = Encoding.UTF8.GetBytes(responseJson);

    context.Response.StatusCode = 200;
    context.Response.ContentType = "application/json";
    context.Response.ContentEncoding = Encoding.UTF8;
    context.Response.ContentLength64 = responseBytes.Length;
    await context.Response.OutputStream.WriteAsync(responseBytes);
    context.Response.Close();
}

var apiKey = Environment.GetEnvironmentVariable("DIGITALFEMSA_API_KEY") ?? "sk_test_local_smoke";
var port = GetFreeTcpPort();
var baseUrl = $"http://localhost:{port}";
var prefix = $"http://localhost:{port}/";

using var httpListener = new HttpListener();
httpListener.Prefixes.Add(prefix);
httpListener.Start();

var serverTask = StartMockServerOnce(httpListener);

Console.WriteLine($"Mock server listening on {prefix}");

Configuration configuration = new()
{
    AccessToken = apiKey,
    BasePath = baseUrl
};

var ordersApi = new OrdersApi(configuration);

Console.WriteLine($"SDK loaded: {typeof(OrdersApi).FullName}");
Console.WriteLine($"Configured BasePath: {configuration.BasePath}");

var orderRequest = new OrderRequest(
    charges: new List<ChargeRequest>
    {
        new ChargeRequest(
            paymentMethod: new ChargeRequestPaymentMethod(type: "cash")
        )
    },
    currency: "MXN",
    customerInfo: new OrderRequestCustomerInfo(new CustomerInfo(
        name: "Cliente Ligia",
        email: "ligia@example.com",
        phone: "5555555555"
    )),
    lineItems: new List<Product>
    {
        new Product(name: "Servicio", quantity: 1, unitPrice: 10000)
    }
);

try
{
    _ = await ordersApi.CreateOrderWithHttpInfoAsync(orderRequest, acceptLanguage: "es");
    Console.WriteLine("\nCreateOrder completed (mocked response).\n");
}
catch (Exception ex)
{
    Console.WriteLine("\nCreateOrder threw exception:");
    Console.WriteLine(ex);
}

await serverTask;
