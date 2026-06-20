using System.Net;
using Tavstal.PayPalSDK.Models.Disputes;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Disputes;

public class DisputesShowTests : TestBase
{
    public DisputesShowTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Disputes/Show/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 200 - Show Dispute Details with extensions")]
    public async Task Show_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new DisputeShowDetailsRequest("PP-D-4012");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("ID: " + objectResponse!.DisputeId);
    }
}