using System.Net;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.PaymentMethodTokens;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.PaymentMethodTokens;

public class DeletePaymentTokenTests : TestBase
{
    public DeletePaymentTokenTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/PaymentMethodTokens/Delete/sample1.json", "Resources/PaymentMethodTokens/Delete/sample2.json", 
        "Resources/PaymentMethodTokens/Delete/sample3.json", "Resources/PaymentMethodTokens/Delete/sample4.json"]) { }
    

    [Fact(DisplayName = "Sample 1 - 204 - Delete Payment Token")]
    public async Task DeletePaymentToken_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new PaymentTokenDeleteRequest("8kk8451t");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NoContent);
        _testOutputHelper.WriteLine("Payment token deleted successfully.");
    }
    
    [Fact(DisplayName = "Sample 2 - 400 - Delete Payment Token - 400 Bad Request Error - Invalid Parameter Syntax")]
    public async Task DeletePaymentToken_Sample2()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PaymentTokenRetrieveRequest("8kk8451t");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        var orderResponse = await response.Content.ReadJsonAsync<ErrorResponse>();
        orderResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + orderResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + orderResponse.Message);
    }
    
    [Fact(DisplayName = "Sample 3 - 403 - Delete Payment Token - 403 Forbidden Error - No Permission for the Payment Token")]
    public async Task DeletePaymentToken_Sample3()
    {
        var resource = _resources[2];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PaymentTokenRetrieveRequest("8kk8451t");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
        var orderResponse = await response.Content.ReadJsonAsync<ErrorResponse>();
        orderResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + orderResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + orderResponse.Message);
    }
    
    [Fact(DisplayName = "Sample 4 - 500 - Delete Payment Token - 500 Internal Server Error")]
    public async Task DeletePaymentToken_Sample4()
    {
        var resource = _resources[3];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PaymentTokenRetrieveRequest("8kk8451t");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
        var orderResponse = await response.Content.ReadJsonAsync<ErrorResponse>();
        orderResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + orderResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + orderResponse.Message);
    }
}