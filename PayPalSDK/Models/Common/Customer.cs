using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a customer object in the PayPal SDK.
/// </summary>
[DataContract]
public class Customer
{
    /// <summary>
    /// Gets or sets the unique identifier for the customer.
    /// </summary>
    /// <remarks>
    /// This field is optional, has a maximum length of 22 characters, and must match the regular expression ^[0-9a-zA-Z_-]+$.
    /// </remarks>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    [StringLength(22)]
    [RegularExpression("^[0-9a-zA-Z_-]+$")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the email address of the customer.
    /// </summary>
    /// <remarks>
    /// This field is optional, has a maximum length of 254 characters, and must match a valid email address format.
    /// </remarks>
    [DataMember(Name = "email_address", EmitDefaultValue = false)]
    [StringLength(254)]
    [RegularExpression("(?:[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*|(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?|\\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-zA-Z0-9-]*[a-zA-Z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the phone details of the customer.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the customer's phone information.
    /// </remarks>
    [DataMember(Name = "phone", EmitDefaultValue = false)]
    public Phone Phone { get; set; }

    /// <summary>
    /// Gets or sets the name details of the customer.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the customer's name information.
    /// </remarks>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public Name Name { get; set; }

    /// <summary>
    /// Gets or sets the merchant-specific customer identifier.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 64 characters.
    /// </remarks>
    [DataMember(Name = "merchant_customer_id", EmitDefaultValue = false)]
    [StringLength(64)]
    public string MerchantCustomerId { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Customer"/> class.
    /// </summary>
    /// <param name="id">The unique identifier for the customer.</param>
    /// <param name="emailAddress">The email address of the customer.</param>
    /// <param name="phone">The phone details of the customer.</param>
    /// <param name="name">The name details of the customer.</param>
    /// <param name="merchantCustomerId">The merchant-specific customer identifier.</param>
    public Customer(string id, string emailAddress, Phone phone, Name name = null, string merchantCustomerId = null)
    {
        Id = id;
        EmailAddress = emailAddress;
        Phone = phone;
        Name = name;
        MerchantCustomerId = merchantCustomerId;
    }
}