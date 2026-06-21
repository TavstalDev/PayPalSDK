using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Common;

[DataContract]
public class Buyer
{
    [JsonPropertyName("name")]
    [StringLength(2000)]
    public string? Name { get; set; }
}