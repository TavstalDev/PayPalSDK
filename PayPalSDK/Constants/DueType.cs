namespace Tavstal.PayPalSDK.Constants;

/// <summary>
/// Provides constant values representing different types of due dates for invoices.
/// </summary>
public class DueType
{
    /// <summary>
    /// Payment is due upon receipt of the invoice.
    /// </summary>
    public const string DUE_ON_RECEIPT = "DUE_ON_RECEIPT";

    /// <summary>
    /// Payment is due on a date specified in the invoice.
    /// </summary>
    public const string DUE_ON_DATE_SPECIFIED = "DUE_ON_DATE_SPECIFIED";

    /// <summary>
    /// Payment is due 10 days after the invoice date.
    /// </summary>
    public const string NET_10 = "NET_10";

    /// <summary>
    /// Payment is due 15 days after the invoice date.
    /// </summary>
    public const string NET_15 = "NET_15";

    /// <summary>
    /// Payment is due 30 days after the invoice date.
    /// </summary>
    public const string NET_30 = "NET_30";

    /// <summary>
    /// Payment is due 45 days after the invoice date.
    /// </summary>
    public const string NET_45 = "NET_45";

    /// <summary>
    /// Payment is due 60 days after the invoice date.
    /// </summary>
    public const string NET_60 = "NET_60";

    /// <summary>
    /// Payment is due 90 days after the invoice date.
    /// </summary>
    public const string NET_90 = "NET_90";

    /// <summary>
    /// No due date is specified for the invoice.
    /// </summary>
    public const string NO_DUE_DATE = "NO_DUE_DATE";
}