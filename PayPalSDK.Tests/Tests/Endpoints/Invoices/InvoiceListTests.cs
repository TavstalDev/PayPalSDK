using System.Net;
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Endpoints.Invoices;

public class InvoiceListTests : TestBase
{
    public InvoiceListTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Invoices/List/sample1.json"]) { }
    

    [Fact(DisplayName = "Sample 1 - 200 - List Invoices")]
    public async Task InvoiceList_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new InvoiceListRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        foreach (var invoice in objectResponse!.Items!)
            _testOutputHelper.WriteLine($"Invoice ID: {invoice.Id}, Status: {invoice.Status}");
    }
}