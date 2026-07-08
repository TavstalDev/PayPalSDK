using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.PaymentMethodTokens.Bodies;

namespace Tavstal.PayPalSDK.Models.PaymentMethodTokens;

/// <summary>
/// Represents an HTTP request to retrieve a paginated list of payment tokens
/// for a specific customer from the PayPal Vault API.
/// </summary>
public class PaymentTokenListAllRequest : HttpRequestBase<PaymentTokenListAllResponseBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentTokenListAllRequest"/> class.
    /// </summary>
    /// <param name="customerId">The identifier of the customer whose payment tokens should be returned.</param>
    /// <param name="pageSize">The number of records to return per page. Defaults to <c>5</c>.</param>
    /// <param name="page">The page index to retrieve. Defaults to <c>1</c>.</param>
    /// <param name="totalRequired">
    /// A boolean indicating total number of items (total_items) and pages (total_pages) are expected to be returned in the response.
    /// </param>
    public PaymentTokenListAllRequest(string customerId, int pageSize = 5, int page = 1, bool totalRequired = false) 
        : base(HttpMethod.Get, $"/v3/vault/payment-tokens")
    {
        List<string> queryParams = [
            $"customer_id={customerId}",
            $"page_size={pageSize}",
            $"page={page}",
            $"total_required={totalRequired.ToString().ToLower()}"
        ];
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }

    /// <summary>
    /// Adds the PayPal Partner Attribution ID header to the request.
    /// </summary>
    /// <param name="paypalPartnerAttributionId">The PayPal Partner Attribution ID to be added.</param>
    /// <returns>The current instance of <see cref="PaymentTokenListAllRequest"/> for method chaining.</returns>
    public PaymentTokenListAllRequest PayPalPartnerAttributionId(string paypalPartnerAttributionId)
    {
        Headers.Add("PayPal-Partner-Attribution-Id", paypalPartnerAttributionId);
        return this;
    }
    
}