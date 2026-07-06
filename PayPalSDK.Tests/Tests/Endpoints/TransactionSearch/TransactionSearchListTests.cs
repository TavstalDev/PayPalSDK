using System.Net;
using Tavstal.PayPalSDK.Models.TransactionSearch;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Endpoints.TransactionSearch;

public class TransactionSearchListTests : TestBase
{
    public TransactionSearchListTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/TransactionSearch/List/sample1.json"]) { }
    

    [Fact(DisplayName = "Sample 1 - 200 - List PayPal decline transactions")]
    public async Task TransactionSearchList_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new TransactionListRequest("2022-04-25T00:00:00-07:00", "2022-05-10T23:59:59:59-07:00", "03A84379GE3808324", fields: "all");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Start Date: " + objectResponse!.StartDate);
    }
}