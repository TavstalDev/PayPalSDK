using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Addressing;

/// <summary>
/// Represents a shipping option with details such as ID, label, selection status, type, and amount.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class ShippingOption
{
    /// <summary>
    /// Gets or sets the unique identifier for the shipping option.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 127 characters.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("id")]
    [StringLength(127)]
    [Required]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the label or name of the shipping option.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 127 characters.
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("label")]
    [StringLength(127)]
    public string? Label { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the shipping option is selected.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the selection status of the shipping option.
    /// </remarks>
    [FluentMember(2)]
    [Required]
    [JsonPropertyName("selected")]
    public bool? Selected { get; set; }

    /// <summary>
    /// Gets or sets the type of shipping.
    /// </summary>
    /// <remarks>
    /// This property corresponds to one of the predefined shipping types in <see cref="Tavstal.PayPalSDK.Constants.ShippingType"/>.
    /// It is optional and will not be emitted if its value is null or default.
    /// </remarks>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the amount associated with the shipping option.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the cost or value of the shipping option.
    /// </remarks>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}