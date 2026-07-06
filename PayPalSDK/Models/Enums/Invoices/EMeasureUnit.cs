using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Invoices;

/// <summary>
/// The unit of measure for invoice line items.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EMeasureUnit>))]
public enum EMeasureUnit
{
    /// <summary>Quantity-based measure unit.</summary>
    QUANTITY = 0,
    /// <summary>Hours-based measure unit.</summary>
    HOURS = 1,
    /// <summary>Monetary amount measure unit.</summary>
    AMOUNT = 2
}
