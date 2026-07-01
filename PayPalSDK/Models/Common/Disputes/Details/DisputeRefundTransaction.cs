using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details;

/// <summary>
/// Represents a refund transaction associated with a PayPal dispute, including the transaction ID, gross amount, and creation time.
/// </summary>
public class DisputeRefundTransaction
{
    /// <summary>
    /// Gets or sets the unique identifier of the refund transaction associated with the dispute.
    /// </summary>
    [JsonPropertyName("id")]
    [StringLength(255)]
    public string? Id { get; set; }
    
    /// <summary>
    /// Gets or sets the gross amount of the refund transaction associated with the dispute.
    /// </summary>
    [JsonPropertyName("gross_amount")]
    public Money? GrossAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the creation time of the refund transaction associated with the dispute, in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("create_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? CreateTime { get; set; }
}