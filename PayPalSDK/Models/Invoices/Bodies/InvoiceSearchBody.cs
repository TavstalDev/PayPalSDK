using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the result of an invoice search operation.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceSearchBody
{
    /// <summary>
    /// Gets or sets the total number of invoices matching the search criteria.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }
    
    /// <summary>
    /// Gets or sets the total number of pages available for the search results.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }
    
    /// <summary>
    /// Gets or sets the list of invoices returned for this page of the search result.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("items")]
    public List<InvoiceBody>? Items { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}