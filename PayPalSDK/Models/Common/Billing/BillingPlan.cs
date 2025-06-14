using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Billing;

/// <summary>
/// Represents a billing plan in the PayPal SDK.
/// </summary>
[DataContract]
public class BillingPlan
{
    /// <summary>
    /// Gets or sets the billing cycles associated with the billing plan.
    /// </summary>
    /// <remarks>
    /// This field is required and contains a list of billing cycles.
    /// </remarks>
    [DataMember(Name = "billing_cycles", EmitDefaultValue = false)]
    public required List<BillingCycle> BillingCycles { get; set; }

    /// <summary>
    /// Gets or sets the name of the billing plan.
    /// </summary>
    /// <remarks>
    /// This field is optional and has a maximum length of 127 characters.
    /// </remarks>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [StringLength(127)]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the setup fee for the billing plan.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the monetary value of the setup fee.
    /// </remarks>
    [DataMember(Name = "setup_fee", EmitDefaultValue = false)]
    public Money SetupFee { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BillingPlan"/> class.
    /// </summary>
    /// <param name="billingCycles">The billing cycles associated with the billing plan.</param>
    /// <param name="name">The name of the billing plan.</param>
    /// <param name="setupFee">The setup fee for the billing plan.</param>
    public BillingPlan(List<BillingCycle> billingCycles, string name, Money setupFee)
    {
        BillingCycles = billingCycles;
        Name = name;
        SetupFee = setupFee;
    }
}