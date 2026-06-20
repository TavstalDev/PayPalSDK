using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.PaymentResources.LineItem;

/// <summary>
/// Represents the adjustable quantity settings for a payment line item.
/// </summary>
[DataContract]
public class PaymentLineItemAdjustableQuantity
{
    /// <summary>
    /// Gets or sets the maximum quantity allowed for the line item.
    /// </summary>
    [JsonPropertyName("maximum")]
    public required int Maximum { get; set; }
}