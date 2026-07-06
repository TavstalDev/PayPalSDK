using System.Net;
using Tavstal.PayPalSDK.Models.Payments;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Payments;

public class RefundPaymentDetailsTests : TestBase
{
    public RefundPaymentDetailsTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Payments/RefundDetails/sample1.json", "Resources/Payments/RefundDetails/sample2.json", 
        "Resources/Payments/RefundDetails/sample3.json", "Resources/Payments/RefundDetails/sample4.json", "Resources/Payments/RefundDetails/sample5.json"]) { }
    

    [Fact(DisplayName = "Sample 1 - 200 - Shows details for a refund, by ID, with platform fees.")]
    public async Task RefundPaymentDetails_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        var request = new PaymentGetRefundDetailsRequest("1JU08902781691411");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Order ID: " + objectResponse!.Id);
        _testOutputHelper.WriteLine("Order Status: " + objectResponse.Status);
        objectResponse.Links.Should().NotBeNull();
        _testOutputHelper.WriteLine("Links: ");
        foreach (var link in objectResponse.Links!)
            _testOutputHelper.WriteLine(link.ToString());
    }
    
    [Fact(DisplayName = "Sample 2 - 401 - Example for unauthorized request.")]
    public async Task RefundPaymentDetails_Sample2()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        var request = new PaymentGetRefundDetailsRequest("1JU08902781691411");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        var objectResponse = await request.GetErrorResponseAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
    
    [Fact(DisplayName = "Sample 3 - 403 - Example for a forbidden request.")]
    public async Task RefundPaymentDetails_Sample3()
    {
        var resource = _resources[2];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        var request = new PaymentGetRefundDetailsRequest("1JU08902781691411");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
        var objectResponse = await request.GetErrorResponseAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
    
    [Fact(DisplayName = "Sample 4 - 404 - Example for a request to a resource that does not exist.")]
    public async Task RefundPaymentDetails_Sample4()
    {
        var resource = _resources[3];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        var request = new PaymentGetRefundDetailsRequest("1JU08902781691411");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        var objectResponse = await request.GetErrorResponseAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
    
    [Fact(DisplayName = "Sample 5 - 500 - Example for a request that fails for reasons internal to the server.\n")]
    public async Task RefundPaymentDetails_Sample5()
    {
        var resource = _resources[4];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        var request = new PaymentGetRefundDetailsRequest("1JU08902781691411");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
        var objectResponse = await request.GetErrorResponseAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
}