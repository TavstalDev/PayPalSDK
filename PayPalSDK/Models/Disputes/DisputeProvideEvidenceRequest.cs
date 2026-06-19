using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Disputes.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes;

/// <summary>
/// Represents a request to submit evidence for a specific customer dispute.
/// </summary>
public class DisputeProvideEvidenceRequest : HttpRequestBase<LinksResponseBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DisputeProvideEvidenceRequest"/> class.
    /// </summary>
    /// <param name="id">
    /// The unique dispute identifier used to build the request route.
    /// Maximum length is 255 characters.
    /// </param>
    /// <param name="body">
    /// The request payload containing evidence details for the dispute.
    /// </param>
    public DisputeProvideEvidenceRequest([StringLength(255)] string id, DisputeProvideEvidenceRequestBody body)
        : base(HttpMethod.Post,  $"/v1/customer/disputes/{id}/provide-evidence")
    {
        // Sets the content of the HTTP request to the serialized JSON representation of the order creation details.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.DisputeProvideEvidenceRequestBody);
    }
}