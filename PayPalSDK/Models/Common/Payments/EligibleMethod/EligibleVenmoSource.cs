using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.EligibleMethod;

/// <summary>
/// Represents a Venmo payment source with user identification information.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class EligibleVenmoSource
{
    /// <summary>
    /// Gets or sets the Venmo username associated with the payment source.
    /// </summary>
    /// <remarks>
    /// The username must not exceed 50 characters in length.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("user_name")]
    [StringLength(50)]
    public string? UserName { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(1, "Build")]
    public void Build() { }
}