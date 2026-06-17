using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using Tavstal.PayPalSDK.Models.Common.User;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

[DataContract]
public class TransactionPayerInfo
{
    [JsonPropertyName("account_id")]
    [StringLength(13)]
    public string?  AccountId { get; set; }
    
    [JsonPropertyName("address_status")]
    [StringLength(1)]
    public string?  AddressStatus { get; set; }
    
    [JsonPropertyName("payer_status")]
    [StringLength(1)]
    public string?  PayerStatus { get; set; }
    
    [JsonPropertyName("email_address")]
    [StringLength(254)]
    [RegularExpression("^.+@[^\"\\-].+$")]
    public string?  EmailAddress { get; set; }
    
    [JsonPropertyName("phone_number")]
    public PhoneNumber? PhoneNumber { get; set; }
    
    [JsonPropertyName("payer_name")]
    public NameInfo? PayerName { get; set; }
    
    [JsonPropertyName("country_code")]
    [StringLength(2)]
    [RegularExpression("^([A-Z]{2}|C2)$")]
    public string?  CountryCode { get; set; }
    
    [JsonPropertyName("address")]
    public Address? Address { get; set; }
}