using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Subscriptions;

/// <summary>
/// The unit of time for billing intervals.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EIntervalUnit>))]
public enum EIntervalUnit
{
    /// <summary>Day interval unit.</summary>
    DAY = 0,
    /// <summary>Week interval unit.</summary>
    WEEK = 1,
    /// <summary>Month interval unit.</summary>
    MONTH = 2,
    /// <summary>Year interval unit.</summary>
    YEAR = 3
}
