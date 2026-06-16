using System.Net;
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Invoices;

public class InvoiceDeleteExternalRefundRequestTests : TestBase
{
    public InvoiceDeleteExternalRefundRequestTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Invoices/DeleteExternalRefund/sample1.json"]) { }
    

    [Fact(DisplayName = "Sample 1 - 204 - Delete External Refund")]
    public async Task InvoiceDeleteExternalRefund_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new InvoiceDeleteExternalRefundRequest("INV2-Z56S-5LLA-Q52L-CPZ5", "EXTR-2LG703375E477444T");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NoContent);

        _testOutputHelper.WriteLine("Successfully deleted external Refund from Invoice.");
    }
}