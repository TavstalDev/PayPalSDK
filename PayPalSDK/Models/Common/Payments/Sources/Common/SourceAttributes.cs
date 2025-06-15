using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources.Card;
using Tavstal.PayPalSDK.Models.Common.User;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.Common;

/// <summary>
/// Represents the attributes of a card payment source in the PayPal SDK.
/// </summary>
[DataContract]
public class SourceAttributes
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
    /// Initializes a new instance of the <see cref="SourceAttributes"/> class.
    /// </summary>
    /// <param name="customer">The customer details associated with the card payment source.</param>
    /// <param name="vault">The vault details associated with the card payment source.</param>
    public SourceAttributes(Customer customer, Vault vault)
    {
        Customer = customer;
        Vault = vault;
    }
}