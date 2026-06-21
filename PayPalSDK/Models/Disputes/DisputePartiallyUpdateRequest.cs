using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Disputes;

/// <summary>
/// Represents a request to partially update a dispute using patch operations.
/// </summary>
public class DisputePartiallyUpdateRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DisputePartiallyUpdateRequest"/> class.
    /// </summary>
    /// <param name="id">
    /// The unique dispute identifier used to build the request route.
    /// Maximum length is 255 characters.
    /// </param>
    /// <param name="body">
    /// A list of patch operations describing the partial updates to apply to the dispute.
    /// </param>
    public DisputePartiallyUpdateRequest([StringLength(255)] string id, List<UpdateOperation> body)
        : base(HttpMethod.Patch,  $"/v1/customer/disputes/{id}")
    {
        // Sets the content of the HTTP request to the serialized JSON representation of the order creation details.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.ListUpdateOperation);
    }
}