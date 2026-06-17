using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

[DataContract]
public class CheckoutOption
{
    [JsonPropertyName("checkout_option_name")]
    [StringLength(200)]
    public string? CheckoutOptionName { get; set; }
    
    [JsonPropertyName("checkout_option_value")]
    [StringLength(200)]
    public string? CheckoutOptionValue { get; set; }
}