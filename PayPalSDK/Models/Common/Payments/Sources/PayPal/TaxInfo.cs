using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Payments.Sources.PayPal;

/// <summary>
/// Represents tax information associated with a payment source in the PayPal SDK.
/// </summary>
[DataContract]
public class TaxInfo
{
    /// <summary>
    /// Gets or sets the tax identification number.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 14 characters.
    /// </remarks>
    [DataMember(Name = "tax_id")]
    [StringLength(14)]
    public required string TaxId { get; set; }

    /// <summary>
    /// Gets or sets the type of the tax identification number.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 14 characters.
    /// </remarks>
    [DataMember(Name = "tax_id_type")]
    [StringLength(14)]
    public required string TaxIdType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TaxInfo"/> class.
    /// </summary>
    /// <param name="taxId">The tax identification number.</param>
    /// <param name="taxIdType">The type of the tax identification number.</param>
    public TaxInfo(string taxId, string taxIdType)
    {
        TaxId = taxId;
        TaxIdType = taxIdType;
    }
}