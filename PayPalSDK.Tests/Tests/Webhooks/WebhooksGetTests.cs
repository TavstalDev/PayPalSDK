using System.Net;
using Tavstal.PayPalSDK.Models.Webhooks;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Webhooks;

public class WebhooksGetTests : TestBase
{
    public WebhooksGetTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Webhooks/Get/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 200 - Show Webhook Details")]
    public async Task WebhooksCreate_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        resource.JsonRequest.Should().Be("{}");
        var request = new WebhookGetRequest("0EH40505U7160970P");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("ID: " + objectResponse!.Id);
        _testOutputHelper.WriteLine("Url: " + objectResponse.Url);
    }
}