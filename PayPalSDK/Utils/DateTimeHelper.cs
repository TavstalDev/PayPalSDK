using System.Globalization;

namespace Tavstal.PayPalSDK.Utils;

/// <summary>
/// Provides helper methods for converting <see cref="DateTime"/> values
/// to and from ISO 8601 string representations.
/// </summary>
public static class DateTimeHelper
{
    /// <summary>
    /// Converts the specified <see cref="DateTime"/> value to a UTC ISO 8601 string.
    /// </summary>
    /// <param name="dateTime">The date and time value to convert.</param>
    /// <returns>A string representation of the specified date and time in ISO 8601 format.</returns>
    public static string ToISO8601(DateTime dateTime) => 
        dateTime.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK");
    
    /// <summary>
    /// Parses an ISO 8601 date/time string into a nullable <see cref="DateTime"/> value.
    /// </summary>
    /// <param name="dateTimeString">The ISO 8601 date/time string to parse, or <see langword="null"/>.</param>
    /// <returns>
    /// A <see cref="DateTime"/> value if <paramref name="dateTimeString"/> is not <see langword="null"/>;
    /// otherwise, <see langword="null"/>.
    /// </returns>
    public static DateTime? FromISO8601(string? dateTimeString) => dateTimeString == null ? null :
        DateTime.Parse(dateTimeString, null, DateTimeStyles.RoundtripKind);
    
}