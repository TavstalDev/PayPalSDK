using System.Net;
using Tavstal.PayPalSDK.Models.Webhooks;
using Tavstal.PayPalSDK.Models.Webhooks.Bodies;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Webhooks;

public class WebhooksListTests : TestBase
{
    public WebhooksListTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Webhooks/List/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 200 - List All Webhooks")]
    public async Task WebhooksList_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        var request = new WebhookListRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await response.Content.ReadJsonAsync<WebhookListResponseBody>();
        objectResponse.Should().NotBeNull();
        objectResponse!.Webhooks.Should().NotBeNull();
        
        foreach (var webhook in objectResponse!.Webhooks!)
        {
            _testOutputHelper.WriteLine("Id: " + webhook.Id);
            _testOutputHelper.WriteLine("Url: " + webhook.Url);
        }
    }
}