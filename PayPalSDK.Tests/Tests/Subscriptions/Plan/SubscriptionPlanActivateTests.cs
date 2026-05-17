using System.Net;
using Tavstal.PayPalSDK.Models.Subscriptions.Plan;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Subscriptions.Plan;

public class SubscriptionPlanActivateTests : TestBase
{
    public SubscriptionPlanActivateTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Subscriptions/Plan/Activate/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 204 - Activate Plan")]
    public async Task SubscriptionPlanActivate_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new SubscriptionPlanActivateRequest("P-7GL4271244454362WXNWU5NQ");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NoContent);
        
        _testOutputHelper.WriteLine("Subscription plan activated successfully.");
    }
}