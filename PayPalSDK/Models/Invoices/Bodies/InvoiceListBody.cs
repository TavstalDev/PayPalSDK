using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the body of a response containing a list of PayPal invoices.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceListBody
{
    /// <summary>
    /// Gets or sets the total number of pages available in the response.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    /// <summary>
    /// Gets or sets the total number of items available in the response.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }

    /// <summary>
    /// Gets or sets the list of invoice items included in the response.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("items")]
    public List<InvoiceBody>? Items { get; set; }

    /// <summary>
    /// Gets or sets the list of links related to the response.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}