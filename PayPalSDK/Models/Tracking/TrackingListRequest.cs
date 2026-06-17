using System.ComponentModel.DataAnnotations;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Tracking.Bodies;

namespace Tavstal.PayPalSDK.Models.Tracking;

public class TrackingListRequest : HttpRequestBase<TrackerInformation>
{
    public TrackingListRequest(string transactionId, string? trackingNumber = null, [StringLength(13)] string? accountId = null) 
        : base(HttpMethod.Get, $"/v1/shipping/trackers")
    {
        List<string> queryParams = [
            $"transaction_id={transactionId}"
        ];
        if (!string.IsNullOrEmpty(trackingNumber)) queryParams.Add($"tracking_number={trackingNumber}");
        if (!string.IsNullOrEmpty(accountId)) queryParams.Add($"account_id={accountId}");

        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}