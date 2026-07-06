using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;
using Tavstal.PayPalSDK.Models.Enums;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents a Universal Product Code (UPC) with a type and code.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class UPC
{
    /// <summary>
    /// Gets or sets the type of the UPC.
    /// </summary>
    /// <remarks>
    /// This field is required.
    /// </remarks>
    [FluentMember(0)]
    [JsonPropertyName("type")]
    [Required]
    public EUpcType Type { get; set; }
    
    /// <summary>
    /// Gets or sets the code of the UPC.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 17 characters.
    /// </remarks>
    [FluentMember(1)]
    [Required]
    [JsonPropertyName("code")]
    [StringLength(17)]
    public string? Code { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}