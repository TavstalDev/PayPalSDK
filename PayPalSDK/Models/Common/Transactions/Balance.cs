using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents a transaction balance snapshot in a specific currency, including total,
/// available, and withheld amounts as returned by the PayPal API.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Balance
{
    /// <summary>
    /// Indicates whether this is the primary balance entry for the account context.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("primary")]
    public bool Primary { get; set; }
    
    /// <summary>
    /// Gets or sets the three-letter ISO 4217 currency code for this balance
    /// (for example, <c>USD</c> or <c>EUR</c>).
    /// </summary>
    [FluentMember(0)]
    [Required]
    [JsonPropertyName("currency")]
    [StringLength(3)]
    public string? Currency { get; set; }
    
    /// <summary>
    /// Gets or sets the total balance amount in the specified <see cref="Currency"/>.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("total_balance")]
    public Money? TotalBalance { get; set; }
    
    /// <summary>
    /// Gets or sets the portion of the balance currently available for use.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("available_balance")]
    public Money? AvailableBalance { get; set; }
    
    /// <summary>
    /// Gets or sets the portion of the balance currently withheld or on hold.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("withheld_balance")]
    public Money? WithheldBalance { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(5, "Build")]
    public void Build() { }
}