using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.Common;

/// <summary>
/// Represents a OneClick payment source within the PayPal SDK.
/// </summary>
[DataContract]
public class OneClick
{
    /// <summary>
    /// Gets or sets the authorization code for the payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 6 characters.
    /// </remarks>
    [DataMember(Name = "auth_code", EmitDefaultValue = false)]
    [StringLength(6)]
    public string AuthCode { get; set; }

    /// <summary>
    /// Gets or sets the consumer reference associated with the payment source.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 64 characters.
    /// </remarks>
    [DataMember(Name = "consumer_reference", EmitDefaultValue = false)]
    [StringLength(64)]
    public required string ConsumerReference { get; set; }

    /// <summary>
    /// Gets or sets the alias label for the payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 35 characters.
    /// </remarks>
    [DataMember(Name = "alias_label", EmitDefaultValue = false)]
    [StringLength(35)]
    public string AliasLabel { get; set; }

    /// <summary>
    /// Gets or sets the alias key for the payment source.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 19 characters.
    /// </remarks>
    [DataMember(Name = "alias_key", EmitDefaultValue = false)]
    [StringLength(19)]
    public string AliasKey { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OneClick"/> class.
    /// </summary>
    /// <param name="authCode">The authorization code for the payment source.</param>
    /// <param name="consumerReference">The consumer reference associated with the payment source.</param>
    /// <param name="aliasLabel">The alias label for the payment source.</param>
    /// <param name="aliasKey">The alias key for the payment source.</param>
    public OneClick(string authCode, string consumerReference, string aliasLabel, string aliasKey)
    {
        AuthCode = authCode;
        ConsumerReference = consumerReference;
        AliasLabel = aliasLabel;
        AliasKey = aliasKey;
    }
}