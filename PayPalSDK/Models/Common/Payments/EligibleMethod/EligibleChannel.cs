using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.EligibleMethod;

/// <summary>
/// Represents the client/channel information used when determining eligible payment methods.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class EligibleChannel
{
    /// <summary>
    /// Gets or sets the browser type reported by the client.
    /// </summary>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("browser_type")]
    [StringLength(30)]
    public string? BrowserType { get; set; }
    
    /// <summary>
    /// Gets or sets the client operating system reported by the client.
    /// </summary>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("client_os")]
    [StringLength(30)]
    public string? ClientOs { get; set; }
    
    /// <summary>
    /// Gets or sets the device type reported by the client.
    /// </summary>
    [FluentMember(2)]
    [FluentSkippable]
    [JsonPropertyName("device_type")]
    [StringLength(30)]
    public string? DeviceType { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(3, "Build")]
    public void Build() { }
}