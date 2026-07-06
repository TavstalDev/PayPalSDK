using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums;

/// <summary>
/// The type of tax identifier.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ETaxIdType>))]
public enum ETaxIdType
{
    /// <summary>Brazilian CPF tax identifier.</summary>
    BR_CPF = 0,
    /// <summary>Brazilian CNPJ tax identifier.</summary>
    BR_CNPJ = 1
}
