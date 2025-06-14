using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.Card;

/// <summary>
/// Represents the attributes of a card payment source in the PayPal SDK.
/// </summary>
[DataContract]
public class Attributes
{
    /// <summary>
    /// Gets or sets the customer details associated with the card payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the customer information.
    /// </remarks>
    [DataMember(Name = "customer", EmitDefaultValue = false)]
    public Customer Customer { get; set; }

    /// <summary>
    /// Gets or sets the vault details associated with the card payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the vault information.
    /// </remarks>
    [DataMember(Name = "vault", EmitDefaultValue = false)]
    public Vault Vault { get; set; }

    /// <summary>
    /// Gets or sets the verification details associated with the card payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the verification information.
    /// </remarks>
    [DataMember(Name = "verification", EmitDefaultValue = false)]
    public Verification Verification { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Attributes"/> class.
    /// </summary>
    /// <param name="customer">The customer details associated with the card payment source.</param>
    /// <param name="vault">The vault details associated with the card payment source.</param>
    /// <param name="verification">The verification details associated with the card payment source.</param>
    public Attributes(Customer customer, Vault vault, Verification verification)
    {
        Customer = customer;
        Vault = vault;
        Verification = verification;
    }
}