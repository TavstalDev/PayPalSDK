using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.User;

/// <summary>
/// Represents the platform fee details in a PayPal transaction.
/// </summary>
[DataContract]
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class PlatformFee
{
    /// <summary>
    /// The monetary amount of the platform fee.
    /// </summary>
    [JsonPropertyName("amount")]
    public Money? Amount { get; set; }

    /// <summary>
    /// Information about the payee receiving the platform fee.
    /// </summary>
    [JsonPropertyName("payee")]
    public Payee? Payee { get; set; }
}