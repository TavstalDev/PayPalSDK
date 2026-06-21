using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Disputes.Details.Extensions.Billing;

/// <summary>
/// Represents the details of a payment made by other means in a PayPal dispute, including whether the charge is different from the original and the payment method used.
/// </summary>
[DataContract]
public class PaymentByOtherMeans
{
    /// <summary>
    /// Gets or sets a value indicating whether the charge is different from the original transaction in the dispute.
    /// </summary>
    [JsonPropertyName("charge_different_from_original")]
    public bool ChargeDifferentFromOriginal { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether a duplicate payment was received in the dispute.
    /// </summary>
    [JsonPropertyName("received_duplicate")]
    public bool ReceivedDuplicate { get; set; }
    
    /// <summary>
    /// Gets or sets the payment method used for the payment made by other means in the dispute.
    /// </summary>
    [JsonPropertyName("payment_method")]
    [StringLength(255)]
    public string? PaymentMethod { get; set; }
    
    /// <summary>
    /// Gets or sets the suffix of the payment instrument used for the payment made by other means in the dispute.
    /// </summary>
    [JsonPropertyName("payment_instrument_suffix")]
    [StringLength(4, MinimumLength = 2)]
    public string? PaymentInstrumentSuffix { get; set; }
}