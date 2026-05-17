using System.Net;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Models.Subscriptions.Plan;
using Tavstal.PayPalSDK.Models.Subscriptions.Plan.Bodies;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Subscriptions.Plan;

public class SubscriptionPlanListTests : TestBase
{
    public SubscriptionPlanListTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Subscriptions/Plan/List/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 200 - Get the list of plan in descending order")]
    public async Task SubscriptionPlanList_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        var request = new SubscriptionPlanListRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await response.Content.ReadFromJsonAsync<SubscriptionPlanListBody>();
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Total Items: " + objectResponse!.TotalItems);
        _testOutputHelper.WriteLine("Total Pages: " + objectResponse.TotalPages);
        
        foreach (var plan in objectResponse.Plans!)
        {
            _testOutputHelper.WriteLine("ID: " + plan.Id);
            _testOutputHelper.WriteLine("Status: " + plan.Status);
        }
    }
}