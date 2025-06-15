using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources.Card;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources;

/// <summary>
/// Represents a card payment source in the PayPal SDK.
/// </summary>
[DataContract]
public class CardSource
{
    /// <summary>
    /// Gets or sets the card holder's name as it appears on the card.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 300 characters.
    /// </remarks>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [StringLength(300)]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the card number.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 19 characters.
    /// </remarks>
    [DataMember(Name = "number", EmitDefaultValue = false)]
    [StringLength(19)]
    public string Number { get; set; }

    /// <summary>
    /// Gets or sets the card security code (CVV).
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 4 characters.
    /// </remarks>
    [DataMember(Name = "security_code", EmitDefaultValue = false)]
    [StringLength(4)]
    public string SecurityCode { get; set; }

    /// <summary>
    /// Gets or sets the card expiry date in the format YYYY-MM.
    /// </summary>
    /// <remarks>
    /// This field is optional and must match the regular expression ^[0-9]{4}-(0[1-9]|1[0-2])$.
    /// </remarks>
    [DataMember(Name = "expiry", EmitDefaultValue = false)]
    [StringLength(7)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])$")]
    public string Expiry { get; set; }

    /// <summary>
    /// Gets or sets the billing address associated with the card.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the address details for billing.
    /// </remarks>
    [DataMember(Name = "billing_address", EmitDefaultValue = false)]
    public Address BillingAddress { get; set; }

    /// <summary>
    /// Gets or sets additional attributes for the card source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents metadata or extra information.
    /// </remarks>
    [DataMember(Name = "attributes", EmitDefaultValue = false)]
    public CardAttributes Attributes { get; set; }

    /// <summary>
    /// Gets or sets stored credentials for the card source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents saved payment details.
    /// </remarks>
    [DataMember(Name = "stored_credential", EmitDefaultValue = false)]
    public CardStoredCredentials StoredCredential { get; set; }

    /// <summary>
    /// Gets or sets the vault ID for the card source.
    /// </summary>
    /// <remarks>
    /// This field is optional, has a maximum length of 255 characters, and must match the regular expression ^[0-9a-zA-Z_-]+$.
    /// </remarks>
    [DataMember(Name = "vault_id", EmitDefaultValue = false)]
    [StringLength(255)]
    [RegularExpression("^[0-9a-zA-Z_-]+$")]
    public string VaultId { get; set; }

    /// <summary>
    /// Gets or sets the single-use token for the card source.
    /// </summary>
    /// <remarks>
    /// This field is optional, has a maximum length of 255 characters, and must match the regular expression ^[0-9a-zA-Z_-]+$.
    /// </remarks>
    [DataMember(Name = "single_use_token", EmitDefaultValue = false)]
    [StringLength(255)]
    [RegularExpression("^[0-9a-zA-Z_-]+$")]
    public string SingleUseToken { get; set; }

    /// <summary>
    /// Gets or sets the network token for the card source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents tokenized payment details.
    /// </remarks>
    [DataMember(Name = "network_token", EmitDefaultValue = false)]
    public NetworkToken NetworkToken { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CardSource"/> class.
    /// </summary>
    /// <param name="name">The card holder's name.</param>
    /// <param name="number">The card number.</param>
    /// <param name="securityCode">The card security code (CVV).</param>
    /// <param name="expiry">The card expiry date.</param>
    /// <param name="billingAddress">The billing address associated with the card.</param>
    /// <param name="attributes">Additional attributes for the card source.</param>
    /// <param name="storedCredential">Stored credentials for the card source.</param>
    /// <param name="vaultId">The vault ID for the card source.</param>
    /// <param name="singleUseToken">The single-use token for the card source.</param>
    /// <param name="networkToken">The network token for the card source.</param>
    public CardSource(string name, string number, string securityCode, string expiry, Address billingAddress, CardAttributes attributes, CardStoredCredentials storedCredential, string vaultId, string singleUseToken, NetworkToken networkToken)
    {
        Name = name;
        Number = number;
        SecurityCode = securityCode;
        Expiry = expiry;
        BillingAddress = billingAddress;
        Attributes = attributes;
        StoredCredential = storedCredential;
        VaultId = vaultId;
        SingleUseToken = singleUseToken;
        NetworkToken = networkToken;
    }
}