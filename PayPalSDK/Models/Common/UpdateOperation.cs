using System.Runtime.Serialization;

namespace Tavstal.PayPalSDK.Models.Common;

/// <summary>
/// Represents an update operation for modifying resources in the PayPal SDK.
/// </summary>
[DataContract]
public class UpdateOperation
{
    /// <summary>
    /// Gets or sets the type of operation to be performed.
    /// </summary>
    /// <remarks>
    /// Examples include "add", "remove", "replace", etc.
    /// </remarks>
    [DataMember(Name = "op", EmitDefaultValue = false)]
    public required string Op { get; set; }

    /// <summary>
    /// Gets or sets the JSON Pointer path to the target field.
    /// </summary>
    /// <remarks>
    /// Specifies the location in the resource where the operation is applied.
    /// </remarks>
    [DataMember(Name = "path", EmitDefaultValue = false)]
    public string Path { get; set; }

    /// <summary>
    /// Gets or sets the value to be used in the operation.
    /// </summary>
    /// <remarks>
    /// This field is optional and depends on the type of operation being performed.
    /// </remarks>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public object Value { get; set; }

    /// <summary>
    /// Gets or sets the source path for a "move" operation.
    /// </summary>
    /// <remarks>
    /// This field is optional and is used only for "move" operations to specify the source location.
    /// </remarks>
    [DataMember(Name = "from", EmitDefaultValue = false)]
    public string From { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateOperation"/> class.
    /// </summary>
    /// <param name="op">The type of operation to be performed.</param>
    /// <param name="path">The JSON Pointer path to the target field.</param>
    /// <param name="value">The value to be used in the operation.</param>
    /// <param name="from">The source path for a "move" operation.</param>
    public UpdateOperation(string op, string path, object value, string from)
    {
        Op = op;
        Path = path;
        Value = value;
        From = from;
    }
}