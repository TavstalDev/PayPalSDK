using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// The source channel of a dispute.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeSource>))]
public enum EDisputeSource
{
    /// <summary>
    /// Cancellation or contact via email.
    /// </summary>
    EMAIL = 0,
    /// <summary>
    /// Dispute created via web.
    /// </summary>
    WEB = 1,
    /// <summary>
    /// Dispute created via chat.
    /// </summary>
    CHAT = 2,
    /// <summary>
    /// Dispute created via IVR.
    /// </summary>
    IVR = 3,
    /// <summary>
    /// Cancellation or contact via phone.
    /// </summary>
    PHONE = 4,
    /// <summary>
    /// Dispute created via mobile app.
    /// </summary>
    MOBILE_APP = 5,
    /// <summary>
    /// Dispute created via mobile web.
    /// </summary>
    MOBILE_WEB = 6,
    /// <summary>
    /// Dispute created via API.
    /// </summary>
    API = 7
}
