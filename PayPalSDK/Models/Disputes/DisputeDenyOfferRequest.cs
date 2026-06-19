using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Disputes.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes;

/// <summary>
/// Represents a request to deny an offer made in an existing customer dispute.
/// </summary>
public class DisputeDenyOfferRequest : HttpRequestBase<LinksResponseBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DisputeDenyOfferRequest"/> class.
    /// </summary>
    /// <param name="id">
    /// The unique dispute identifier used to build the request route.
    /// Maximum length is 255 characters.
    /// </param>
    /// <param name="body">
    /// The request payload containing the details required to deny the dispute offer.
    /// </param>
    public DisputeDenyOfferRequest([StringLength(255)] string id, DisputeDenyOfferRequestBody body)
        : base(HttpMethod.Post,  $"/v1/customer/disputes/{id}/deny-offer")
    {
        // Sets the content of the HTTP request to the serialized JSON representation of the order creation details.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.DisputeDenyOfferRequestBody);
    }
}