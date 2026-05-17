using System.Net;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Invoices;

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
        var orderResponse = await response.Content.ReadFromJsonAsync<InvoiceListBody>();
        orderResponse.Should().NotBeNull();
        
        foreach (var invoice in orderResponse!.Items!)
            _testOutputHelper.WriteLine($"Invoice ID: {invoice.Id}, Status: {invoice.Status}");
    }
}