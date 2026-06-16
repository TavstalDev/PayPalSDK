using System.ComponentModel.DataAnnotations;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Tracking.Bodies;

namespace Tavstal.PayPalSDK.Models.Tracking;

public class TrackingShowRequest : HttpRequestBase<Tracker>
{
    public TrackingShowRequest([StringLength(100)] string id, [StringLength(13)] string? accountId = null) 
        : base(HttpMethod.Get, $"/v1/shipping/trackers/{id}")
    {
        if (accountId != null)
            RequestUri = new Uri(RequestUri + $"?account_id={accountId}", UriKind.Relative);
    }
}