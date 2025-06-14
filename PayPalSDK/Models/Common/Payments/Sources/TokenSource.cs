using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources;

/// <summary>
/// Represents a token-based payment source in the PayPal SDK.
/// </summary>
[DataContract]
public class TokenSource
{
    /// <summary>
    /// Gets or sets the unique identifier for the token source.
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    [StringLength(255)]
    public required string Id { get; set; }

    /// <summary>
    /// Gets or sets the type of the token source.
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    [StringLength(255)]
    public required string Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TokenSource"/> class.
    /// </summary>
    /// <param name="id">The unique identifier for the token source.</param>
    /// <param name="type">The type of the token source.</param>
    public TokenSource(string id, string type)
    {
        Id = id;
        Type = type;
    }
}