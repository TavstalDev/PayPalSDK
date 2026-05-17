using System.Net;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Invoices;

public class InvoiceShowTests : TestBase
{
    public InvoiceShowTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Invoices/Show/sample1.json"]) { }
    

    [Fact(DisplayName = "Sample 1 - 200 - Show Invoice Details with Theme")]
    public async Task InvoiceShow_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new InvoiceShowRequest("INV2-Z56S-5LLA-Q52L-CPZ5");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var orderResponse = await response.Content.ReadFromJsonAsync<InvoiceBody>();
        orderResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("ID: " + orderResponse!.Id);
        _testOutputHelper.WriteLine("Status: " + orderResponse.Status);
    }
}