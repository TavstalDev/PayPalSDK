using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;

namespace Tavstal.PayPalSDK.Models.Invoices;

/// <summary>
/// Represents the body of a response containing a list of PayPal invoices.
/// </summary>
public class InvoiceListBody
{
    /// <summary>
    /// Gets or sets the total number of pages available in the response.
    /// </summary>
    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    /// <summary>
    /// Gets or sets the total number of items available in the response.
    /// </summary>
    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }

    /// <summary>
    /// Gets or sets the list of invoice items included in the response.
    /// </summary>
    [JsonPropertyName("items")]
    public List<InvoiceBody> Items { get; set; }

    /// <summary>
    /// Gets or sets the list of links related to the response.
    /// </summary>
    [JsonPropertyName("links")]
    public List<Link> Links { get; set; }
}