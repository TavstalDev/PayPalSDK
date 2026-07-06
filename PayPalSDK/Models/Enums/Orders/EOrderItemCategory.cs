using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Orders;

/// <summary>
/// The category of an order item.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EOrderItemCategory>))]
public enum EOrderItemCategory
{
    /// <summary>Digital goods order item.</summary>
    DIGITAL_GOODS = 0,
    /// <summary>Physical goods order item.</summary>
    PHYSICAL_GOODS = 1,
    /// <summary>Donation order item.</summary>
    DONATION = 2
}
