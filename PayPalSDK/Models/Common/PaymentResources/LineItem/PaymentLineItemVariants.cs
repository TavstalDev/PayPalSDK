using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources.LineItem;

/// <summary>
/// Represents the variant configuration for a payment line item.
/// </summary>
[DataContract]
public class PaymentLineItemVariants
{
    /// <summary>
    /// Gets or sets the collection of variant dimensions available for the line item.
    /// </summary>
    [JsonPropertyName("dimensions")]
    public List<PaymentLineItemVariantDimension>? Dimensions { get; set; }
}