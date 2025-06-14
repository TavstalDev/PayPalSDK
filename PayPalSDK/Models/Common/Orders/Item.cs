using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Billing;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Orders;

/// <summary>
/// Represents an item in the PayPal SDK.
/// </summary>
[DataContract]
public class Item
{
    /// <summary>
    /// Gets or sets the name of the item.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 127 characters.
    /// </remarks>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [StringLength(127)]
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets the quantity of the item.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 10 characters.
    /// </remarks>
    [DataMember(Name = "quantity", EmitDefaultValue = false)]
    [StringLength(10)]
    public required string Quantity { get; set; }

    /// <summary>
    /// Gets or sets the description of the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2048 characters.
    /// </remarks>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    [StringLength(2048)]
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the stock keeping unit (SKU) of the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 127 characters.
    /// </remarks>
    [DataMember(Name = "sku", EmitDefaultValue = false)]
    [StringLength(127)]
    public string Sku { get; set; }

    /// <summary>
    /// Gets or sets the URL of the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2048 characters.
    /// </remarks>
    [DataMember(Name = "url", EmitDefaultValue = false)]
    [StringLength(2048)]
    public string Url { get; set; }

    /// <summary>
    /// Gets or sets the category of the item.
    /// </summary>
    /// <remarks>
    /// The category corresponds to one of the predefined item categories in <see cref="Tavstal.PayPalSDK.Constants.ItemCategory"/>.
    /// This field is optional and has a maximum length of 20 characters.
    /// </remarks>
    [DataMember(Name = "category", EmitDefaultValue = false)]
    [StringLength(20)]
    public string Category { get; set; }

    /// <summary>
    /// Gets or sets the image URL of the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 2048 characters.
    /// </remarks>
    [DataMember(Name = "image_url", EmitDefaultValue = false)]
    [StringLength(2048)]
    public string ImageUrl { get; set; }

    /// <summary>
    /// Gets or sets the unit amount of the item.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the monetary value of the item.
    /// </remarks>
    [DataMember(Name = "unit_amount", EmitDefaultValue = false)]
    public required Money UnitAmount { get; set; }

    /// <summary>
    /// Gets or sets the tax applied to the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of the tax.
    /// </remarks>
    [DataMember(Name = "tax", EmitDefaultValue = false)]
    public Money Tax { get; set; }

    /// <summary>
    /// Gets or sets the Universal Product Code (UPC) of the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the UPC details.
    /// </remarks>
    [DataMember(Name = "upc", EmitDefaultValue = false)]
    public UPC UPC { get; set; }

    /// <summary>
    /// Gets or sets the billing plan associated with the item.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the billing plan details.
    /// </remarks>
    [DataMember(Name = "billing_plan", EmitDefaultValue = false)]
    public BillingPlan BillingPlan { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Item"/> class.
    /// </summary>
    /// <param name="name">The name of the item.</param>
    /// <param name="quantity">The quantity of the item.</param>
    /// <param name="description">The description of the item.</param>
    /// <param name="sku">The stock keeping unit (SKU) of the item.</param>
    /// <param name="url">The URL of the item.</param>
    /// <param name="category">The category of the item.</param>
    /// <param name="imageUrl">The image URL of the item.</param>
    /// <param name="unitAmount">The unit amount of the item.</param>
    /// <param name="tax">The tax applied to the item.</param>
    /// <param name="upc">The Universal Product Code (UPC) of the item.</param>
    /// <param name="billingPlan">The billing plan associated with the item.</param>
    public Item(string name, string quantity, string description, string sku, string url, string category, string imageUrl, Money unitAmount, Money tax, UPC upc, BillingPlan billingPlan)
    {
        Name = name;
        Quantity = quantity;
        Description = description;
        Sku = sku;
        Url = url;
        Category = category;
        ImageUrl = imageUrl;
        UnitAmount = unitAmount;
        Tax = tax;
        UPC = upc;
        BillingPlan = billingPlan;
    }
}