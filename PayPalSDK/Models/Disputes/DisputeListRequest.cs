using System.ComponentModel.DataAnnotations;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Disputes.Bodies;

namespace Tavstal.PayPalSDK.Models.Disputes;

public class DisputeListRequest : HttpRequestBase<DisputeListResponseBody>
{
    public DisputeListRequest([StringLength(64, MinimumLength = 20)] 
        [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")] 
        string startTime, 
        [StringLength(255)] string? disputedTransactionId = null, int page = 1, int pageSize = 10,
        [StringLength(255)] string? nextPageToken = null, [StringLength(2000)] string? disputeState = null,
        [StringLength(64, MinimumLength = 20)] [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")] 
        string? createTimeBefore = null,
        [StringLength(64, MinimumLength = 20)] [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")] 
        string? createTimeAfter = null,
        [StringLength(64, MinimumLength = 20)] [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")] 
        string? updateTimeBefore = null, 
        [StringLength(64, MinimumLength = 20)] [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")] 
        string? updateTimeAfter = null)
        : base(HttpMethod.Get,  $"/v1/customer/disputes")
    {
        List<string> queryParams = [
            $"start_time={startTime}"
        ];
        if (!string.IsNullOrEmpty(disputedTransactionId)) queryParams.Add($"disputed_transaction_id={disputedTransactionId}");
        if (page != 1 && page > 0) queryParams.Add($"page={page}");
        if (pageSize != 10 && pageSize > 0) queryParams.Add($"page_size={pageSize}");
        if (!string.IsNullOrEmpty(nextPageToken)) queryParams.Add($"next_page_token={nextPageToken}");
        if (!string.IsNullOrEmpty(disputeState)) queryParams.Add($"dispute_state={disputeState}");
        if (!string.IsNullOrEmpty(createTimeBefore)) queryParams.Add($"create_time_before={createTimeBefore}");
        if (!string.IsNullOrEmpty(createTimeAfter)) queryParams.Add($"create_time_after={createTimeAfter}");
        if (!string.IsNullOrEmpty(updateTimeBefore)) queryParams.Add($"update_time_before={updateTimeBefore}");
        if (!string.IsNullOrEmpty(updateTimeAfter)) queryParams.Add($"update_time_after={updateTimeAfter}");
        
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}