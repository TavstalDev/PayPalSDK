using System.Net;
using Tavstal.PayPalSDK.Models.Webhooks;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Webhooks;

public class WebhooksDeleteTests : TestBase
{
    public WebhooksDeleteTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Webhooks/Delete/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 204 - Delete Webhook")]
    public async Task WebhooksDelete_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        var request = new WebhookDeleteRequest("5GP028458E2496506");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NoContent);
        
        _testOutputHelper.WriteLine("Webhooks deleted.");
    }
}