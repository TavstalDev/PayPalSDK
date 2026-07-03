using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Invoices.Bodies;

/// <summary>
/// Represents the request body for generating the next available invoice number, with an option to fetch the invoice ID.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class InvoiceGenerateNumberRequestBody
{
    /// <summary>
    /// Gets or sets a value indicating whether the generated invoice number response should also include the invoice ID.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("fetch_id")]
    public bool FetchId { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}