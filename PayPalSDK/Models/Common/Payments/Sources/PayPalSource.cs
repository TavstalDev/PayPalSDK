using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources.Common;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources.PayPal;
using Tavstal.PayPalSDK.Models.Common.User;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources;

/// <summary>
/// Represents a PayPal payment source within the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PayPalSource
{
    /// <summary>
    /// Gets or sets the experience context for configuring the PayPal payment experience.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("experience_context")]
    public ExperienceContext? ExperienceContext { get; set; }

    /// <summary>
    /// Gets or sets the billing agreement ID associated with the payment source.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("billing_agreement_id")]
    [StringLength(128)]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public string? BillingAgreementId { get; set; }

    /// <summary>
    /// Gets or sets the stored credentials used for the payment source.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("stored_credential")]
    public PayPalStoredCredentials? StoredCredential { get; set; }

    /// <summary>
    /// Gets or sets the vault ID associated with the payment source.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("vault_id")]
    [StringLength(255)]
    [RegularExpression("^[0-9a-zA-Z_-]+$")]
    public string? VaultId { get; set; }

    /// <summary>
    /// Gets or sets the email address associated with the payment source.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("email_address")]
    [StringLength(254)]
    [RegularExpression("(?:[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*|(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?|\\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-zA-Z0-9-]*[a-zA-Z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])")]
    public string? EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the name associated with the payment source.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("name")]
    public Name? Name { get; set; }

    /// <summary>
    /// Gets or sets the phone number associated with the payment source.
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("phone")]
    public Phone? Phone { get; set; }

    /// <summary>
    /// Gets or sets the birthdate of the individual associated with the payment source.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("birth_date")]
    [StringLength(10)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$")]
    public string? BirthDate { get; set; }

    /// <summary>
    /// Gets or sets the tax information associated with the payment source.
    /// </summary>
    [FluentMember(8)]
    [FluentSkippable]
    [JsonPropertyName("tax_info")]
    public TaxInfo? TaxInfo { get; set; }

    /// <summary>
    /// Gets or sets the address associated with the payment source.
    /// </summary>
    [FluentMember(9)]
    [FluentSkippable]
    [JsonPropertyName("address")]
    public Address? Address { get; set; }

    /// <summary>
    /// Gets or sets the attributes of the payment source.
    /// </summary>
    [FluentMember(10)]
    [FluentSkippable]
    [JsonPropertyName("attributes")]
    public SourceAttributes? Attributes { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(11, "Build")]
    public void Build() { }
}