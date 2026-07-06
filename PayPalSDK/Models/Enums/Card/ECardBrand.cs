using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Card;

/// <summary>
/// The brand of a payment card.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ECardBrand>))]
public enum ECardBrand
{
    /// <summary>
    /// Visa card brand.
    /// </summary>
    VISA = 0,
    /// <summary>
    /// Mastercard card brand.
    /// </summary>
    MASTERCARD = 1,
    /// <summary>
    /// Discover card brand.
    /// </summary>
    DISCOVER = 2,
    /// <summary>
    /// American Express card brand.
    /// </summary>
    AMEX = 3,
    /// <summary>
    /// Solo card brand.
    /// </summary>
    SOLO = 4,
    /// <summary>
    /// JCB card brand.
    /// </summary>
    JCB = 5,
    /// <summary>
    /// STAR card brand.
    /// </summary>
    STAR = 6,
    /// <summary>
    /// Delta card brand.
    /// </summary>
    DELTA = 7,
    /// <summary>
    /// Switch card brand.
    /// </summary>
    SWITCH = 8,
    /// <summary>
    /// Maestro card brand.
    /// </summary>
    MAESTRO = 9,
    /// <summary>
    /// Carte Bleue Nationale card brand.
    /// </summary>
    CB_NATIONALE = 10,
    /// <summary>
    /// Configoga card brand.
    /// </summary>
    CONFIGOGA = 11,
    /// <summary>
    /// Confidis card brand.
    /// </summary>
    CONFIDIS = 12,
    /// <summary>
    /// Electron card brand.
    /// </summary>
    ELECTRON = 13,
    /// <summary>
    /// Cetelem card brand.
    /// </summary>
    CETELEM = 14,
    /// <summary>
    /// China Union Pay card brand.
    /// </summary>
    CHINA_UNION_PAY = 15,
    /// <summary>
    /// Diners Club card brand.
    /// </summary>
    DINERS = 16,
    /// <summary>
    /// Elo card brand.
    /// </summary>
    ELO = 17,
    /// <summary>
    /// Hiper card brand.
    /// </summary>
    HIPER = 18,
    /// <summary>
    /// Hipercard card brand.
    /// </summary>
    HIPERCARD = 19,
    /// <summary>
    /// RuPay card brand.
    /// </summary>
    RUPAY = 20,
    /// <summary>
    /// GE card brand.
    /// </summary>
    GE = 21,
    /// <summary>
    /// Synchrony card brand.
    /// </summary>
    SYNCHRONY = 22,
    /// <summary>
    /// EFTPOS card brand.
    /// </summary>
    EFTPOS = 23,
    /// <summary>
    /// Carte Bancaire card brand.
    /// </summary>
    CARTE_BANCAIRE = 24,
    /// <summary>
    /// STAR Access card brand.
    /// </summary>
    STAR_ACCESS = 25,
    /// <summary>
    /// Pulse card brand.
    /// </summary>
    PULSE = 26,
    /// <summary>
    /// NYCE card brand.
    /// </summary>
    NYCE = 27,
    /// <summary>
    /// Accel card brand.
    /// </summary>
    ACCEL = 28,
    /// <summary>
    /// Unknown card type.
    /// </summary>
    UNKNOWN = 29
}
