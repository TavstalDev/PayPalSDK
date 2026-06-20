using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.PaymentResources.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.PaymentResources;

/// <summary>
/// Represents a request to create a new payment resource.
/// </summary>
public class PaymentResourceCreateRequest : HttpRequestBase<PaymentResourceBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentResourceCreateRequest"/> class.
    /// </summary>
    /// <param name="body">
    /// The request payload containing the details required to create the payment resource.
    /// </param>
    public PaymentResourceCreateRequest(PaymentResourceCreateRequestBody body) 
        : base(HttpMethod.Post, $"/v1/checkout/payment-resources")
    {
        // Serialize and attach the request body using source-generated JSON metadata.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.PaymentResourceCreateRequestBody);
    }
}