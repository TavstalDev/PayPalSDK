using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Orders.Supplementary;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Orders;

/// <summary>
/// Represents risk-related information for a PayPal order.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class Risk
{
    /// <summary>
    /// Gets or sets the supplementary customer information associated with the risk assessment.
    /// </summary>
    /// <remarks>
    /// This property contains details about the customer, such as their IP address, 
    /// which may be used for evaluating potential risks.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("customer")]
    public SupplementaryCustomer? Customer { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}