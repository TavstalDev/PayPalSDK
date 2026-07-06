using System.Net;
using Tavstal.PayPalSDK.Models.Subscriptions;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Endpoints.Subscriptions;

public class SubscriptionShowTests : TestBase
{
    public SubscriptionShowTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Subscriptions/Show/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 200 - Get active subscription details")]
    public async Task SubscriptionShow_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        var request = new SubscriptionShowRequest("I-BW452GLLEP1G");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("ID: " + objectResponse!.Id);
        _testOutputHelper.WriteLine("Status: " + objectResponse.Status);
    }
}