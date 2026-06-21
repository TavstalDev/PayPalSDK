using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Disputes.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes;

/// <summary>
/// Represents a request to update a dispute status by requiring evidence
/// for the specified dispute.
/// </summary>
[Obsolete("This endpoint only works in sandbox environment.")]
public class DisputeUpdateStatusRequest : HttpRequestBase<LinksResponseBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DisputeUpdateStatusRequest"/> class.
    /// </summary>
    /// <param name="id">
    /// The unique dispute identifier used to build the endpoint route.
    /// Maximum length is 255 characters.
    /// </param>
    /// <param name="body">
    /// The request payload containing the details required to submit
    /// evidence for the dispute.
    /// </param>
    public DisputeUpdateStatusRequest([StringLength(255)] string id, DisputeUpdateStatusRequestBody body)
        : base(HttpMethod.Post,  $"/v1/customer/disputes/{id}/require-evidence")
    {
        // Sets the content of the HTTP request to the serialized JSON representation of the order creation details.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.DisputeUpdateStatusRequestBody);
    }
}