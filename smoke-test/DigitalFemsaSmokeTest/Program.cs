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

    using (var reader = new StreamReader(context.Request.InputStream, context.Request.ContentEncoding ?? Encoding.UTF8))
    {
        _ = await reader.ReadToEndAsync();
    }

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

Configuration configuration = new()
{
    AccessToken = apiKey,
    BasePath = baseUrl
};

var ordersApi = new OrdersApi(configuration);

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

    await serverTask;

    Console.WriteLine("✅ Smoke test succeeded: exits with code 0 (success)");
}
catch (ApiException ex)
{
    Environment.ExitCode = 1;

    Console.Error.WriteLine($"Smoke test failed (ApiException). StatusCode: {ex.ErrorCode}");
    if (!string.IsNullOrWhiteSpace(ex.ErrorContent?.ToString()))
    {
        Console.Error.WriteLine(ex.ErrorContent);
    }
    else
    {
        Console.Error.WriteLine(ex.Message);
    }

    httpListener.Stop();
    try { await serverTask; } catch { }
    return;
}
catch (Exception ex)
{
    Environment.ExitCode = 1;

    Console.Error.WriteLine("Smoke test failed.");
    Console.Error.WriteLine(ex.ToString());

    httpListener.Stop();
    try { await serverTask; } catch { }
    return;
}

