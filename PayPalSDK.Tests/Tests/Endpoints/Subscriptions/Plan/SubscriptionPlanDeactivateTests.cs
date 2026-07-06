using System.Net;
using Tavstal.PayPalSDK.Models.Subscriptions.Plan;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Endpoints.Subscriptions.Plan;

public class SubscriptionPlanDeactivateTests : TestBase
{
    public SubscriptionPlanDeactivateTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Subscriptions/Plan/Deactivate/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 204 - Deactivate Plan")]
    public async Task SubscriptionPlanDeactivate_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new SubscriptionPlanDeactivateRequest("P-7GL4271244454362WXNWU5NQ");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NoContent);
        
        _testOutputHelper.WriteLine("Subscription plan deactivated successfully.");
    }
}