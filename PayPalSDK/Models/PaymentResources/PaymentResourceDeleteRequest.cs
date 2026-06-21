using System.ComponentModel.DataAnnotations;
using Tavstal.PayPalSDK.Http;

namespace Tavstal.PayPalSDK.Models.PaymentResources;

/// <summary>
/// Represents a request to delete an existing payment resource.
/// </summary>
public class PaymentResourceDeleteRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentResourceDeleteRequest"/> class.
    /// </summary>
    /// <param name="id">
    /// The unique identifier of the payment resource to delete.
    /// </param>
    public PaymentResourceDeleteRequest([StringLength(127)] string id) 
        : base(HttpMethod.Delete, $"/v1/checkout/payment-resources/{id}")
    { }
}