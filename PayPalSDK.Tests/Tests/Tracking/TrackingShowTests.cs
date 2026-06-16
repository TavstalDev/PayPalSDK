using System.Net;
using Newtonsoft.Json;
using Tavstal.PayPalSDK.Models.Tracking;
using Tavstal.PayPalSDK.Models.Tracking.Bodies;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Tracking;

public class TrackingShowTests : TestBase
{
    public TrackingShowTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Tracking/Show/sample1.json"]) { }
    

    [Fact(DisplayName = "Sample 1 - 200 - Show Tracking Information")]
    public async Task TrackingShow_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new TrackingShowRequest("8MC585209K746392H-443844607820", "TELFDNSFY96RY");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("ID: " + objectResponse!.TransactionId);
    }
}