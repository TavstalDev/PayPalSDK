using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.Transactions;
using Tavstal.PayPalSDK.Utils;

namespace Tavstal.PayPalSDK.Models.TransactionSearch.Bodies;

/// <summary>
/// Represents the response body for a transaction list query from the PayPal Transaction Search API.
/// </summary>
public class TransactionListResponseBody
{
    /// <summary>
    /// Gets or sets the list of transaction detail records returned for the current page.
    /// </summary>
    [JsonPropertyName("transaction_details")]
    public List<TransactionDetail>? TransactionDetails { get; set; }
    
    /// <summary>
    /// Gets or sets the masked or formatted account number associated with the response context.
    /// </summary>
    [JsonPropertyName("account_number")]
    [StringLength(255)]
    public string? AccountNumber { get; set; }
    
    /// <summary>
    /// Gets or sets the current page number in the paginated result set.
    /// </summary>
    [JsonPropertyName("page")]
    public int Page { get; set; }
    
    /// <summary>
    /// Gets or sets the total number of available pages for the query.
    /// </summary>
    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }
    
    /// <summary>
    /// Gets or sets HATEOAS links related to this response (for example, self/next/prev).
    /// </summary>
    [JsonPropertyName("links")]
    public List<Link>? Links { get; set; }
    
    /// <summary>
    /// Gets or sets the start of the queried transaction date range in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("start_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? StartDate { get; set; }
    
    /// <summary>
    /// Gets or sets the end of the queried transaction date range in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("end_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? EndDate { get; set; }
    
    /// <summary>
    /// Gets or sets the timestamp indicating when this data set was last refreshed, in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("last_refreshed_date")]
    [StringLength(64, MinimumLength = 20)]
    [RegularExpression("^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T,t]([0-1][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)([.][0-9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$")]
    public string? LastRefreshedDate { get; set; }
    
    /// <summary>
    /// Gets the parsed <see cref="DateTime"/> value of <see cref="StartDate"/>,
    /// or <see langword="null"/> if the source value is missing or invalid.
    /// </summary>
    public DateTime? StartDateAsDateTime => DateTimeHelper.FromISO8601(StartDate);

    /// <summary>
    /// Gets the parsed <see cref="DateTime"/> value of <see cref="EndDate"/>,
    /// or <see langword="null"/> if the source value is missing or invalid.
    /// </summary>
    public DateTime? EndDateAsDateTime => DateTimeHelper.FromISO8601(EndDate);

    /// <summary>
    /// Gets the parsed <see cref="DateTime"/> value of <see cref="LastRefreshedDate"/>,
    /// or <see langword="null"/> if the source value is missing or invalid.
    /// </summary>
    public DateTime? LastRefreshedDateAsDateTime => DateTimeHelper.FromISO8601(LastRefreshedDate);
}