using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common.Billing;

/// <summary>
/// Represents a billing cycle in the PayPal SDK.
/// </summary>
[DataContract]
public class BillingCycle
{
    /// <summary>
    /// Gets or sets the tenure type of the billing cycle.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the type of tenure for the billing cycle.
    /// </remarks>
    [DataMember(Name = "tenure_type", EmitDefaultValue = false)]
    public required string TenureType { get; set; }

    /// <summary>
    /// Gets or sets the total number of cycles in the billing cycle.
    /// </summary>
    /// <remarks>
    /// This field is optional and defaults to 1.
    /// </remarks>
    [DataMember(Name = "total_cycles")]
    public int TotalCycles { get; set; } = 1;

    /// <summary>
    /// Gets or sets the sequence number of the billing cycle.
    /// </summary>
    /// <remarks>
    /// This field is optional and defaults to 1.
    /// </remarks>
    [DataMember(Name = "sequence")]
    public int Sequence { get; set; } = 1;

    /// <summary>
    /// Gets or sets the pricing scheme associated with the billing cycle.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the pricing details for the billing cycle.
    /// </remarks>
    [DataMember(Name = "pricing_scheme", EmitDefaultValue = false)]
    public PricingScheme PricingScheme { get; set; }

    /// <summary>
    /// Gets or sets the start date of the billing cycle.
    /// </summary>
    /// <remarks>
    /// This field is optional and must follow the format YYYY-MM-DD.
    /// </remarks>
    [DataMember(Name = "start_date", EmitDefaultValue = false)]
    [StringLength(10)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$")]
    public string StartDate { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BillingCycle"/> class.
    /// </summary>
    /// <param name="tenureType">The tenure type of the billing cycle.</param>
    /// <param name="totalCycles">The total number of cycles in the billing cycle.</param>
    /// <param name="sequence">The sequence number of the billing cycle.</param>
    /// <param name="pricingScheme">The pricing scheme associated with the billing cycle.</param>
    /// <param name="startDate">The start date of the billing cycle.</param>
    public BillingCycle(string tenureType, int totalCycles, int sequence, PricingScheme pricingScheme, string startDate)
    {
        TenureType = tenureType;
        TotalCycles = totalCycles;
        Sequence = sequence;
        PricingScheme = pricingScheme;
        StartDate = startDate;
    }
}