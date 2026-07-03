using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents the processor response details for a payment transaction.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class ProcessorResponse
{
    /// <summary>
    /// The Address Verification System (AVS) code returned by the processor.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("avs_code")]
    public string? AvsCode { get; set; }

    /// <summary>
    /// The Card Verification Value (CVV) code returned by the processor.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("cvv_code")]
    public string? CvvCode { get; set; }

    /// <summary>
    /// The response code returned by the processor.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("response_code")]
    public string? ResponseCode { get; set; }

    /// <summary>
    /// The payment advice code returned by the processor.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    [JsonPropertyName("payment_advice_code")]
    public string? PaymentAdviceCode { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}