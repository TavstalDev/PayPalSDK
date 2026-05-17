using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a range of monetary values with lower and upper bounds.
/// </summary>
[DataContract]
public class MoneyRange
{
    /// <summary>
    /// Gets or sets the lower bound of the monetary range.
    /// </summary>
    [JsonPropertyName("lower_amount")]
    public required Money LowerAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the upper bound of the monetary range.
    /// </summary>
    [JsonPropertyName("upper_amount")]
    public required Money UpperAmount { get; set; }
}