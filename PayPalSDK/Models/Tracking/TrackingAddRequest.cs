using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Tracking.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Tracking;

/// <summary>
/// Represents a request to add one or more tracking entries to PayPal shipments.
/// </summary>
public class TrackingAddRequest : HttpRequestBase<TrackingAddResponseBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrackingAddRequest"/> class.
    /// </summary>
    /// <param name="body">
    /// The request payload containing the tracking information to add.
    /// </param>
    public TrackingAddRequest(TrackingAddRequestBody body) 
        : base(HttpMethod.Post, $"/v1/shipping/trackers")
    {
        // Serialize and attach the tracking payload using source-generated JSON metadata.
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.TrackingAddRequestBody);
    }
}