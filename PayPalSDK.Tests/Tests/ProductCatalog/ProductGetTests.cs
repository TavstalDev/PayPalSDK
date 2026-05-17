using System.Net;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Models.ProductCatalog;
using Tavstal.PayPalSDK.Models.ProductCatalog.Bodies;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.ProductCatalog;

public class ProductGetTests : TestBase
{
    public ProductGetTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Products/Get/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 200 - Show Product Details")]
    public async Task ProductGet_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        resource.JsonRequest.Should().Be("{}");
        var request = new ProductGetRequest("72255d4849af8ed6e0df1173");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await response.Content.ReadFromJsonAsync<ProductBody>();
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("ID: " + objectResponse!.Id);
        _testOutputHelper.WriteLine("Name: " + objectResponse.Name);
    }
}