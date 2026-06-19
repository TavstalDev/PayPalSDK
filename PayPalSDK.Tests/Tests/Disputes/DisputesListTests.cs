using System.Net;
using Tavstal.PayPalSDK.Models.Disputes;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Disputes;

public class DisputesListTests : TestBase
{
    public DisputesListTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Disputes/List/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 200 - Lists Disputes")]
    public async Task List_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new DisputeListRequest("2023-07-22T01:34:47.000Z");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Links: " + objectResponse!.Links!.Count);
    }
}