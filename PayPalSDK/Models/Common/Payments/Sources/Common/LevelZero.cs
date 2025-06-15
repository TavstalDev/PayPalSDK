using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.Common;

/// <summary>
/// Represents a Level Zero payment source within the PayPal SDK.
/// </summary>
[DataContract]
public class LevelZero
{
    /// <summary>
    /// Gets or sets the authorization code for the payment source.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 6 characters.
    /// </remarks>
    [DataMember(Name = "auth_code", EmitDefaultValue = false)]
    [StringLength(6)]
    public required string AuthCode { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LevelZero"/> class.
    /// </summary>
    /// <param name="authCode">The authorization code for the payment source.</param>
    public LevelZero(string authCode)
    {
        AuthCode = authCode;
    }
}