using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Billing;

/// <summary>
/// Represents the details of an agreed refund in a PayPal dispute.
/// </summary>
[DataContract]
public class AgreedRefundDetails
{
    /// <summary>
    /// Gets or sets a value indicating whether the merchant has agreed to the refund.
    /// </summary>
    [JsonPropertyName("merchant_agreed_refund")]
    public bool MerchantAgreedRefund { get; set; }
    
    /// <summary>
    /// Gets or sets the time when the merchant agreed to the refund, in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("merchant_agreed_refund_time")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? MerchantAgreedRefundTime { get; set; }
    
    /// <summary>
    /// Gets the time when the merchant agreed to the refund as a <see cref="DateTime"/> object.
    /// </summary>
    public DateTime? MerchantAgreedRefundTimeAsDateTime => DateTimeHelper.FromISO8601(MerchantAgreedRefundTime);
}