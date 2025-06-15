using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.ApplePay;

/// <summary>
/// Represents payment data for Apple Pay transactions within the PayPal SDK.
/// </summary>
[DataContract]
public class PaymentData
{
    /// <summary>
    /// Gets or sets the cryptogram associated with the Apple Pay payment data.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2000 characters.
    /// </remarks>
    [DataMember(Name = "cryptogram", EmitDefaultValue = false)]
    [StringLength(2000)]
    public string Cryptogram { get; set; }

    /// <summary>
    /// Gets or sets the ECI (Electronic Commerce Indicator) associated with the Apple Pay payment data.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 256 characters.
    /// </remarks>
    [DataMember(Name = "eci_indicator", EmitDefaultValue = false)]
    [StringLength(256)]
    public string EciIndicator { get; set; }

    /// <summary>
    /// Gets or sets the EMV (Europay, Mastercard, and Visa) data associated with the Apple Pay payment data.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2000 characters.
    /// </remarks>
    [DataMember(Name = "emv_data", EmitDefaultValue = false)]
    [StringLength(2000)]
    public string EmvData { get; set; }

    /// <summary>
    /// Gets or sets the PIN associated with the Apple Pay payment data.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2000 characters.
    /// </remarks>
    [DataMember(Name = "pin", EmitDefaultValue = false)]
    [StringLength(2000)]
    public string Pin { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PaymentData"/> class.
    /// </summary>
    /// <param name="cryptogram">The cryptogram associated with the Apple Pay payment data.</param>
    /// <param name="eciIndicator">The ECI (Electronic Commerce Indicator) associated with the Apple Pay payment data.</param>
    /// <param name="emvData">The EMV (Europay, Mastercard, and Visa) data associated with the Apple Pay payment data.</param>
    /// <param name="pin">The PIN associated with the Apple Pay payment data.</param>
    public PaymentData(string cryptogram, string eciIndicator, string emvData, string pin)
    {
        Cryptogram = cryptogram;
        EciIndicator = eciIndicator;
        EmvData = emvData;
        Pin = pin;
    }
}