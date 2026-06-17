using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Tracking.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Tracking;

public class TrackingAddRequest : HttpRequestBase<TrackingAddResponseBody>
{
    public TrackingAddRequest(TrackingAddRequestBody body) 
        : base(HttpMethod.Post, $"/v1/shipping/trackers")
    {
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.TrackingAddRequestBody);
    }
}