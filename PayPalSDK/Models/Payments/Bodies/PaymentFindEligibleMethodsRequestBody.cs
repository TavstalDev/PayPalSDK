using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Orders;
using Tavstal.PayPalSDK.Models.Common.Payments.EligibleMethod;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Payments.Bodies;

/// <summary>
/// Represents the request body used to find eligible payment methods for a customer.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class PaymentFindEligibleMethodsRequestBody
{
    /// <summary>
    /// Gets or sets the customer information used to evaluate eligible payment methods.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("customer")]
    public EligibleCustomer? Customer { get; set; }
    
    /// <summary>
    /// Gets or sets the purchase units associated with the eligibility request.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("purchase_units")]
    public List<PurchaseUnit>? PurchaseUnits { get; set; }
    
    /// <summary>
    /// Gets or sets optional eligibility preferences used to influence the result.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("preferences")]
    public EligiblePreference? Preferences { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}