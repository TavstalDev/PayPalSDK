using System.Net;
using Tavstal.PayPalSDK.Models.Common.Plans;
using Tavstal.PayPalSDK.Models.Subscriptions;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Subscriptions;

public class SubscriptionListTransactionTests : TestBase
{
    public SubscriptionListTransactionTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Subscriptions/ListTransaction/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 200 - Get subscription payments for the given subscription")]
    public async Task SubscriptionList_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new SubscriptionListTransactionRequest("I-BW452GLLEP1G", "2018-01-21T07:50:20.940Z", "2018-08-21T07:50:20.940Z");
        
        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await response.Content.ReadJsonAsync<SubscriptionListTransactionResponse>();
        objectResponse.Should().NotBeNull();

        foreach (var transaction in objectResponse!.Transactions!)
        {
            _testOutputHelper.WriteLine($"ID: {transaction.Id}");
            _testOutputHelper.WriteLine($"Status: {transaction.Status}");
        }
    }
}