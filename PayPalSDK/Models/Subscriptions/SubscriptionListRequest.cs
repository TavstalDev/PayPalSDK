using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Common.Plans;

namespace Tavstal.PayPalSDK.Models.Subscriptions;

/// <summary>
/// Represents an HTTP request to retrieve a list of subscriptions from the PayPal Billing API.
/// </summary>
public class SubscriptionListRequest : HttpRequestBase<SubscriptionListResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriptionListRequest"/> class.
    /// </summary>
    /// <param name="planIds">Optional comma-separated plan IDs to filter subscriptions by plan.</param>
    /// <param name="statuses">Optional comma-separated subscription statuses to filter by (e.g., ACTIVE, CANCELLED, SUSPENDED).</param>
    /// <param name="createdAfter">Optional ISO 8601 date-time string specifying the earliest subscription creation date to include in the results.</param>
    /// <param name="createdBefore">Optional ISO 8601 date-time string specifying the latest subscription creation date to include in the results.</param>
    /// <param name="updatedAfter">Optional ISO 8601 date-time string specifying the earliest subscription status update date to include in the results.</param>
    /// <param name="updatedBefore">Optional ISO 8601 date-time string specifying the latest subscription status update date to include in the results.</param>
    /// <param name="filter">Optional search filter string to further refine subscription results.</param>
    /// <param name="pageSize">The number of subscriptions to return per page. Defaults to 10.</param>
    /// <param name="page">The page number of results to return (1-indexed). Defaults to 1.</param>
    /// <param name="customerIds">Optional array of customer IDs to filter subscriptions by customer.</param>
    public SubscriptionListRequest(string? planIds = null, string? statuses = null, string? createdAfter = null, string? createdBefore = null, 
        string? updatedAfter = null, string? updatedBefore = null, string? filter = null, int pageSize = 10, int page = 1, string[]? customerIds = null)
        : base(HttpMethod.Get, $"/v1/billing/subscriptions")
    {
        List<string> queryParams = [];
        if (planIds != null) queryParams.Add($"plan_ids={planIds}");
        if (statuses != null) queryParams.Add($"statuses={statuses}");
        if (createdAfter != null) queryParams.Add($"created_after={createdAfter}");
        if (createdBefore != null) queryParams.Add($"created_before={createdBefore}");
        if (updatedAfter != null) queryParams.Add($"status_updated_after={updatedAfter}");
        if (updatedBefore != null) queryParams.Add($"status_updated_before={updatedBefore}");
        if (filter != null) queryParams.Add($"filter={filter}");
        if (customerIds is { Length: > 0 }) queryParams.Add($"customer_ids={string.Join(",", customerIds)}");
        if (page > 1)  queryParams.Add($"page={page}");
        if (pageSize != 10) queryParams.Add($"page_size={pageSize}");
        
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}