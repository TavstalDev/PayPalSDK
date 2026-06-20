using System.ComponentModel.DataAnnotations;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.PaymentResources.Bodies;

namespace Tavstal.PayPalSDK.Models.PaymentResources;

/// <summary>
/// Represents a request to retrieve a specific payment resource by its identifier.
/// </summary>
public class PaymentResourceRetrieveRequest : HttpRequestBase<PaymentResourceBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentResourceRetrieveRequest"/> class.
    /// </summary>
    /// <param name="id">
    /// The unique identifier of the payment resource to retrieve.
    /// </param>
    public PaymentResourceRetrieveRequest([StringLength(127)] string id) 
        : base(HttpMethod.Get, $"/v1/checkout/payment-resources/{id}")
    { }
}