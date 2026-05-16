using System.Net;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Orders;
using Tavstal.PayPalSDK.Models.Orders.Bodies;
using Tavstal.PayPalSDK.Models.Payments;
using Tavstal.PayPalSDK.Models.Payments.Bodies;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Payments;

public class FindEligiblePaymentsTests : TestBase
{
    public FindEligiblePaymentsTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Payments/EligableList/sample1.json", "Resources/Payments/EligableList/sample2.json", 
        "Resources/Payments/EligableList/sample3.json", "Resources/Payments/EligableList/sample4.json", "Resources/Payments/EligableList/sample5.json", "Resources/Payments/EligableList/sample6.json"]) { }
    

    /*
     
     TODO: Implement FindEligibleMethodsRequestBody and Response
     TODO: Implement Tests
     
     [Fact(DisplayName = "Sample 1 - 200 - ")]
    public async Task FindEligiblePayments_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        resource.JsonRequest.Should().NotBeNullOrEmpty();
        var body = JsonConvert.DeserializeObject<PaymentFindEligibleMethodsRequestBody>(resource.JsonRequest!);
        body.Should().NotBeNull();
        
        var request = new  PaymentFindEligibleMethodsRequest(body!);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await response.Content.ReadFromJsonAsync<OrderBody>();
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Order ID: " + objectResponse!.Id);
        _testOutputHelper.WriteLine("Order Status: " + objectResponse.Status);
        objectResponse.Links.Should().NotBeNull();
        _testOutputHelper.WriteLine("Links: ");
        foreach (var link in objectResponse.Links!)
            _testOutputHelper.WriteLine(link.ToString());
    }

    [Fact(DisplayName = "Sample 2 - 404 - ")]
    public async Task GetOrder_Sample2()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        var request = new OrderGetDetailsRequest("5O190127TN364715T");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        var objectResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }*/
}