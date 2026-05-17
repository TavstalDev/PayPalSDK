using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Http;
using Tavstal.PayPalSDK.Models.Invoices.Bodies;

namespace Tavstal.PayPalSDK.Models.Invoices;

/// <summary>
/// Represents an HTTP request to search invoices in the PayPal Invoicing API.
/// </summary>
public class InvoiceSearchRequest: HttpRequestBase<InvoiceSearchBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvoiceSearchRequest"/> class.
    /// </summary>
    /// <param name="page">The page number to retrieve. Defaults to 1.</param>
    /// <param name="pageSize">The number of invoices to return per page. Defaults to 10.</param>
    /// <param name="totalRequired">Indicates whether the total result count should be included. Defaults to <c>false</c>.</param>
    /// <param name="body">Optional search criteria to filter the invoices returned by the API.</param>
    public InvoiceSearchRequest(int page = 1, int pageSize = 10, bool totalRequired = false, InvoiceListRequestBody? body = null) : base(HttpMethod.Post, $"/v2/invoicing/search-invoices")
    {
        List<string> queryParams = [];
        if (page > 1)  queryParams.Add($"page={page}");
        if (pageSize != 10) queryParams.Add($"page_size={pageSize}");
        queryParams.Add($"total_required={totalRequired.ToString().ToLower()}");
        
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
        
        if (body == null)
            return;
        
        Content = JsonContent.Create(body, options: new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        });
    }
}