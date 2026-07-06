using System.Net;
using Tavstal.PayPalSDK.Models.PaymentResources;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Endpoints.PaymentResources;

public class PaymentResourceDeleteTests : TestBase
{
    public PaymentResourceDeleteTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/PaymentResources/Delete/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 204 - Delete payment resource by id")]
    public async Task PaymentResourceDelete_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new PaymentResourceDeleteRequest("PLB-X7MNK9P2QR8T");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NoContent);
        _testOutputHelper.WriteLine("Payment resource deleted successfully");
    }
}