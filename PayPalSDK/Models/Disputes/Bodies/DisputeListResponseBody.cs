using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.Disputes;

namespace Tavstal.PayPalSDK.Models.Disputes.Bodies;

/// <summary>
/// Represents the response body for a list of PayPal disputes.
/// </summary>
public class DisputeListResponseBody
{
    /// <summary>
    /// Gets or sets the list of disputes returned in the response.
    /// </summary>
    [JsonPropertyName("items")]
    public List<Dispute>? Items { get; set; }
    
    /// <summary>
    /// Gets or sets the pagination links for navigating through the list of disputes.
    /// </summary>
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }
}