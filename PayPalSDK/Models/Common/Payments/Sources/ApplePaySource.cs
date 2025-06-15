using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources.ApplePay;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources.Card;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources.Common;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources;

/// <summary>
/// Represents an Apple Pay payment source within the PayPal SDK.
/// </summary>
[DataContract]
public class ApplePaySource
{
    /// <summary>
    /// Gets or sets the unique identifier for the Apple Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 250 characters.
    /// </remarks>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    [StringLength(250)]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the stored credentials associated with the Apple Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents card-related stored credentials.
    /// </remarks>
    [DataMember(Name = "stored_credential", EmitDefaultValue = false)]
    public CardStoredCredentials StoredCredential { get; set; }

    /// <summary>
    /// Gets or sets the attributes associated with the Apple Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents additional metadata for the payment source.
    /// </remarks>
    [DataMember(Name = "attributes", EmitDefaultValue = false)]
    public SourceAttributes Attributes { get; set; }

    /// <summary>
    /// Gets or sets the name associated with the Apple Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 300 characters.
    /// </remarks>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [StringLength(300)]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the email address associated with the Apple Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and must be a valid email address format with a maximum length of 254 characters.
    /// </remarks>
    [DataMember(Name = "email_address", EmitDefaultValue = false)]
    [StringLength(254)]
    [RegularExpression("^(?:[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[A-Za-z0-9-]*[A-Za-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])$")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the phone number associated with the Apple Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the phone number details.
    /// </remarks>
    [DataMember(Name = "phone_number", EmitDefaultValue = false)]
    public PhoneNumber PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the decrypted token associated with the Apple Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the decrypted token details.
    /// </remarks>
    [DataMember(Name = "decrypted_token", EmitDefaultValue = false)]
    public AppleDecryptedToken DecryptedToken { get; set; }

    /// <summary>
    /// Gets or sets the vault ID associated with the Apple Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and must match the regular expression pattern: ^[0-9a-zA-Z_-]+$.
    /// </remarks>
    [DataMember(Name = "vault_id", EmitDefaultValue = false)]
    [StringLength(255)]
    [RegularExpression("^[0-9a-zA-Z_-]+$")]
    public string VaultId { get; set; }

    /// <summary>
    /// Gets or sets the experience context for configuring the Apple Pay payment experience.
    /// </summary>
    /// <remarks>
    /// This field is optional and provides additional configuration for the payment experience.
    /// </remarks>
    [DataMember(Name = "experience_context", EmitDefaultValue = false)]
    public ExperienceContext ExperienceContext { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ApplePaySource"/> class.
    /// </summary>
    /// <param name="id">The unique identifier for the Apple Pay payment source.</param>
    /// <param name="storedCredential">The stored credentials associated with the payment source.</param>
    /// <param name="attributes">The attributes associated with the payment source.</param>
    /// <param name="name">The name associated with the payment source.</param>
    /// <param name="emailAddress">The email address associated with the payment source.</param>
    /// <param name="phoneNumber">The phone number associated with the payment source.</param>
    /// <param name="decryptedToken">The decrypted token associated with the payment source.</param>
    /// <param name="vaultId">The vault ID associated with the payment source.</param>
    /// <param name="experienceContext">The experience context for the payment source.</param>
    public ApplePaySource(string id, CardStoredCredentials storedCredential, SourceAttributes attributes, string name, string emailAddress, PhoneNumber phoneNumber, AppleDecryptedToken decryptedToken, string vaultId, ExperienceContext experienceContext)
    {
        Id = id;
        StoredCredential = storedCredential;
        Attributes = attributes;
        Name = name;
        EmailAddress = emailAddress;
        PhoneNumber = phoneNumber;
        DecryptedToken = decryptedToken;
        VaultId = vaultId;
        ExperienceContext = experienceContext;
    }
}