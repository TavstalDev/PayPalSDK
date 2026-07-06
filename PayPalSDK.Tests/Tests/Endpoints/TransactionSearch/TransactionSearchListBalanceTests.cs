using System.Net;
using Tavstal.PayPalSDK.Models.TransactionSearch;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Endpoints.TransactionSearch;

public class TransactionSearchListBalanceTests : TestBase
{
    public TransactionSearchListBalanceTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/TransactionSearch/ListBalance/sample1.json"]) { }
    

    [Fact(DisplayName = "Sample 1 - 200 - List Balance for currency code")]
    public async Task TransactionSearchListBalance_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new TransactionListBalanceRequest("2021-02-22T00:00:00-07:00", "ALL");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("ID: " + objectResponse!.AccountId);
    }
}