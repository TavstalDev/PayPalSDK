using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Tracking.Bodies;
using Tavstal.PayPalSDK.Serialization;

namespace Tavstal.PayPalSDK.Models.Tracking;

public class TrackingUpdateRequest : HttpRequestBase
{
    public TrackingUpdateRequest([StringLength(100)] string id, Tracker body) 
        : base(HttpMethod.Put, $"/v1/shipping/trackers/{id}")
    {
        Content = JsonContent.Create(body, PayPalSDKJsonContext.Default.Tracker);
    }
}