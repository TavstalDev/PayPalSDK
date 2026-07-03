using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents a name/value checkout option associated with a transaction,
/// as returned by or sent to PayPal transaction-related APIs.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class CheckoutOption
{
    /// <summary>
    /// Gets or sets the checkout option name (key), such as a setting or label
    /// used during checkout processing.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("checkout_option_name")]
    [StringLength(200)]
    public string? CheckoutOptionName { get; set; }
    
    /// <summary>
    /// Gets or sets the checkout option value corresponding to
    /// <see cref="CheckoutOptionName"/>.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("checkout_option_value")]
    [StringLength(200)]
    public string? CheckoutOptionValue { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}