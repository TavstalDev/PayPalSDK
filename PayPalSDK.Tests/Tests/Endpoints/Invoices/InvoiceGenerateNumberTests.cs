using System.Net;
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Endpoints.Invoices;

public class InvoiceGenerateNumberTests : TestBase
{
    public InvoiceGenerateNumberTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Invoices/GenerateNumber/sample1.json"]) { }
    

    [Fact(DisplayName = "Sample 1 - 200 - Generate Next Invoice Id")]
    public async Task InvoiceGenerateNumber_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        var request = new InvoiceGenerateNumberRequest(true);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("ID: " + objectResponse!.InvoiceId);
    }
}