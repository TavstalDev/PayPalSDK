using System.Net;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Tavstal.PayPalSDK.Models.Subscriptions;
using Tavstal.PayPalSDK.Models.Subscriptions.Bodies;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Subscriptions;

public class SubscriptionSuspendTests : TestBase
{
    public SubscriptionSuspendTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Subscriptions/Suspend/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 204 - Suspend an existing subscription")]
    public async Task SubscriptionSuspend_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new SubscriptionSuspendRequest("I-BW452GLLEP1G", "Test");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NoContent);
        
        _testOutputHelper.WriteLine("Subscription suspended successfully.");
    }
}