using System.Net;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.PaymentMethodTokens;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.PaymentMethodTokens;

public class RetrievePaymentTokenSetupTests : TestBase
{
    public RetrievePaymentTokenSetupTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/PaymentMethodTokens/RetrieveSetup/sample1.json", "Resources/PaymentMethodTokens/RetrieveSetup/sample2.json", 
        "Resources/PaymentMethodTokens/RetrieveSetup/sample3.json", "Resources/PaymentMethodTokens/RetrieveSetup/sample4.json"]) { }
    
    // TODO: Finish samples

    [Fact(DisplayName = "")]
    public async Task RetrievePaymentTokenSetup_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new PaymentTokenSetupRetrieveRequest("8kk8451t");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NoContent);

    }
    
    [Fact(DisplayName = "")]
    public async Task RetrievePaymentTokenSetup_Sample2()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PaymentTokenSetupRetrieveRequest("8kk8451t");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        var objectResponse = await response.Content.ReadJsonAsync<ErrorResponse>();
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + objectResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + objectResponse.Message);
    }
    
}