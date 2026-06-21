using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.PaymentResources.Bodies;

namespace Tavstal.PayPalSDK.Models.PaymentResources;

/// <summary>
/// Represents a request to retrieve a paginated list of payment resources.
/// </summary>
public class PaymentResourceListRequest : HttpRequestBase<PaymentResourceListResponseBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentResourceListRequest"/> class.
    /// </summary>
    /// <param name="pageSize">
    /// The number of payment resources to return per page. The default value is <c>10</c>.
    /// </param>
    /// <param name="pageToken">
    /// An optional pagination token used to retrieve the next page of results.
    /// </param>
    /// <param name="totalRequired">
    /// A value indicating whether the total item count should be included in the response.
    /// </param>
    public PaymentResourceListRequest(int pageSize = 10, string? pageToken = null, bool totalRequired = false) 
        : base(HttpMethod.Get, $"/v1/checkout/payment-resources")
    {
        // Build query parameters dynamically based on the provided pagination and count options.
        List<string> queryParams = [];
        if (pageSize != 10 && pageSize > 0) queryParams.Add($"page_size={pageSize}");
        if (!string.IsNullOrEmpty(pageToken)) queryParams.Add($"page_token={pageToken}");
        if (totalRequired) queryParams.Add($"total_required={totalRequired}");
        
        if (queryParams.Count == 0)
            return;
        
        // Append the generated query string to the relative request URI.
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}