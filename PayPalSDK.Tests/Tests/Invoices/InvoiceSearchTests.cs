using System.Net;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Invoices;

public class InvoiceSearchTests : TestBase
{
    public InvoiceSearchTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Invoices/Search/sample1.json"]) { }
    

    [Fact(DisplayName = "Sample 1 - 200 - Search for Invoices")]
    public async Task InvoiceSearch_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new InvoiceSearchRequest(1, 1, true);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var orderResponse = await response.Content.ReadFromJsonAsync<InvoiceSearchBody>();
        orderResponse.Should().NotBeNull();

        foreach (var item in orderResponse!.Items!)
        {
            _testOutputHelper.WriteLine("ID: " + item.Id);
            _testOutputHelper.WriteLine("Status: " + item.Status);
        }
    }
}