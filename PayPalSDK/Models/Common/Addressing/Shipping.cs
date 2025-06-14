using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Addressing;

/// <summary>
/// Represents shipping details including type, name, email address, phone number, address, and shipping options.
/// </summary>
[DataContract]
public class Shipping
{
    /// <summary>
    /// Gets or sets the type of shipping.
    /// </summary>
    /// <remarks>
    /// This property corresponds to one of the predefined shipping types in <see cref="Tavstal.PayPalSDK.Constants.ShippingType"/>.
    /// It is optional and will not be emitted if its value is null or default.
    /// </remarks>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets the name of the person associated with the shipping.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the recipient's name.
    /// </remarks>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public Person Name { get; set; }

    /// <summary>
    /// Gets or sets the email address of the person associated with the shipping.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 254 characters.
    /// The email address must match the specified regular expression format.
    /// </remarks>
    [DataMember(Name = "email_address", EmitDefaultValue = false)]
    [StringLength(254, ErrorMessage = "Email address cannot exceed 254 characters.")]
    [RegularExpression("^(?:[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[A-Za-z0-9-]*[A-Za-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])$", ErrorMessage = "Invalid email address format.")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the phone number of the person associated with the shipping.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the recipient's phone number.
    /// </remarks>
    [DataMember(Name = "phone_number", EmitDefaultValue = false)]
    public PhoneNumber PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the address associated with the shipping.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the shipping address.
    /// </remarks>
    [DataMember(Name = "address", EmitDefaultValue = false)]
    public Address Address { get; set; }

    /// <summary>
    /// Gets or sets the list of shipping options available.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the available shipping options.
    /// </remarks>
    [DataMember(Name = "options", EmitDefaultValue = false)]
    public List<ShippingOption> Options { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Shipping"/> class.
    /// </summary>
    /// <param name="type">The type of shipping.</param>
    /// <param name="name">The name of the person associated with the shipping.</param>
    /// <param name="emailAddress">The email address of the person associated with the shipping.</param>
    /// <param name="phoneNumber">The phone number of the person associated with the shipping.</param>
    /// <param name="address">The address associated with the shipping.</param>
    /// <param name="options">The list of shipping options available.</param>
    public Shipping(string type, Person name, string emailAddress, PhoneNumber phoneNumber, Address address, List<ShippingOption> options)
    {
        Type = type;
        Name = name;
        EmailAddress = emailAddress;
        PhoneNumber = phoneNumber;
        Address = address;
        Options = options;
    }
}