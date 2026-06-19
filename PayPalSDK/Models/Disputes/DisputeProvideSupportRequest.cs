using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Disputes.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes;

/// <summary>
/// Represents a request to submit supporting information for an existing dispute.
/// </summary>
public class DisputeProvideSupportRequest : HttpRequestBase<LinksResponseBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DisputeProvideSupportRequest"/> class.
    /// </summary>
    /// <param name="id">
    /// The unique dispute identifier used to target the dispute.
    /// Maximum length is 255 characters.
    /// </param>
    /// <param name="body">
    /// The request payload containing supporting evidence or additional dispute details.
    /// </param>
    public DisputeProvideSupportRequest([StringLength(255)] string id, DisputeProvideSupportRequestBody body)
        : base(HttpMethod.Post,  $"/v1/customer/disputes/{id}/provide-supporting-info")
    {
        // Sets the content of the HTTP request to the serialized JSON representation of the order creation details.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.DisputeProvideSupportRequestBody);
    }
}