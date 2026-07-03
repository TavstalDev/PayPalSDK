using System.Text.Json.Serialization;
using M31.FluentApi.Attributes;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.GooglePay;

/// <summary>
/// Represents assurance details for a Google Pay payment source within the PayPal SDK.
/// </summary>
[FluentApi(builderClassName: "{Name}Builder")]
public class AssuranceDetails
{
    /// <summary>
    /// Gets or sets a value indicating whether the account is verified.
    /// </summary>
    /// <remarks>
    /// This field is optional and indicates if the account associated with the payment source has been verified.
    /// </remarks>
    [FluentMember(0)]
    [FluentSkippable]
    [JsonPropertyName("account_verified")]
    public bool AccountVerified { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the cardholder is authenticated.
    /// </summary>
    /// <remarks>
    /// This field is optional and indicates if the cardholder has been authenticated during the transaction.
    /// </remarks>
    [FluentMember(1)]
    [FluentSkippable]
    [JsonPropertyName("card_holder_authenticated")]
    public bool CardHolderAuthenticated { get; set; }

    /// <summary>
    /// Fluent build method implementation
    /// </summary>
    [FluentMethod(2, "Build")]
    public void Build() { }
}