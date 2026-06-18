using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Disputes.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes;

public class DisputeDenyOfferRequest : HttpRequestBase<LinksResponseBody>
{
    public DisputeDenyOfferRequest([StringLength(255)] string id, DisputeDenyOfferRequestBody body)
        : base(HttpMethod.Post,  $"/v1/customer/disputes/{id}/deny-offer")
    {
        // Sets the content of the HTTP request to the serialized JSON representation of the order creation details.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.DisputeDenyOfferRequestBody);
    }
}