using System.Net;
using Tavstal.PayPalSDK.Models.PaymentResources;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Endpoints.PaymentResources;

public class PaymentResourceListTests : TestBase
{
    public PaymentResourceListTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/PaymentResources/List/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 200 - List payment resources initial request")]
    public async Task PaymentResourceList_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new PaymentResourceListRequest(2);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Count: " + objectResponse!.Resources!.Count);
    }
}