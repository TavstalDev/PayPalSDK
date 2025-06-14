using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Billing;

/// <summary>
/// Represents a pricing scheme in the PayPal SDK.
/// </summary>
[DataContract]
public class PricingScheme
{
    /// <summary>
    /// Gets or sets the pricing model type for the scheme.
    /// </summary>
    /// <remarks>
    /// The pricing model corresponds to one of the predefined models in <see cref="Tavstal.PayPalSDK.Constants.PricingModelType"/>.
    /// This field is required and has a maximum length of 24 characters.
    /// </remarks>
    [DataMember(Name = "pricing_model", EmitDefaultValue = false)]
    [StringLength(24)]
    public required string PricingModel { get; set; }

    /// <summary>
    /// Gets or sets the price associated with the pricing scheme.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of the price.
    /// </remarks>
    [DataMember(Name = "price", EmitDefaultValue = false)]
    public Money Price { get; set; }

    /// <summary>
    /// Gets or sets the reload threshold amount for the pricing scheme.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of the reload threshold amount.
    /// </remarks>
    [DataMember(Name = "reload_threshold_amount", EmitDefaultValue = false)]
    public Money ReloadThresholdAmount { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PricingScheme"/> class.
    /// </summary>
    /// <param name="pricingModel">The pricing model type for the scheme.</param>
    /// <param name="price">The price associated with the pricing scheme.</param>
    /// <param name="reloadThresholdAmount">The reload threshold amount for the pricing scheme.</param>
    public PricingScheme(string pricingModel, Money price, Money reloadThresholdAmount)
    {
        PricingModel = pricingModel;
        Price = price;
        ReloadThresholdAmount = reloadThresholdAmount;
    }
}