using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents incentive metadata applied to a transaction, such as promotional
/// program identifiers and the associated incentive amount.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class IncentiveDetail
{
    /// <summary>
    /// Gets or sets the high-level incentive type describing how the incentive
    /// is applied (for example, discount, cashback, or offer category).
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("incentive_type")]
    [StringLength(500)]
    public string? IncentiveType { get; set; }
    
    /// <summary>
    /// Gets or sets the specific incentive code associated with the promotion
    /// or offer.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("incentive_code")]
    [StringLength(200)]
    public string? IncentiveCode { get; set; }
    
    /// <summary>
    /// Gets or sets the program code that identifies the incentive program
    /// under which the incentive was granted.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("incentive_program_code")]
    [StringLength(100)]
    public string? IncentiveProgramCode { get; set; }
    
    /// <summary>
    /// Gets or sets the monetary amount of the incentive applied to the transaction.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("incentive_amount")]
    public Money? IncentiveAmount { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}