using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources.GooglePay;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources;

/// <summary>
/// Represents a Google Pay payment source within the PayPal SDK.
/// </summary>
[DataContract]
public class GooglePaySource
{
    /// <summary>
    /// Gets or sets the name associated with the Google Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 300 characters.
    /// </remarks>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [StringLength(300)]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the email address associated with the Google Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 254 characters.
    /// </remarks>
    [DataMember(Name = "email_address", EmitDefaultValue = false)]
    [StringLength(254)]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the phone number associated with the Google Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the phone number details.
    /// </remarks>
    [DataMember(Name = "phone_number", EmitDefaultValue = false)]
    public PhoneNumber PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the card details associated with the Google Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the card used in the transaction.
    /// </remarks>
    [DataMember(Name = "card", EmitDefaultValue = false)]
    public required Models.Common.Card Card { get; set; }

    /// <summary>
    /// Gets or sets the decrypted token associated with the Google Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the decrypted token details.
    /// </remarks>
    [DataMember(Name = "decrypted_token", EmitDefaultValue = false)]
    public GoogleDecryptedToken DecryptedToken { get; set; }

    /// <summary>
    /// Gets or sets the assurance details associated with the Google Pay payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and provides additional assurance information.
    /// </remarks>
    [DataMember(Name = "assurance_details", EmitDefaultValue = false)]
    public AssuranceDetails AssuranceDetails { get; set; }

    /// <summary>
    /// Gets or sets the experience context for configuring the Google Pay payment experience.
    /// </summary>
    /// <remarks>
    /// This field is optional and provides additional configuration for the payment experience.
    /// </remarks>
    [DataMember(Name = "experience_context", EmitDefaultValue = false)]
    public ExperienceContext ExperienceContext { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="GooglePaySource"/> class.
    /// </summary>
    /// <param name="name">The name associated with the Google Pay payment source.</param>
    /// <param name="emailAddress">The email address associated with the payment source.</param>
    /// <param name="phoneNumber">The phone number associated with the payment source.</param>
    /// <param name="card">The card details associated with the payment source.</param>
    /// <param name="decryptedToken">The decrypted token associated with the payment source.</param>
    /// <param name="assuranceDetails">The assurance details associated with the payment source.</param>
    /// <param name="experienceContext">The experience context for the payment source.</param>
    public GooglePaySource(string name, string emailAddress, PhoneNumber phoneNumber, Models.Common.Card card, GoogleDecryptedToken decryptedToken, AssuranceDetails assuranceDetails, ExperienceContext experienceContext)
    {
        Name = name;
        EmailAddress = emailAddress;
        PhoneNumber = phoneNumber;
        Card = card;
        DecryptedToken = decryptedToken;
        AssuranceDetails = assuranceDetails;
        ExperienceContext = experienceContext;
    }
}