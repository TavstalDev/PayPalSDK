using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.User;

/// <summary>
/// Represents the seller protection details in PayPal transactions.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class SellerProtection
{
    /// <summary>
    /// The status of seller protection.
    /// Possible values are defined in <see cref="Tavstal.PayPalSDK.Constants.SellerProtectionStatus"/>.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// A list of dispute categories associated with the seller protection.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("dispute_categories")]
    public List<string>? DisputeCategories { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}