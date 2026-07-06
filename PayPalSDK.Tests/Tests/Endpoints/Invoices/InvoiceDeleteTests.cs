using System.Net;
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Endpoints.Invoices;

public class InvoiceDeleteTests : TestBase
{
    public InvoiceDeleteTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Invoices/Delete/sample1.json"]) { }
    

    [Fact(DisplayName = "Sample 1 - 204 - Delete Invoice")]
    public async Task InvoiceDelete_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new InvoiceDeleteRequest("INV2-Z56S-5LLA-Q52L-CPZ5");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NoContent);
        
        _testOutputHelper.WriteLine("Invoices deleted successfully.");
    }
}