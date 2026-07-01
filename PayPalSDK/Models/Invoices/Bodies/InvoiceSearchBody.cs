using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the result of an invoice search operation.
/// </summary>
public class InvoiceSearchBody
{
    /// <summary>
    /// Gets or sets the total number of invoices matching the search criteria.
    /// </summary>
    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }
    
    /// <summary>
    /// Gets or sets the total number of pages available for the search results.
    /// </summary>
    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }
    
    /// <summary>
    /// Gets or sets the list of invoices returned for this page of the search result.
    /// </summary>
    [JsonPropertyName("items")]
    public List<InvoiceBody>? Items { get; set; }
}