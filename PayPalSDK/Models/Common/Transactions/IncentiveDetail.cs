using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents incentive metadata applied to a transaction, such as promotional
/// program identifiers and the associated incentive amount.
/// </summary>
[DataContract]
public class IncentiveDetail
{
    /// <summary>
    /// Gets or sets the high-level incentive type describing how the incentive
    /// is applied (for example, discount, cashback, or offer category).
    /// </summary>
    [JsonPropertyName("incentive_type")]
    [StringLength(500)]
    public string? IncentiveType { get; set; }
    
    /// <summary>
    /// Gets or sets the specific incentive code associated with the promotion
    /// or offer.
    /// </summary>
    [JsonPropertyName("incentive_code")]
    [StringLength(200)]
    public string? IncentiveCode { get; set; }
    
    /// <summary>
    /// Gets or sets the program code that identifies the incentive program
    /// under which the incentive was granted.
    /// </summary>
    [JsonPropertyName("incentive_program_code")]
    [StringLength(100)]
    public string? IncentiveProgramCode { get; set; }
    
    /// <summary>
    /// Gets or sets the monetary amount of the incentive applied to the transaction.
    /// </summary>
    [JsonPropertyName("incentive_amount")]
    public Money? IncentiveAmount { get; set; }
}