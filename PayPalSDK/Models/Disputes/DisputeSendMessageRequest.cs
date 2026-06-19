using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Disputes.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes;

/// <summary>
/// Represents a request to send a message within an existing customer dispute.
/// </summary>
public class DisputeSendMessageRequest : HttpRequestBase<LinksResponseBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DisputeSendMessageRequest"/> class.
    /// </summary>
    /// <param name="id">
    /// The unique dispute identifier used to target the dispute thread.
    /// Maximum length is 255 characters.
    /// </param>
    /// <param name="body">
    /// The request payload containing the message content and related metadata.
    /// </param>
    public DisputeSendMessageRequest([StringLength(255)] string id, DisputeSendMessageRequestBody body)
        : base(HttpMethod.Post,  $"/v1/customer/disputes/{id}/send-message")
    {
        // Sets the content of the HTTP request to the serialized JSON representation of the order creation details.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.DisputeSendMessageRequestBody);
    }
}