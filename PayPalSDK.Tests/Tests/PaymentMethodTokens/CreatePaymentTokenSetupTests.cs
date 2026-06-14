using System.Net;
using Newtonsoft.Json;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.PaymentMethodTokens;
using Tavstal.PayPalSDK.Models.PaymentMethodTokens.Bodies;
using Tavstal.PayPalSDK.Tests.Helpers;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests.PaymentMethodTokens;

public class CreatePaymentTokenSetupTests : TestBase
{
    public CreatePaymentTokenSetupTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, ["Resources/PaymentMethodTokens/CreateSetup/sample1.json", "Resources/PaymentMethodTokens/CreateSetup/sample2.json", 
        "Resources/PaymentMethodTokens/CreateSetup/sample3.json", "Resources/PaymentMethodTokens/CreateSetup/sample4.json", 
        "Resources/PaymentMethodTokens/CreateSetup/sample5.json", "Resources/PaymentMethodTokens/CreateSetup/sample6.json"]) { }
    
    // TODO: Finish samples

    [Fact(DisplayName = "Sample 1 - 201 - Create Setup Token - Card with Full Request")]
    public async Task CreatePaymentTokenSetup_Sample1()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        resource.JsonRequest.Should().NotBeNullOrEmpty();
        var body = JsonConvert.DeserializeObject<PaymentTokenCreateRequestBody>(resource.JsonRequest!);
        body.Should().NotBeNull();
        
        var request = new PaymentTokenSetupCreateRequest(body!);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.Created);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("ID: " + objectResponse!.Id);
    }
    
    [Fact(DisplayName = "Sample 2 - 200 - Create Setup Token - Card with Full Request - Idempotent")]
    public async Task CreatePaymentTokenSetup_Sample2()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);
        
        resource.JsonRequest.Should().NotBeNullOrEmpty();
        var body = JsonConvert.DeserializeObject<PaymentTokenCreateRequestBody>(resource.JsonRequest!);
        body.Should().NotBeNull();
        
        var request = new PaymentTokenSetupCreateRequest(body!);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var objectResponse = await request.GetResponseBodyAsync(response);
        objectResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("ID: " + objectResponse!.Id);
    }
    
    [Fact(DisplayName = "Sample 3 - 400 - Create Setup Token - 400 Bad Request Error - Invalid Parameter Syntax")]
    public async Task CreatePaymentTokenSetup_Sample3()
    {
        var resource = _resources[2];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        resource.JsonRequest.Should().NotBeNullOrEmpty();
        var body = JsonConvert.DeserializeObject<PaymentTokenCreateRequestBody>(resource.JsonRequest!);
        body.Should().NotBeNull();
        
        var request = new PaymentTokenSetupCreateRequest(body!);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        var orderResponse = await response.Content.ReadJsonAsync<ErrorResponse>();
        orderResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + orderResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + orderResponse.Message);
    }
    
    [Fact(DisplayName = "Sample 4 - 422 - Create Setup Token - 422 Unprocessable Entity - Invalid security code for card")]
    public async Task CreatePaymentTokenSetup_Sample4()
    {
        var resource = _resources[3];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        resource.JsonRequest.Should().NotBeNullOrEmpty();
        var body = JsonConvert.DeserializeObject<PaymentTokenCreateRequestBody>(resource.JsonRequest!);
        body.Should().NotBeNull();
        
        var request = new PaymentTokenSetupCreateRequest(body!);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        var orderResponse = await response.Content.ReadJsonAsync<ErrorResponse>();
        orderResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + orderResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + orderResponse.Message);
    }
    
    [Fact(DisplayName = "Sample 5 - 422 - Create Setup Token - 422 Unprocessable Entity Error - Invalid Merchant Customer Id\"")]
    public async Task CreatePaymentTokenSetup_Sample5()
    {
        var resource = _resources[4];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        resource.JsonRequest.Should().NotBeNullOrEmpty();
        var body = JsonConvert.DeserializeObject<PaymentTokenCreateRequestBody>(resource.JsonRequest!);
        body.Should().NotBeNull();
        
        var request = new PaymentTokenSetupCreateRequest(body!);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.UnprocessableEntity);
        var orderResponse = await response.Content.ReadJsonAsync<ErrorResponse>();
        orderResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + orderResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + orderResponse.Message);
    }
    
    [Fact(DisplayName = "")]
    public async Task CreatePaymentTokenSetup_Sample6()
    {
        var resource = _resources[5];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        resource.JsonRequest.Should().NotBeNullOrEmpty();
        var body = JsonConvert.DeserializeObject<PaymentTokenCreateRequestBody>(resource.JsonRequest!);
        body.Should().NotBeNull();
        
        var request = new PaymentTokenSetupCreateRequest(body!);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        var orderResponse = await response.Content.ReadJsonAsync<ErrorResponse>();
        orderResponse.Should().NotBeNull();
        
        _testOutputHelper.WriteLine("Error Name: " + orderResponse!.Name);
        _testOutputHelper.WriteLine("Error Message: " + orderResponse.Message);
    }
}