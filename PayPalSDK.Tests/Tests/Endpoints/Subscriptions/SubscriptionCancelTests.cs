using System.Net;
using Tavstal.PayPalSDK.Models.Subscriptions;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Endpoints.Subscriptions;

public class SubscriptionCancelTests : TestBase
{
    public SubscriptionCancelTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Subscriptions/Cancel/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 204 - Cancel an existing subscription")]
    public async Task SubscriptionCancel_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new SubscriptionCancelRequest("I-BW452GLLEP1G", "Test");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NoContent);

        _testOutputHelper.WriteLine("Subscription cancelled successfully.");
    }
}