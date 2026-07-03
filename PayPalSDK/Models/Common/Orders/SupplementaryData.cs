using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Orders;

/// <summary>
/// Represents supplementary data in the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class SupplementaryData
{
    /// <summary>
    /// Gets or sets the card information associated with the supplementary data.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents details about the card used in the transaction.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("card")]
    public SupplementaryCard? SupplementaryCard { get; set; }

    /// <summary>
    /// Gets or sets the risk information associated with the supplementary data.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents risk assessment details for the transaction.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("risk")]
    public Risk? Risk { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}