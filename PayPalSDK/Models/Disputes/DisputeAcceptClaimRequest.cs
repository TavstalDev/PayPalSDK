using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Disputes.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes;

/// <summary>
/// Represents a request to accept a claim in an existing customer dispute.
/// </summary>
public class DisputeAcceptClaimRequest : HttpRequestBase<LinksResponseBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DisputeAcceptClaimRequest"/> class.
    /// </summary>
    /// <param name="id">
    /// The unique dispute identifier used to build the request route.
    /// Maximum length is 255 characters.
    /// </param>
    /// <param name="body">
    /// The request payload containing the details required to accept the dispute claim.
    /// </param>
    public DisputeAcceptClaimRequest([StringLength(255)] string id, DisputeAcceptClaimRequestBody body)
        : base(HttpMethod.Post,  $"/v1/customer/disputes/{id}/accept-claim")
    {
        // Sets the content of the HTTP request to the serialized JSON representation of the order creation details.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.DisputeAcceptClaimRequestBody);
    }
}