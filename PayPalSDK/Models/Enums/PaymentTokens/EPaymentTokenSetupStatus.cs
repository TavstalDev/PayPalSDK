using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.PaymentTokens;

/// <summary>
/// The setup status of a payment token.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EPaymentTokenSetupStatus>))]
public enum EPaymentTokenSetupStatus
{
    /// <summary>
    /// The resource has been created.
    /// </summary>
    CREATED = 0,
    /// <summary>
    /// Payer action is required to proceed.
    /// </summary>
    PAYER_ACTION_REQUIRED = 1,
    /// <summary>
    /// The resource has been approved.
    /// </summary>
    APPROVED = 2,
    /// <summary>
    /// The payment method has been vaulted.
    /// </summary>
    VAULTED = 3,
    /// <summary>
    /// The resource has been tokenized.
    /// </summary>
    TOKENIZED = 4
}
