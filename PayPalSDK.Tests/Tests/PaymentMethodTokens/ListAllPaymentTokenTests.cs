using System.Net;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.PaymentMethodTokens;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.PaymentMethodTokens;

public class ListAllPaymentTokenTests : TestBase
{
    public ListAllPaymentTokenTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/PaymentMethodTokens/ListAll/sample1.json", "Resources/PaymentMethodTokens/ListAll/sample2.json", 
        "Resources/PaymentMethodTokens/ListAll/sample3.json", "Resources/PaymentMethodTokens/ListAll/sample4.json", "Resources/PaymentMethodTokens/ListAll/sample5.json"]) { }
    

    [Fact(DisplayName = "Sample 1 - 200 - List Payment Tokens - Retrieve All Tokens for Customer Id")]
    public async Task ListAllPaymentToken_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new PaymentTokenListAllRequest("BygeLlrpZF");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Total Items: " + objectResponse!.PaymentTokens!.Count);
    }
    
    [Fact(DisplayName = "Sample 2 - 200 - List Payment Tokens - Retrieve All Tokens for Customer Id - No Tokens Found")]
    public async Task ListAllPaymentToken_Sample2()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new PaymentTokenListAllRequest("BygeLlrpZF");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Total Items: " + objectResponse!.PaymentTokens!.Count);
    }
    
    [Fact(DisplayName = "Sample 3 - 400 - Get Customer Setup Tokens - 400 Bad Request Error - Bad Customer Id")]
    public async Task ListAllPaymentToken_Sample3()
    {
        var resource = _resources[2];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PaymentTokenListAllRequest("BygeLlrpZF");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        var objectResponse = await response.Content.ReadJsonAsync<ErrorResponse>();
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
    
    [Fact(DisplayName = "Sample 4 - 403 - Get Customer Payment Tokens - 403 Forbidden Error - No Permission to Query Customer Id")]
    public async Task ListAllPaymentToken_Sample4()
    {
        var resource = _resources[3];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PaymentTokenListAllRequest("BygeLlrpZF");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
        var objectResponse = await response.Content.ReadJsonAsync<ErrorResponse>();
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
    
    [Fact(DisplayName = "Sample 5 - 500 - Get Customer Payment Tokens - 500 Internal Server Error")]
    public async Task ListAllPaymentToken_Sample5()
    {
        var resource = _resources[4];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PaymentTokenListAllRequest("BygeLlrpZF");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
        var objectResponse = await response.Content.ReadJsonAsync<ErrorResponse>();
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
}