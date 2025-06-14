using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents a platform fee in the PayPal SDK.
/// </summary>
[DataContract]
public class PlatformFee
{
    /// <summary>
    /// Gets or sets the payee associated with the platform fee.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the recipient of the platform fee.
    /// </remarks>
    [DataMember(Name = "payee", EmitDefaultValue = false)]
    public Payee Payee { get; set; }

    /// <summary>
    /// Gets or sets the monetary amount of the platform fee.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the amount to be charged as a platform fee.
    /// </remarks>
    [DataMember(Name = "amount", EmitDefaultValue = false)]
    public required Money Amount { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PlatformFee"/> class.
    /// </summary>
    /// <param name="payee">The payee associated with the platform fee.</param>
    /// <param name="amount">The monetary amount of the platform fee.</param>
    public PlatformFee(Payee payee, Money amount)
    {
        Payee = payee;
        Amount = amount;
    }
}