using System.Net;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.PaymentMethodTokens;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.PaymentMethodTokens;

public class RetrievePaymentTokenTests : TestBase
{
    public RetrievePaymentTokenTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/PaymentMethodTokens/Retrieve/sample1.json", "Resources/PaymentMethodTokens/Retrieve/sample2.json", 
        "Resources/PaymentMethodTokens/Retrieve/sample3.json", "Resources/PaymentMethodTokens/Retrieve/sample4.json", "Resources/PaymentMethodTokens/Retrieve/sample5.json",
        "Resources/PaymentMethodTokens/Retrieve/sample6.json"]) { }
    

    [Fact(DisplayName = "Sample 1 - 200 - Retrieve Payment Token - Card Token")]
    public async Task RetrievePaymentToken_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new PaymentTokenRetrieveRequest("8kk8451t");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("ID: " + objectResponse!.Id);
    }
    
    [Fact(DisplayName = "Sample 2 - 200 - Retrieve Payment Token - PayPal Wallet Token")]
    public async Task RetrievePaymentToken_Sample2()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new PaymentTokenRetrieveRequest("8kk8451t");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("ID: " + objectResponse!.Id);
    }
    
    [Fact(DisplayName = "Sample 3 - 200 - Retrieve Payment Token - Venmo Token")]
    public async Task RetrievePaymentToken_Sample3()
    {
        var resource = _resources[2];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new PaymentTokenRetrieveRequest("8kk8451t");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("ID: " + objectResponse!.Id);
    }
    
    [Fact(DisplayName = "Sample 4 - 403 - Get Payment Token - 403 Forbidden Error - Merchant Not Onboarded to Vault")]
    public async Task RetrievePaymentToken_Sample4()
    {
        var resource = _resources[3];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PaymentTokenRetrieveRequest("8kk8451t");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
        var objectResponse = await response.Content.ReadJsonAsync<ErrorResponse>();
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
    
    [Fact(DisplayName = "Sample 5 - 404 - Get Payment Token - 404 Not Found Error - Payment Token Cannot Be Located")]
    public async Task RetrievePaymentToken_Sample5()
    {
        var resource = _resources[4];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PaymentTokenRetrieveRequest("8kk8451t");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        var objectResponse = await response.Content.ReadJsonAsync<ErrorResponse>();
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
    
    [Fact(DisplayName = "Sample 6 - 500 - Get Payment Token - 500 Internal Server Error")]
    public async Task RetrievePaymentToken_Sample6()
    {
        var resource = _resources[5];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PaymentTokenRetrieveRequest("8kk8451t");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
        var objectResponse = await response.Content.ReadJsonAsync<ErrorResponse>();
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
}