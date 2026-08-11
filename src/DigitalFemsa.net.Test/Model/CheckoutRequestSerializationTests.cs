using System.Collections.Generic;
using Xunit;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DigitalFemsa.net.Model;

namespace DigitalFemsa.net.Test.Model
{
    public class CheckoutRequestSerializationTests
    {
        [Fact]
        public void CheckoutRequest_SerializesAllCurrentFields()
        {
            var checkout = new CheckoutRequest(
                allowedPaymentMethods: new List<string> { "cash", "card" },
                expiresAt: 1680397724L,
                failureUrl: "https://example.com/failure",
                name: "Test Payment",
                onDemandEnabled: true,
                successUrl: "https://example.com/success",
                type: "HostedPayment",
                redirectionTime: 60
            );

            var json = checkout.ToJson();
            var parsed = JObject.Parse(json);

            Assert.Equal("Test Payment", parsed["name"]?.ToString());
            Assert.Equal("HostedPayment", parsed["type"]?.ToString());
            Assert.Equal(1680397724L, parsed["expires_at"]?.Value<long>());
            Assert.Equal("https://example.com/failure", parsed["failure_url"]?.ToString());
            Assert.Equal("https://example.com/success", parsed["success_url"]?.ToString());
            Assert.True(parsed["on_demand_enabled"]?.Value<bool>());
            Assert.Equal(60, parsed["redirection_time"]?.Value<int>());

            var methods = parsed["allowed_payment_methods"]?.Values<string>();
            Assert.Equal(new[] { "cash", "card" }, methods);
        }

        [Fact]
        public void CheckoutRequest_RedirectionTime_NotSerializedWhenDefault()
        {
            var checkout = new CheckoutRequest(
                allowedPaymentMethods: new List<string> { "cash" },
                expiresAt: 1680397724L,
                failureUrl: "https://example.com/failure",
                name: "Test Payment",
                onDemandEnabled: false,
                successUrl: "https://example.com/success",
                type: "HostedPayment"
            );

            var json = checkout.ToJson();
            var parsed = JObject.Parse(json);

            Assert.Null(parsed["redirection_time"]);
        }

        [Fact]
        public void CheckoutRequest_NestedInOrderRequest_SerializesCorrectly()
        {
            var checkout = new CheckoutRequest(
                allowedPaymentMethods: new List<string> { "cash" },
                expiresAt: 1680397724L,
                failureUrl: "https://example.com/failure",
                name: "Test Payment",
                onDemandEnabled: false,
                successUrl: "https://example.com/success",
                type: "HostedPayment",
                redirectionTime: 30
            );

            var order = new OrderRequest(
                currency: "MXN",
                customerInfo: new OrderRequestCustomerInfo(
                    new CustomerInfo(
                        name: "Test Customer",
                        email: "test@example.com",
                        phone: "5555555555"
                    )
                ),
                lineItems: new List<Product>
                {
                    new Product(name: "Item", quantity: 1, unitPrice: 10000)
                },
                charges: new List<ChargeRequest>
                {
                    new ChargeRequest(
                        paymentMethod: new ChargeRequestPaymentMethod(type: "cash")
                    )
                },
                checkout: checkout
            );

            var json = order.ToJson();
            var parsed = JObject.Parse(json);

            var checkoutNode = parsed["checkout"];
            Assert.NotNull(checkoutNode);
            Assert.Equal("Test Payment", checkoutNode["name"]?.ToString());
            Assert.Equal("HostedPayment", checkoutNode["type"]?.ToString());
            Assert.Equal(30, checkoutNode["redirection_time"]?.Value<int>());
        }
    }
}
