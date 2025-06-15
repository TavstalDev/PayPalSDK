using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.PayPal;

/// <summary>
/// Represents stored credentials used in card payments within the PayPal SDK.
/// </summary>
[DataContract]
public class PayPalStoredCredentials
{
    /// <summary>
    /// Gets or sets the payment initiator.
    /// Possible values are defined in <see cref="Tavstal.PayPalSDK.Constants.PaymentInitators"/>.
    /// </summary>
    [DataMember(Name = "payment_initiator", EmitDefaultValue = false)]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public required string PaymentInitiator { get; set; }

    /// <summary>
    /// Gets or sets the charge pattern for the stored credentials.
    /// </summary>
    [DataMember(Name = "charge_pattern", EmitDefaultValue = false)]
    [StringLength(30)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public required string ChargePattern { get; set; }

    /// <summary>
    /// Gets or sets the usage pattern for the stored credentials.
    /// </summary>
    [StringLength(30)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string UsagePattern { get; set; }

    /// <summary>
    /// Gets or sets the usage of the credential.
    /// Possible values are defined in <see cref="Tavstal.PayPalSDK.Constants.CredentialUsage"/>.
    /// </summary>
    [DataMember(Name = "usage", EmitDefaultValue = false)]
    [StringLength(255)]
    [RegularExpression("^[0-9A-Z_]+$")]
    public string Usage { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PayPalStoredCredentials"/> class.
    /// </summary>
    /// <param name="paymentInitiator">The payment initiator.</param>
    /// <param name="chargePattern">The charge pattern for the stored credentials.</param>
    /// <param name="usagePattern">The usage pattern for the stored credentials.</param>
    /// <param name="usage">The usage of the credential.</param>
    public PayPalStoredCredentials(string paymentInitiator, string chargePattern, string usagePattern, string usage)
    {
        PaymentInitiator = paymentInitiator;
        ChargePattern = chargePattern;
        UsagePattern = usagePattern;
        Usage = usage;
    }
}