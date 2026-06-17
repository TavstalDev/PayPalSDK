using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Transactions;

[DataContract]
public class TaxAmount
{
    [JsonPropertyName("tax_amount")]
    public Money? Amount { get; set; }
}