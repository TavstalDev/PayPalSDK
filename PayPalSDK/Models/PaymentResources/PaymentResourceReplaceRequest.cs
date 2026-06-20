using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.PaymentResources.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.PaymentResources;

/// <summary>
/// Represents a request to replace an existing payment resource.
/// </summary>
public class PaymentResourceReplaceRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentResourceReplaceRequest"/> class.
    /// </summary>
    /// <param name="id">
    /// The unique identifier of the payment resource to replace.
    /// </param>
    /// <param name="body">
    /// The request payload containing the replacement payment resource details.
    /// </param>
    public PaymentResourceReplaceRequest([StringLength(127)] string id, PaymentResourceReplaceRequestBody body) 
        : base(HttpMethod.Put, $"/v1/checkout/payment-resources/{id}")
    {
        // Serialize and attach the replacement payload using source-generated JSON metadata.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.PaymentResourceReplaceRequestBody);
    }
}