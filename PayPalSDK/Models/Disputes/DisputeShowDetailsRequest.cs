using System.ComponentModel.DataAnnotations;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common.Disputes;

namespace Tavstal.PayPalSDK.Models.Disputes;

/// <summary>
/// Represents a request to retrieve the details of a specific PayPal dispute.
/// </summary>
public class DisputeShowDetailsRequest : HttpRequestBase<DisputeDetails>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DisputeShowDetailsRequest"/> class.
    /// </summary>
    /// <param name="id">
    /// The unique dispute identifier used to build the request path.
    /// Maximum length is 255 characters.
    /// </param>
    public DisputeShowDetailsRequest([StringLength(255)] string id)
        : base(HttpMethod.Get,  $"/v1/customer/disputes/{id}")
    {
    }
}