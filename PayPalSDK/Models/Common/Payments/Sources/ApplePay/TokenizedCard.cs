using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.ApplePay;

/// <summary>
/// Represents a tokenized card used in Apple Pay transactions within the PayPal SDK.
/// </summary>
[DataContract]
public class TokenizedCard
{
    /// <summary>
    /// Gets or sets the name associated with the tokenized card.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 300 characters.
    /// </remarks>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [StringLength(300)]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the card number associated with the tokenized card.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 19 characters.
    /// </remarks>
    [DataMember(Name = "number", EmitDefaultValue = false)]
    [StringLength(19)]
    public string Number { get; set; }

    /// <summary>
    /// Gets or sets the expiry date of the tokenized card.
    /// </summary>
    /// <remarks>
    /// This field is optional and must match the format YYYY-MM, where YYYY is the year and MM is the month.
    /// </remarks>
    [DataMember(Name = "expiry", EmitDefaultValue = false)]
    [StringLength(7)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])$")]
    public string Expiry { get; set; }

    /// <summary>
    /// Gets or sets the type of the tokenized card.
    /// </summary>
    /// <remarks>
    /// This field is optional and must match the regular expression pattern: ^[A-Z_]+$.
    /// </remarks>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    [StringLength(255)]
    [RegularExpression("^[A-Z_]+$")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets the brand of the tokenized card.
    /// </summary>
    /// <remarks>
    /// This field is optional and must match the regular expression pattern: ^[A-Z_]+$.
    /// </remarks>
    [DataMember(Name = "brand", EmitDefaultValue = false)]
    [StringLength(255)]
    [RegularExpression("^[A-Z_]+$")]
    public string Brand { get; set; }

    /// <summary>
    /// Gets or sets the billing address associated with the tokenized card.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the billing address details.
    /// </remarks>
    [DataMember(Name = "billing_address", EmitDefaultValue = false)]
    public Address BillingAddress { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TokenizedCard"/> class.
    /// </summary>
    /// <param name="name">The name associated with the tokenized card.</param>
    /// <param name="number">The card number associated with the tokenized card.</param>
    /// <param name="expiry">The expiry date of the tokenized card.</param>
    /// <param name="type">The type of the tokenized card.</param>
    /// <param name="brand">The brand of the tokenized card.</param>
    /// <param name="billingAddress">The billing address associated with the tokenized card.</param>
    public TokenizedCard(string name, string number, string expiry, string type, string brand, Address billingAddress)
    {
        Name = name;
        Number = number;
        Expiry = expiry;
        Type = type;
        Brand = brand;
        BillingAddress = billingAddress;
    }
}