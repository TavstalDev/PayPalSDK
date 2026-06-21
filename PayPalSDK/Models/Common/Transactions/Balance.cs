using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents a transaction balance snapshot in a specific currency, including total,
/// available, and withheld amounts as returned by the PayPal API.
/// </summary>
[DataContract]
public class Balance
{
    /// <summary>
    /// Indicates whether this is the primary balance entry for the account context.
    /// </summary>
    [JsonPropertyName("primary")]
    public bool Primary { get; set; }
    
    /// <summary>
    /// Gets or sets the three-letter ISO 4217 currency code for this balance
    /// (for example, <c>USD</c> or <c>EUR</c>).
    /// </summary>
    [JsonPropertyName("currency")]
    [StringLength(3)]
    public required string Currency { get; set; }
    
    /// <summary>
    /// Gets or sets the total balance amount in the specified <see cref="Currency"/>.
    /// </summary>
    [JsonPropertyName("total_balance")]
    public Money? TotalBalance { get; set; }
    
    /// <summary>
    /// Gets or sets the portion of the balance currently available for use.
    /// </summary>
    [JsonPropertyName("available_balance")]
    public Money? AvailableBalance { get; set; }
    
    /// <summary>
    /// Gets or sets the portion of the balance currently withheld or on hold.
    /// </summary>
    [JsonPropertyName("withheld_balance")]
    public Money? WithheldBalance { get; set; }
}