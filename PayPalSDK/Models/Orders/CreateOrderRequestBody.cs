using System.Runtime.Serialization;
using Newtonsoft.Json;
using Tavstal.PayPalSDK.Models.Common;
using Tavstal.PayPalSDK.Models.Common.Orders;
using Tavstal.PayPalSDK.Models.Common.Payments;

namespace Tavstal.PayPalSDK.Models.Orders;

[DataContract]
public class OrderCreateRequestBody
{
    [DataMember(Name = "purchase_units", EmitDefaultValue = false)]
    [JsonRequired]
    public required List<PurchaseUnit> PurchaseUnits { get; set; }

    [DataMember(Name = "intent", EmitDefaultValue = false)]
    [JsonRequired]
    public required string Intent { get; set; }

    [DataMember(Name = "payment_source", EmitDefaultValue = false)]
    public PaymentSource PaymentSource { get; set; }


    public OrderCreateRequestBody(List<PurchaseUnit> purchaseUnits, string intent, PaymentSource paymentSource)
    {
        PurchaseUnits = purchaseUnits;
        Intent = intent;
        PaymentSource = paymentSource;
    }
}