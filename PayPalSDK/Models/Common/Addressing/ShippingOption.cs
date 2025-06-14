using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Common.Addressing;

/// <summary>
/// Represents a shipping option with details such as ID, label, selection status, type, and amount.
/// </summary>
[DataContract]
public class ShippingOption
{
    /// <summary>
    /// Gets or sets the unique identifier for the shipping option.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 127 characters.
    /// </remarks>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    [StringLength(127)]
    public required string Id { get; set; }

    /// <summary>
    /// Gets or sets the label or name of the shipping option.
    /// </summary>
    /// <remarks>
    /// This field is required and has a maximum length of 127 characters.
    /// </remarks>
    [DataMember(Name = "label", EmitDefaultValue = false)]
    [StringLength(127)]
    public required string Label { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the shipping option is selected.
    /// </summary>
    /// <remarks>
    /// This field is required and represents the selection status of the shipping option.
    /// </remarks>
    [DataMember(Name = "selected", EmitDefaultValue = false)]
    public required bool Selected { get; set; }

    /// <summary>
    /// Gets or sets the type of shipping.
    /// </summary>
    /// <remarks>
    /// This property corresponds to one of the predefined shipping types in <see cref="Tavstal.PayPalSDK.Constants.ShippingType"/>.
    /// It is optional and will not be emitted if its value is null or default.
    /// </remarks>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets the amount associated with the shipping option.
    /// </summary>
    /// <remarks>
    /// This field is optional and represents the cost or value of the shipping option.
    /// </remarks>
    [DataMember(Name = "amount", EmitDefaultValue = false)]
    public Amount Amount { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ShippingOption"/> class.
    /// </summary>
    /// <param name="id">The unique identifier for the shipping option.</param>
    /// <param name="label">The label or name of the shipping option.</param>
    /// <param name="selected">The selection status of the shipping option.</param>
    /// <param name="type">The type of shipping.</param>
    /// <param name="amount">The amount associated with the shipping option.</param>
    public ShippingOption(string id, string label, bool selected, string type, Amount amount)
    {
        Id = id;
        Label = label;
        Selected = selected;
        Type = type;
        Amount = amount;
    }
}