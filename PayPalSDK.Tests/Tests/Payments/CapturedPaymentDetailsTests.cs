using System.Net;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Payments;
using Tavstal.PayPalSDK.Models.Payments.Bodies;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Payments;

public class CapturedPaymentDetailsTests : TestBase
{
    public CapturedPaymentDetailsTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Payments/CaptureDetails/sample1.json", "Resources/Payments/CaptureDetails/sample2.json", 
        "Resources/Payments/CaptureDetails/sample3.json", "Resources/Payments/CaptureDetails/sample4.json", "Resources/Payments/CaptureDetails/sample5.json"]) { }
    

    [Fact(DisplayName = "Sample 1 - 200 - Shows details for a captured payment, by ID.\n")]
    public async Task CapturedPaymentDetails_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        var request = new PaymentGetCapturedDetailsRequest("74L756601X447022Y");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await response.Content.ReadFromJsonAsync<CapturedPaymentBody>();
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Order ID: " + objectResponse!.Id);
        _testOutputHelper.WriteLine("Order Status: " + objectResponse.Status);
        objectResponse.Links.Should().NotBeNull();
        _testOutputHelper.WriteLine("Links: ");
        foreach (var link in objectResponse.Links!)
            _testOutputHelper.WriteLine(link.ToString());
    }
    
    [Fact(DisplayName = "Sample 2 - 401 - Example for unauthorized request.")]
    public async Task CapturedPaymentDetails_Sample21()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        var request = new PaymentGetCapturedDetailsRequest("74L756601X447022Y");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        var objectResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
    
    [Fact(DisplayName = "Sample 3 - 403 - Example for a forbidden request.")]
    public async Task CapturedPaymentDetails_Sample3()
    {
        var resource = _resources[2];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        var request = new PaymentGetCapturedDetailsRequest("74L756601X447022Y");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
        var objectResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
    
    [Fact(DisplayName = "Sample 4 - 404 - Example for a request to a resource that does not exist.")]
    public async Task CapturedPaymentDetails_Sample4()
    {
        var resource = _resources[3];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        var request = new PaymentGetCapturedDetailsRequest("74L756601X447022Y");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        var objectResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
    
    [Fact(DisplayName = "Sample 500 - 0 - Example for a request that fails for reasons internal to the server.\n")]
    public async Task CapturedPaymentDetails_Sample5()
    {
        var resource = _resources[4];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        var request = new PaymentGetCapturedDetailsRequest("74L756601X447022Y");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
        var objectResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
}