using System.Net;
using System.Net.Http.Json;
using System.Text;
using Newtonsoft.Json;
using Tavstal.PayPalSDK.Models.Orders;
using Tavstal.PayPalSDK.Models.Orders.Bodies;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Orders;

public class CreateOrderTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public CreateOrderTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    private HttpResponseMessage Responder(HttpRequestMessage request)
    {
        var path = request.RequestUri?.AbsolutePath ?? string.Empty;
        if (path.Contains("/v1/oauth2/token"))
        {
            var json = File.ReadAllText("Resources/Responses/authResponse.json");
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
        }

        if (path.Contains("/v2/checkout/orders"))
        {
            var json = File.ReadAllText("Resources/Responses/createOrderResponse.json");
            return new HttpResponseMessage(HttpStatusCode.Created)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
        }

        return new HttpResponseMessage(HttpStatusCode.NotFound);
    }
    

    [Fact(DisplayName = "Should create an order successfully")]
    public async Task CreateOrder_Success()
    {
        var client = FakeHttpHelpers.CreateClient(Responder);
        
        string requestJson = await File.ReadAllTextAsync("Resources/Requests/createOrderRequest.json");
        OrderCreateRequestBody? body = JsonConvert.DeserializeObject<OrderCreateRequestBody>(requestJson);
        body.Should().NotBeNull("The provided json should be deserializable into an OrderCreateRequestBody"); 
        var request = new OrderCreateRequest(body!);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.Created, "A successful order creation should return a 201 Created status code");
        var orderResponse = await response.Content.ReadFromJsonAsync<OrderBody>();
        orderResponse.Should().NotBeNull("Response content should be deserializable into an OrderBody");
        
        _testOutputHelper.WriteLine("Response Status Code: " + response.StatusCode);
        _testOutputHelper.WriteLine("Order ID: " + orderResponse?.Id);
    }
    
    // TODO: Implement more tests
}