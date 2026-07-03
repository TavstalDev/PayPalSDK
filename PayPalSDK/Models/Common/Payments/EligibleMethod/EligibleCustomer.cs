using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common.Addressing;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.EligibleMethod;

/// <summary>
/// Represents a customer who may be eligible for a payment method.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class EligibleCustomer
{
    /// <summary>
    /// Gets or sets the ISO 3166-1 alpha-2 country code for the customer.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("country_code")]
    [StringLength(2)]
    public string? CountryCode { get; set; }
    
    /// <summary>
    /// Gets or sets the client channel information associated with the customer.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("channel")]
    public EligibleChannel? Channel { get; set; }
    
    /// <summary>
    /// Gets or sets the customer identifier.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("id")]
    [StringLength(36)]
    public string? Id { get; set; }
    
    /// <summary>
    /// Gets or sets the customer's phone number.
    /// </summary>
    [FluentMember(3)]
    [FluentSkippable]
    public PhoneNumber? Phone { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(4, "Build")]
    public void Build() { }
}