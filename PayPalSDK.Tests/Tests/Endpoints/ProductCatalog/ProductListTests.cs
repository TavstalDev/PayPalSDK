using System.Net;
using Tavstal.PayPalSDK.Models.ProductCatalog;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.Endpoints.ProductCatalog;

public class ProductListTests : TestBase
{
    public ProductListTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/Products/List/sample1.json"]) { }
    
    [Fact(DisplayName = "Sample 1 - 200 - List Products")]
    public async Task ProductList_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        resource.JsonRequest.Should().Be("{}");

        var request = new ProductListRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Total Items: " + objectResponse!.TotalItems);
        _testOutputHelper.WriteLine("Total Pages: " + objectResponse.TotalPages);
        objectResponse.Products.Should().NotBeNull();
        foreach (var item in objectResponse.Products!)
        {
            _testOutputHelper.WriteLine("Product ID: " + item.Id);
            _testOutputHelper.WriteLine("Product Name: " + item.Name);
        }
    }
}