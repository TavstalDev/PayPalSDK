using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

[DataContract]
public class IncentiveDetail
{
    [JsonPropertyName("incentive_type")]
    [StringLength(500)]
    public string? IncentiveType { get; set; }
    
    [JsonPropertyName("incentive_code")]
    [StringLength(200)]
    public string? IncentiveCode { get; set; }
    
    [JsonPropertyName("incentive_program_code")]
    [StringLength(100)]
    public string? IncentiveProgramCode { get; set; }
    
    [JsonPropertyName("incentive_amount")]
    public Money? IncentiveAmount { get; set; }
}