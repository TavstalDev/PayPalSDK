using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.GooglePay;

/// <summary>
/// Represents assurance details for a Google Pay payment source within the PayPal SDK.
/// </summary>
[DataContract]
public class AssuranceDetails
{
    /// <summary>
    /// Gets or sets a value indicating whether the account is verified.
    /// </summary>
    /// <remarks>
    /// This field is optional and indicates if the account associated with the payment source has been verified.
    /// </remarks>
    [DataMember(Name = "account_verified", EmitDefaultValue = false)]
    public bool AccountVerified { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the cardholder is authenticated.
    /// </summary>
    /// <remarks>
    /// This field is optional and indicates if the cardholder has been authenticated during the transaction.
    /// </remarks>
    [DataMember(Name = "card_holder_authenticated", EmitDefaultValue = false)]
    public bool CardHolderAuthenticated { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AssuranceDetails"/> class.
    /// </summary>
    /// <param name="accountVerified">Indicates whether the account is verified.</param>
    /// <param name="cardHolderAuthenticated">Indicates whether the cardholder is authenticated.</param>
    public AssuranceDetails(bool accountVerified, bool cardHolderAuthenticated)
    {
        AccountVerified = accountVerified;
        CardHolderAuthenticated = cardHolderAuthenticated;
    }
}