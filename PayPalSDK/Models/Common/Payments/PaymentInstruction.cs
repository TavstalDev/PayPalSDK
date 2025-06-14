using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents payment instructions in the PayPal SDK.
/// </summary>
[DataContract]
public class PaymentInstruction
{
    /// <summary>
    /// Gets or sets the list of platform fees associated with the payment instruction.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the fees charged by the platform.
    /// </remarks>
    [DataMember(Name = "platform_fees", EmitDefaultValue = false)]
    public List<PlatformFee> PlatformFees { get; set; }

    /// <summary>
    /// Gets or sets the payee pricing tier ID.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 20 characters.
    /// </remarks>
    [DataMember(Name = "payee_pricing_tier_id", EmitDefaultValue = false)]
    [StringLength(20)]
    public string PayeePricingTierId { get; set; }

    /// <summary>
    /// Gets or sets the payee receivable foreign exchange rate ID.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 4000 characters.
    /// </remarks>
    [DataMember(Name = "payee_receivable_fx_rate_id", EmitDefaultValue = false)]
    [StringLength(4000)]
    public string PayeeReceivableFxRateId { get; set; }

    /// <summary>
    /// Gets or sets the disbursement mode.
    /// </summary>
    /// <remarks>
    /// This field is optional and must match the regular expression ^[A-Z_]+$.
    /// Refer to <see cref="Tavstal.PayPalSDK.Constants.DisbursementMode"/> for valid values.
    /// </remarks>
    [DataMember(Name = "disbursement_mode", EmitDefaultValue = false)]
    [StringLength(16)]
    [RegularExpression("^[A-Z_]+$")]
    public string DisbursementMode { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentInstruction"/> class.
    /// </summary>
    /// <param name="platformFees">The list of platform fees associated with the payment instruction.</param>
    /// <param name="payeePricingTierId">The payee pricing tier ID.</param>
    /// <param name="payeeReceivableFxRateId">The payee receivable foreign exchange rate ID.</param>
    /// <param name="disbursementMode">The disbursement mode.</param>
    public PaymentInstruction(List<PlatformFee> platformFees, string payeePricingTierId, string payeeReceivableFxRateId, string disbursementMode)
    {
        PlatformFees = platformFees;
        PayeePricingTierId = payeePricingTierId;
        PayeeReceivableFxRateId = payeeReceivableFxRateId;
        DisbursementMode = disbursementMode;
    }
}