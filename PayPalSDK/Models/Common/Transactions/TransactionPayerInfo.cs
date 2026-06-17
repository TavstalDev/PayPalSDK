using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.User;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents payer-related information for a transaction, including account,
/// contact, identity, country, and address details.
/// </summary>
[DataContract]
public class TransactionPayerInfo
{
    /// <summary>
    /// Gets or sets the payer's PayPal account identifier.
    /// </summary>
    [JsonPropertyName("account_id")]
    [StringLength(13)]
    public string? AccountId { get; set; }
    
    /// <summary>
    /// Gets or sets the payer address verification status code.
    /// </summary>
    [JsonPropertyName("address_status")]
    [StringLength(1)]
    public string? AddressStatus { get; set; }
    
    /// <summary>
    /// Gets or sets the payer account status code.
    /// </summary>
    [JsonPropertyName("payer_status")]
    [StringLength(1)]
    public string? PayerStatus { get; set; }
    
    /// <summary>
    /// Gets or sets the payer's email address.
    /// </summary>
    [JsonPropertyName("email_address")]
    [StringLength(254)]
    [RegularExpression("^.+@[^\"\\-].+$")]
    public string? EmailAddress { get; set; }
    
    /// <summary>
    /// Gets or sets the payer's phone number information.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public PhoneNumber? PhoneNumber { get; set; }
    
    /// <summary>
    /// Gets or sets the payer's personal or business name details.
    /// </summary>
    [JsonPropertyName("payer_name")]
    public NameInfo? PayerName { get; set; }
    
    /// <summary>
    /// Gets or sets the payer's country code (ISO-3166-1 alpha-2 or <c>C2</c>).
    /// </summary>
    [JsonPropertyName("country_code")]
    [StringLength(2)]
    [RegularExpression("^([A-Z]{2}|C2)$")]
    public string? CountryCode { get; set; }
    
    /// <summary>
    /// Gets or sets the payer's address details.
    /// </summary>
    [JsonPropertyName("address")]
    public Address? Address { get; set; }
}