using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Tracking.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Tracking;

/// <summary>
/// Represents a request to update an existing shipment tracker.
/// </summary>
public class TrackingUpdateRequest : HttpRequestBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrackingUpdateRequest"/> class.
    /// </summary>
    /// <param name="id">
    /// The unique tracker identifier used to build the request route.
    /// Maximum length is 100 characters.
    /// </param>
    /// <param name="body">
    /// The tracker payload containing the updated shipment tracking details.
    /// </param>
    public TrackingUpdateRequest([StringLength(100)] string id, Tracker body) 
        : base(HttpMethod.Put, $"/v1/shipping/trackers/{id}")
    {
        // Serialize and attach the tracker payload using source-generated JSON metadata.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.Tracker);
    }
}