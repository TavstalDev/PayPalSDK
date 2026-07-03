using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a buyer entity involved in a PayPal transaction.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Buyer
{
    /// <summary>
    /// Gets or sets the display name of the buyer.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("name")]
    [StringLength(2000)]
    public string? Name { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}