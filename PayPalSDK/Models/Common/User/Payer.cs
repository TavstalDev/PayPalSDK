using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.Payments.Sources.PayPal;

namespace Tavstal.PayPalSDK.Models.Common.User;

/// <summary>
/// Represents a payer within the PayPal SDK.
/// </summary>
[DataContract]
public class Payer
{
    /// <summary>
    /// Gets or sets the email address of the payer.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 254 characters.
    /// The email address must match the specified regular expression pattern.
    /// </remarks>
    [DataMember(Name = "email_address", EmitDefaultValue = false)]
    [StringLength(254)]
    [RegularExpression("(?:[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*|(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?|\\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-zA-Z0-9-]*[a-zA-Z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the payer.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 13 characters.
    /// The payer ID must match the specified regular expression pattern.
    /// </remarks>
    [DataMember(Name = "payer_id", EmitDefaultValue = false)]
    [StringLength(13)]
    [RegularExpression("^[2-9A-HJ-NP-Z]{13}$")]
    public string PayerId { get; set; }

    /// <summary>
    /// Gets or sets the name of the payer.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the payer's name details.
    /// </remarks>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public Name Name { get; set; }

    /// <summary>
    /// Gets or sets the phone details of the payer.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the payer's phone information.
    /// </remarks>
    [DataMember(Name = "phone", EmitDefaultValue = false)]
    public Phone Phone { get; set; }

    /// <summary>
    /// Gets or sets the birth date of the payer.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 10 characters.
    /// The birth date must match the specified regular expression pattern (YYYY-MM-DD).
    /// </remarks>
    [DataMember(Name = "birth_date", EmitDefaultValue = false)]
    [StringLength(10)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$")]
    public string BirthDate { get; set; }

    /// <summary>
    /// Gets or sets the tax information of the payer.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the payer's tax details.
    /// </remarks>
    [DataMember(Name = "tax_info", EmitDefaultValue = false)]
    public TaxInfo TaxInfo { get; set; }

    /// <summary>
    /// Gets or sets the address of the payer.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the payer's address details.
    /// </remarks>
    [DataMember(Name = "address", EmitDefaultValue = false)]
    public Address Address { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Payer"/> class.
    /// </summary>
    /// <param name="emailAddress">The email address of the payer.</param>
    /// <param name="payerId">The unique identifier of the payer.</param>
    /// <param name="name">The name of the payer.</param>
    /// <param name="phone">The phone details of the payer.</param>
    /// <param name="birthDate">The birth date of the payer.</param>
    /// <param name="taxInfo">The tax information of the payer.</param>
    /// <param name="address">The address of the payer.</param>
    public Payer(string emailAddress, string payerId, Name name, Phone phone, string birthDate, TaxInfo taxInfo, Address address)
    {
        EmailAddress = emailAddress;
        PayerId = payerId;
        Name = name;
        Phone = phone;
        BirthDate = birthDate;
        TaxInfo = taxInfo;
        Address = address;
    }
}