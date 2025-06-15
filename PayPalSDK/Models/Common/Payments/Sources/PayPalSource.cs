using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources.Common;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources.PayPal;
using Tavstal.PayPalSDK.Models.Common.User;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources;

/// <summary>
/// Represents a PayPal payment source within the PayPal SDK.
/// </summary>
[DataContract]
public class PayPalSource
{
    /// <summary>
    /// Gets or sets the experience context for configuring the PayPal payment experience.
    /// </summary>
    [DataMember(Name = "experience_context", EmitDefaultValue = false)]
    public ExperienceContext ExperienceContext { get; set; }

    /// <summary>
    /// Gets or sets the billing agreement ID associated with the payment source.
    /// </summary>
    [DataMember(Name = "billing_agreement_id", EmitDefaultValue = false)]
    [StringLength(128)]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public string BillingAgreementId { get; set; }

    /// <summary>
    /// Gets or sets the stored credentials used for the payment source.
    /// </summary>
    [DataMember(Name = "stored_credential", EmitDefaultValue = false)]
    public PayPalStoredCredentials StoredCredential { get; set; }

    /// <summary>
    /// Gets or sets the vault ID associated with the payment source.
    /// </summary>
    [DataMember(Name = "vault_id", EmitDefaultValue = false)]
    [StringLength(255)]
    [RegularExpression("^[0-9a-zA-Z_-]+$")]
    public string VaultId { get; set; }

    /// <summary>
    /// Gets or sets the email address associated with the payment source.
    /// </summary>
    [DataMember(Name = "email_address", EmitDefaultValue = false)]
    [StringLength(254)]
    [RegularExpression("(?:[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*|(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?|\\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-zA-Z0-9-]*[a-zA-Z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the name associated with the payment source.
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public Name Name { get; set; }

    /// <summary>
    /// Gets or sets the phone number associated with the payment source.
    /// </summary>
    [DataMember(Name = "phone", EmitDefaultValue = false)]
    public Phone Phone { get; set; }

    /// <summary>
    /// Gets or sets the birth date of the individual associated with the payment source.
    /// </summary>
    [DataMember(Name = "birth_date", EmitDefaultValue = false)]
    [StringLength(10)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$")]
    public string BirthDate { get; set; }

    /// <summary>
    /// Gets or sets the tax information associated with the payment source.
    /// </summary>
    [DataMember(Name = "tax_info", EmitDefaultValue = false)]
    public TaxInfo TaxInfo { get; set; }

    /// <summary>
    /// Gets or sets the address associated with the payment source.
    /// </summary>
    [DataMember(Name = "address", EmitDefaultValue = false)]
    public Address Address { get; set; }

    /// <summary>
    /// Gets or sets the attributes of the payment source.
    /// </summary>
    [DataMember(Name = "attributes", EmitDefaultValue = false)]
    public SourceAttributes Attributes { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PayPalSource"/> class.
    /// </summary>
    /// <param name="experienceContext">The experience context for the payment source.</param>
    /// <param name="billingAgreementId">The billing agreement ID.</param>
    /// <param name="storedCredential">The stored credentials.</param>
    /// <param name="vaultId">The vault ID.</param>
    /// <param name="emailAddress">The email address.</param>
    /// <param name="name">The name associated with the payment source.</param>
    /// <param name="phone">The phone number.</param>
    /// <param name="birthDate">The birth date.</param>
    /// <param name="taxInfo">The tax information.</param>
    /// <param name="address">The address.</param>
    /// <param name="attributes">The attributes of the payment source.</param>
    public PayPalSource(ExperienceContext experienceContext, string billingAgreementId, PayPalStoredCredentials storedCredential, string vaultId, string emailAddress, Name name, Phone phone, string birthDate, TaxInfo taxInfo, Address address, SourceAttributes attributes)
    {
        ExperienceContext = experienceContext;
        BillingAgreementId = billingAgreementId;
        StoredCredential = storedCredential;
        VaultId = vaultId;
        EmailAddress = emailAddress;
        Name = name;
        Phone = phone;
        BirthDate = birthDate;
        TaxInfo = taxInfo;
        Address = address;
        Attributes = attributes;
    }
}