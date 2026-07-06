using System.Net;
using Tavstal.PayPalSDK.Models.PaymentResources;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Endpoints.PaymentResources;

public class PaymentResourceRetrieveTests : TestBase
{
    public PaymentResourceRetrieveTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/PaymentResources/Retrieve/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 200 - Get fixed price payment resource sample for minimal payment resource by id")]
    public async Task PaymentResourceRetrieve_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new PaymentResourceRetrieveRequest("PLB-X7MNK9P2QR8T");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("ID: " + objectResponse!.Id);
    }
}