using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Disputes.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes;

/// <summary>
/// Represents a request to acknowledge that a disputed item has been returned.
/// </summary>
public class DisputeAcknowledgeReturnRequest : HttpRequestBase<LinksResponseBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DisputeAcknowledgeReturnRequest"/> class.
    /// </summary>
    /// <param name="id">
    /// The unique dispute identifier used to build the request route.
    /// Maximum length is 255 characters.
    /// </param>
    /// <param name="body">
    /// The request payload containing return acknowledgment details.
    /// </param>
    public DisputeAcknowledgeReturnRequest([StringLength(255)] string id, DisputeAcknowledgeReturnRequestBody body)
        : base(HttpMethod.Post,  $"/v1/customer/disputes/{id}/acknowledge-return-item")
    {
        // Sets the content of the HTTP request to the serialized JSON representation of the order creation details.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.DisputeAcknowledgeReturnRequestBody);
    }
}