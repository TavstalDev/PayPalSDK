using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.User;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

/// <summary>
/// Represents payer-related information for a transaction, including account,
/// contact, identity, country, and address details.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class TransactionPayerInfo
{
    /// <summary>
    /// Gets or sets the payer's PayPal account identifier.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("account_id")]
    [StringLength(13)]
    public string? AccountId { get; set; }
    
    /// <summary>
    /// Gets or sets the payer address verification status code.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("address_status")]
    [StringLength(1)]
    public string? AddressStatus { get; set; }
    
    /// <summary>
    /// Gets or sets the payer account status code.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("payer_status")]
    [StringLength(1)]
    public string? PayerStatus { get; set; }
    
    /// <summary>
    /// Gets or sets the payer's email address.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("email_address")]
    [StringLength(254)]
    [RegularExpression("^.+@[^\"\\-].+$")]
    public string? EmailAddress { get; set; }
    
    /// <summary>
    /// Gets or sets the payer's phone number information.
    /// </summary>
    [FluentMember(4)]
    [FluentSkippable]
    [JsonPropertyName("phone_number")]
    public PhoneNumber? PhoneNumber { get; set; }
    
    /// <summary>
    /// Gets or sets the payer's personal or business name details.
    /// </summary>
    [FluentMember(5)]
    [FluentSkippable]
    [JsonPropertyName("payer_name")]
    public NameInfo? PayerName { get; set; }
    
    /// <summary>
    /// Gets or sets the payer's country code (ISO-3166-1 alpha-2 or <c>C2</c>).
    /// </summary>
    [FluentMember(6)]
    [FluentSkippable]
    [JsonPropertyName("country_code")]
    [StringLength(2)]
    [RegularExpression("^([A-Z]{2}|C2)$")]
    public string? CountryCode { get; set; }
    
    /// <summary>
    /// Gets or sets the payer's address details.
    /// </summary>
    [FluentMember(7)]
    [FluentSkippable]
    [JsonPropertyName("address")]
    public Address? Address { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(8, "Build")]
    public void Build() { }
}