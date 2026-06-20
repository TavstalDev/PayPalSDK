using System.ComponentModel.DataAnnotations;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Tracking.Bodies;

namespace Tavstal.PayPalSDK.Models.Tracking;

/// <summary>
/// Represents a request to retrieve tracking information for a specific transaction.
/// </summary>
public class TrackingListRequest : HttpRequestBase<TrackerInformation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrackingListRequest"/> class.
    /// </summary>
    /// <param name="transactionId">
    /// The required transaction identifier used to filter tracking results.
    /// </param>
    /// <param name="trackingNumber">
    /// An optional shipment tracking number to narrow down the results.
    /// </param>
    /// <param name="accountId">
    /// An optional PayPal account identifier to filter results by merchant.
    /// Maximum length is 13 characters.
    /// </param>
    public TrackingListRequest(string transactionId, string? trackingNumber = null, [StringLength(13)] string? accountId = null) 
        : base(HttpMethod.Get, $"/v1/shipping/trackers")
    {
        // Build query parameters dynamically, only appending optional values when provided.
        List<string> queryParams = [
            $"transaction_id={transactionId}"
        ];
        if (!string.IsNullOrEmpty(trackingNumber)) queryParams.Add($"tracking_number={trackingNumber}");
        if (!string.IsNullOrEmpty(accountId)) queryParams.Add($"account_id={accountId}");

        // Append the generated query string to the relative request URI.
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}