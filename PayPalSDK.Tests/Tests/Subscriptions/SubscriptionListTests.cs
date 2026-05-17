using System.Net;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Tavstal.PayPalSDK.Models.Common.Plans;
using Tavstal.PayPalSDK.Models.Subscriptions;
using Tavstal.PayPalSDK.Models.Subscriptions.Bodies;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Subscriptions;

public class SubscriptionListTests : TestBase
{
    public SubscriptionListTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Subscriptions/List/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 200 - Get the list of all subscriptions FSS")]
    public async Task SubscriptionList_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new SubscriptionListRequest(customerIds: ["kmHnwzGFRA"]);
        
        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await response.Content.ReadFromJsonAsync<SubscriptionListResponse>();
        objectResponse.Should().NotBeNull();

        foreach (var subscription in objectResponse!.Subscriptions!)
        {
            _testOutputHelper.WriteLine($"Subscription ID: {subscription.Id}");
            _testOutputHelper.WriteLine($"Status: {subscription.Status}");
        }
    }
}