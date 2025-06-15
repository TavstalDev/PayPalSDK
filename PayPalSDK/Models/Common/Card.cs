using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a card used in transactions within the PayPal SDK.
/// </summary>
[DataContract]
public class Card
{
    /// <summary>
    /// Gets or sets the name associated with the card.
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
    /// This field is required and has a maximum length of 19 characters.
    /// </remarks>
    [DataMember(Name = "number", EmitDefaultValue = false)]
    [StringLength(19)]
    public required string Number { get; set; }

    /// <summary>
    /// Gets or sets the expiry date of the card.
    /// </summary>
    /// <remarks>
    /// This field is required and must match the format YYYY-MM, where YYYY is the year and MM is the month.
    /// </remarks>
    [DataMember(Name = "expiry", EmitDefaultValue = false)]
    [StringLength(7)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])$")]
    public required string Expiry { get; set; }

    /// <summary>
    /// Gets or sets the type of the card.
    /// </summary>
    /// <remarks>
    /// This field is optional and must match the regular expression pattern: ^[A-Z_]+$.
    /// Refer to <see cref="Tavstal.PayPalSDK.Constants.CardType"/> for valid card types.
    /// </remarks>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    [StringLength(255)]
    [RegularExpression("^[A-Z_]+$")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets the brand of the card.
    /// </summary>
    /// <remarks>
    /// This field is optional and must match the regular expression pattern: ^[A-Z_]+$.
    /// Refer to <see cref="Tavstal.PayPalSDK.Constants.CardNetwork"/> for valid card brands.
    /// </remarks>
    [DataMember(Name = "brand", EmitDefaultValue = false)]
    [StringLength(255)]
    [RegularExpression("^[A-Z_]+$")]
    public string Brand { get; set; }

    /// <summary>
    /// Gets or sets the billing address associated with the card.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the billing address details.
    /// </remarks>
    [DataMember(Name = "billing_address", EmitDefaultValue = false)]
    public Address BillingAddress { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Card"/> class.
    /// </summary>
    /// <param name="name">The name associated with the card.</param>
    /// <param name="number">The card number.</param>
    /// <param name="expiry">The expiry date of the card.</param>
    /// <param name="type">The type of the card.</param>
    /// <param name="brand">The brand of the card.</param>
    /// <param name="billingAddress">The billing address associated with the card.</param>
    public Card(string name, string number, string expiry, string type, string brand, Address billingAddress)
    {
        Name = name;
        Number = number;
        Expiry = expiry;
        Type = type;
        Brand = brand;
        BillingAddress = billingAddress;
    }
}