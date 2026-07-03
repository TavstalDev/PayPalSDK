using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Billing;

/// <summary>
/// Represents the details of a duplicate transaction in a PayPal dispute, including whether a duplicate was received and the original transaction details.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class DuplicateTransaction
{
    /// <summary>
    /// Gets or sets a value indicating whether a duplicate transaction was received in the dispute.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("received_duplicate")]
    public bool ReceivedDuplicate { get; set; }
    
    /// <summary>
    /// Gets or sets the details of the original transaction that was duplicated in the dispute.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("original_transaction")]
    public DisputedTransaction? OriginalTransaction { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}