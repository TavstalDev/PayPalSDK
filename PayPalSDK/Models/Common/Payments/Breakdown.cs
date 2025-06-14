using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments;

/// <summary>
/// Represents the breakdown of monetary amounts in the PayPal SDK.
/// </summary>
[DataContract]
public class Breakdown
{
    /// <summary>
    /// Gets or sets the total amount for items.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of the items.
    /// </remarks>
    [DataMember(Name = "item_total", EmitDefaultValue = false)]
    public Money ItemTotal { get; set; }

    /// <summary>
    /// Gets or sets the shipping amount.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of shipping.
    /// </remarks>
    [DataMember(Name = "shipping", EmitDefaultValue = false)]
    public Money Shipping { get; set; }

    /// <summary>
    /// Gets or sets the handling amount.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of handling.
    /// </remarks>
    [DataMember(Name = "handling", EmitDefaultValue = false)]
    public Money Handling { get; set; }

    /// <summary>
    /// Gets or sets the total tax amount.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of taxes.
    /// </remarks>
    [DataMember(Name = "tax_total", EmitDefaultValue = false)]
    public Money TaxTotal { get; set; }

    /// <summary>
    /// Gets or sets the insurance amount.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of insurance.
    /// </remarks>
    [DataMember(Name = "insurance", EmitDefaultValue = false)]
    public Money Insurance { get; set; }

    /// <summary>
    /// Gets or sets the shipping discount amount.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of shipping discounts.
    /// </remarks>
    [DataMember(Name = "shipping_discount", EmitDefaultValue = false)]
    public Money ShippingDiscount { get; set; }

    /// <summary>
    /// Gets or sets the discount amount.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of discounts.
    /// </remarks>
    [DataMember(Name = "discount", EmitDefaultValue = false)]
    public Money Discount { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Breakdown"/> class.
    /// </summary>
    /// <param name="itemTotal">The total amount for items.</param>
    /// <param name="shipping">The shipping amount.</param>
    /// <param name="handling">The handling amount.</param>
    /// <param name="taxTotal">The total tax amount.</param>
    /// <param name="insurance">The insurance amount.</param>
    /// <param name="shippingDiscount">The shipping discount amount.</param>
    /// <param name="discount">The discount amount.</param>
    public Breakdown(Money itemTotal, Money shipping, Money handling, Money taxTotal, Money insurance, Money shippingDiscount, Money discount)
    {
        ItemTotal = itemTotal;
        Shipping = shipping;
        Handling = handling;
        TaxTotal = taxTotal;
        Insurance = insurance;
        ShippingDiscount = shippingDiscount;
        Discount = discount;
    }
}