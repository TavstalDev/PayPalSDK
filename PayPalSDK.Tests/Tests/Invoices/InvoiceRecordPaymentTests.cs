using System.Net;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Tavstal.PayPalSDK.Models.Invoices;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Invoices;

public class InvoiceRecordPaymentTests : TestBase
{
    public InvoiceRecordPaymentTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Invoices/RecordPayment/sample1.json"]) { }
    

    [Fact(DisplayName = "Sample 1 - 200 - Record Payment for Invoice")]
    public async Task InvoiceRecordPayment_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        resource.JsonRequest.Should().NotBeNullOrEmpty();
        var body = JsonConvert.DeserializeObject<InvoiceRecordPaymentRequestBody>(resource.JsonRequest!);
        body.Should().NotBeNull();
        
        var request = new InvoiceRecordPaymentRequest("INV2-Z56S-5LLA-Q52L-CPZ5", body!);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var orderResponse = await response.Content.ReadFromJsonAsync<InvoiceRecordPaymentBody>();
        orderResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("ID: " + orderResponse!.PaymentId);
    }
}