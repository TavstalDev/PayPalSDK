using System.Net;
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Invoices;

public class InvoiceDeleteExternalPaymentTests : TestBase
{
    public InvoiceDeleteExternalPaymentTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Invoices/DeleteExternalPayment/sample1.json"]) { }
    

    [Fact(DisplayName = "Sample 1 - 204 - Delete External Payment")]
    public async Task InvoiceDeleteExternalPayment_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new InvoiceDeleteExternalPayment("INV2-Z56S-5LLA-Q52L-CPZ5", "EXTR-86F38350LX4353815");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NoContent);

        _testOutputHelper.WriteLine("Successfully deleted external payment from Invoice.");
    }
}