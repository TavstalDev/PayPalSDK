using System.Net;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Orders;
using Tavstal.PayPalSDK.Models.Orders.Bodies;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Orders;

public class GetOrderTests : TestBase
{
    public GetOrderTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Orders/Get/sample1.json", "Resources/Orders/Get/sample2.json"]) { }
    

    [Fact(DisplayName = "Sample 1 - 200 - Get Order - Show Order Details After Customer Approval")]
    public async Task GetOrder_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        var request = new OrderGetDetailsRequest("5O190127TN364715T");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var orderResponse = await response.Content.ReadJsonAsync<OrderBody>();
        orderResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Order ID: " + orderResponse!.Id);
        _testOutputHelper.WriteLine("Order Status: " + orderResponse.Status);
        orderResponse.Links.Should().NotBeNull();
        _testOutputHelper.WriteLine("Links: ");
        foreach (var link in orderResponse.Links!)
            _testOutputHelper.WriteLine(link.ToString());
    }

    [Fact(DisplayName = "Sample 2 - 404 - Get Order - 404 Not Found Error - Order Not Found")]
    public async Task GetOrder_Sample2()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        var request = new OrderGetDetailsRequest("5O190127TN364715T");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        var orderResponse = await response.Content.ReadJsonAsync<ErrorResponse>();
        orderResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + orderResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + orderResponse.Message);
    }
}