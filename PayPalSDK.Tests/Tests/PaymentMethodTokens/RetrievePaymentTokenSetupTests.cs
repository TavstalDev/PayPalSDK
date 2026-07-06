using System.Net;
using Tavstal.PayPalSDK.Models.PaymentMethodTokens;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.PaymentMethodTokens;

public class RetrievePaymentTokenSetupTests : TestBase
{
    public RetrievePaymentTokenSetupTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/PaymentMethodTokens/RetrieveSetup/sample1.json", "Resources/PaymentMethodTokens/RetrieveSetup/sample2.json", 
        "Resources/PaymentMethodTokens/RetrieveSetup/sample3.json", "Resources/PaymentMethodTokens/RetrieveSetup/sample4.json", 
        "Resources/PaymentMethodTokens/RetrieveSetup/sample5.json"]) { }

    [Fact(DisplayName = "Sample 1 - 200 - Retrieve Setup Token - Card with 3DS Contingency 3DS VERIFIED")]
    public async Task RetrievePaymentTokenSetup_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new PaymentTokenSetupRetrieveRequest("5C991763VB2781612");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("ID: " + objectResponse!.Id);
    }
    
    [Fact(DisplayName = "Sample 2 - 400 - Get Setup Token - 400 Bad Request Error - Invalid Parameter Syntax")]
    public async Task RetrievePaymentTokenSetup_Sample2()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PaymentTokenSetupRetrieveRequest("5C991763VB2781612");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        var objectResponse = await request.GetErrorResponseAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
    
    [Fact(DisplayName = "Sample 3 - 403 - Get Setup Token - 403 Forbidden Error - Merchant Not Onboarded to Vault")]
    public async Task RetrievePaymentTokenSetup_Sample3()
    {
        var resource = _resources[2];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PaymentTokenSetupRetrieveRequest("5C991763VB2781612");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
        var objectResponse = await request.GetErrorResponseAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
    
    [Fact(DisplayName = "Sample 4 - 404 - Get Setup Token -  404 Not Found Error - Setup Token Does Not Exist")]
    public async Task RetrievePaymentTokenSetup_Sample4()
    {
        var resource = _resources[3];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PaymentTokenSetupRetrieveRequest("5C991763VB2781612");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        var objectResponse = await request.GetErrorResponseAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
    
    [Fact(DisplayName = "Sample 5 - 500 - Get Setup Token - 500 Internal Server Error")]
    public async Task RetrievePaymentTokenSetup_Sample5()
    {
        var resource = _resources[4];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PaymentTokenSetupRetrieveRequest("5C991763VB2781612");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
        var objectResponse = await request.GetErrorResponseAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
}