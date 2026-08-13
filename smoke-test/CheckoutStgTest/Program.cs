using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

const string STG_BASE_URL = "https://api.stg.digitalfemsa.io";
const string API_KEY = "key_xFTCnzYBQrmhUdupXGjYRTZ";

Configuration configuration = new()
{
    AccessToken = API_KEY,
    BasePath = STG_BASE_URL
};

var ordersApi = new OrdersApi(configuration);

var checkout = new CheckoutRequest(
    allowedPaymentMethods: new List<string> { "cash", "card" },
    expiresAt: DateTimeOffset.UtcNow.AddDays(7).ToUnixTimeSeconds(),
    failureUrl: "https://example.com/failure",
    name: "Checkout STG Test",
    onDemandEnabled: false,
    successUrl: "https://example.com/success",
    type: "HostedPayment",
    redirectionTime: 60
);

var orderRequest = new OrderRequest(
    currency: "MXN",
    customerInfo: new OrderRequestCustomerInfo(new CustomerInfo(
        name: "Cliente STG Test",
        email: "stg-test@example.com",
        phone: "5555555555"
    )),
    lineItems: new List<Product>
    {
        new Product(name: "Producto de prueba", quantity: 1, unitPrice: 10000)
    },
    checkout: checkout
);

Console.WriteLine("=== Enviando OrderRequest con CheckoutRequest a STG ===");
Console.WriteLine(orderRequest.ToJson());
Console.WriteLine();

try
{
    var response = await ordersApi.CreateOrderWithHttpInfoAsync(orderRequest, acceptLanguage: "es");

    Console.WriteLine($"=== Respuesta HTTP {(int)response.StatusCode} ===");
    Console.WriteLine(response.Data.ToJson());

    if (response.Data.Checkout != null)
    {
        Console.WriteLine($"Checkout id: {response.Data.Checkout.Id}");
        Console.WriteLine($"Checkout status: {response.Data.Checkout.Status}");
    }

    Console.WriteLine("✅ Orden con CheckoutRequest creada correctamente en STG");
}
catch (ApiException ex)
{
    Console.Error.WriteLine($"❌ ApiException. StatusCode: {ex.ErrorCode}");
    if (!string.IsNullOrWhiteSpace(ex.ErrorContent?.ToString()))
        Console.Error.WriteLine(ex.ErrorContent);
    else
        Console.Error.WriteLine(ex.Message);
    Environment.ExitCode = 1;
}
catch (Exception ex)
{
    Console.Error.WriteLine("❌ Error inesperado:");
    Console.Error.WriteLine(ex.ToString());
    Environment.ExitCode = 1;
}
