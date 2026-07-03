using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Billing;

/// <summary>
/// Represents a pricing scheme in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PricingScheme
{
    /// <summary>
    /// Gets or sets the pricing model type for the scheme.
    /// </summary>
    /// <remarks>
    /// The pricing model corresponds to one of the predefined models in <see cref="Tavstal.PayPalSDK.Constants.PricingModelType"/>.
    /// This field is required and has a maximum length of 24 characters.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("pricing_model")]
    [StringLength(24)]
    public string? PricingModel { get; set; }

    /// <summary>
    /// Gets or sets the price associated with the pricing scheme.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of the price.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("price")]
    public Money? Price { get; set; }

    /// <summary>
    /// Gets or sets the reload threshold amount for the pricing scheme.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of the reload threshold amount.
    /// </remarks>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("reload_threshold_amount")]
    public Money? ReloadThresholdAmount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}