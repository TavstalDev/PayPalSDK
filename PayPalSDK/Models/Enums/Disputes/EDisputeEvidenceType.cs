using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// Represents the types of evidence that can be provided in a dispute.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EDisputeEvidenceType>))]
public enum EDisputeEvidenceType
{
    /// <summary>Proof of fulfillment.</summary>
    PROOF_OF_FULFILLMENT = 0,
    /// <summary>Proof of refund.</summary>
    PROOF_OF_REFUND = 1,
    /// <summary>Proof of delivery signature.</summary>
    PROOF_OF_DELIVERY_SIGNATURE = 2,
    /// <summary>Proof of receipt copy.</summary>
    PROOF_OF_RECEIPT_COPY = 3,
    /// <summary>Return policy document.</summary>
    RETURN_POLICY = 4,
    /// <summary>Billing agreement.</summary>
    BILLING_AGREEMENT = 5,
    /// <summary>Proof of reshipment.</summary>
    PROOF_OF_RESHIPMENT = 6,
    /// <summary>Item description.</summary>
    ITEM_DESCRIPTION = 7,
    /// <summary>Police report.</summary>
    POLICE_REPORT = 8,
    /// <summary>Affidavit.</summary>
    AFFIDAVIT = 9,
    /// <summary>Paid with another method.</summary>
    PAID_WITH_OTHER_METHOD = 10,
    /// <summary>Copy of contract.</summary>
    COPY_OF_CONTRACT = 11,
    /// <summary>Terminal or ATM receipt.</summary>
    TERMINAL_ATM_RECEIPT = 12,
    /// <summary>Price difference reason.</summary>
    PRICE_DIFFERENCE_REASON = 13,
    /// <summary>Source conversion rate.</summary>
    SOURCE_CONVERSION_RATE = 14,
    /// <summary>Bank statement.</summary>
    BANK_STATEMENT = 15,
    /// <summary>Credit due reason.</summary>
    CREDIT_DUE_REASON = 16,
    /// <summary>Request credit receipt.</summary>
    REQUEST_CREDIT_RECEIPT = 17,
    /// <summary>Proof of return.</summary>
    PROOF_OF_RETURN = 18,
    /// <summary>Create evidence.</summary>
    CREATE = 19,
    /// <summary>Change reason.</summary>
    CHANGE_REASON = 20,
    /// <summary>Proof of refund outside PayPal.</summary>
    PROOF_OF_REFUND_OUTSIDE_PAYPAL = 21,
    /// <summary>Receipt of merchandise.</summary>
    RECEIPT_OF_MERCHANDISE = 22,
    /// <summary>Customs document.</summary>
    CUSTOMS_DOCUMENT = 23,
    /// <summary>Customs fee receipt.</summary>
    CUSTOMS_FEE_RECEIPT = 24,
    /// <summary>Information on resolution.</summary>
    INFORMATION_ON_RESOLUTION = 25,
    /// <summary>Additional information of item.</summary>
    ADDITIONAL_INFORMATION_OF_ITEM = 26,
    /// <summary>Details of purchase.</summary>
    DETAILS_OF_PURCHASE = 27,
    /// <summary>Proof of significant difference.</summary>
    PROOF_OF_SIGNIFICANT_DIFFERENCE = 28,
    /// <summary>Proof of software or service not as described.</summary>
    PROOF_OF_SOFTWARE_OR_SERVICE_NOT_AS_DESCRIBED = 29,
    /// <summary>Proof of confiscation.</summary>
    PROOF_OF_CONFISCATION = 30,
    /// <summary>Proof of damage.</summary>
    PROOF_OF_DAMAGE = 31,
    /// <summary>Copy of law enforcement agency report.</summary>
    COPY_OF_LAW_ENFORCEMENT_AGENCY_REPORT = 32,
    /// <summary>Additional proof of shipment.</summary>
    ADDITIONAL_PROOF_OF_SHIPMENT = 33,
    /// <summary>Proof of denial by carrier.</summary>
    PROOF_OF_DENIAL_BY_CARRIER = 34,
    /// <summary>Third party proof for damage or significant difference.</summary>
    THIRDPARTY_PROOF_FOR_DAMAGE_OR_SIGNIFICANT_DIFFERENCE = 35,
    /// <summary>Valid supporting document.</summary>
    VALID_SUPPORTING_DOCUMENT = 36,
    /// <summary>Legible supporting document.</summary>
    LEGIBLE_SUPPORTING_DOCUMENT = 37,
    /// <summary>Return tracking information.</summary>
    RETURN_TRACKING_INFORMATION = 38,
    /// <summary>Delivery receipt.</summary>
    DELIVERY_RECEIPT = 39,
    /// <summary>Proof of in-store receipt.</summary>
    PROOF_OF_INSTORE_RECEIPT = 40,
    /// <summary>Additional tracking information.</summary>
    ADDITIONAL_TRACKING_INFORMATION = 41,
    /// <summary>Proof of shipment postage.</summary>
    PROOF_OF_SHIPMENT_POSTAGE = 42,
    /// <summary>Online tracking information.</summary>
    ONLINE_TRACKING_INFORMATION = 43,
    /// <summary>Proof of in-store refund.</summary>
    PROOF_OF_INSTORE_REFUND = 44,
    /// <summary>Proof for software or service delivered.</summary>
    PROOF_FOR_SOFTWARE_OR_SERVICE_DELIVERED = 45,
    /// <summary>Return address for shipping.</summary>
    RETURN_ADDRESS_FOR_SHIPPING = 46,
    /// <summary>Copy of the eParcel manifest.</summary>
    COPY_OF_THE_EPARCEL_MANIFEST = 47,
    /// <summary>Copy of shipping manifest.</summary>
    COPY_OF_SHIPPING_MANIFEST = 48,
    /// <summary>Appeal affidavit.</summary>
    APPEAL_AFFIDAVIT = 49,
    /// <summary>Receipt of replacement.</summary>
    RECEIPT_OF_REPLACEMENT = 50,
    /// <summary>Copy of driver's license.</summary>
    COPY_OF_DRIVERS_LICENSE = 51,
    /// <summary>Account change information.</summary>
    ACCOUNT_CHANGE_INFORMATION = 52,
    /// <summary>Delivery address.</summary>
    DELIVERY_ADDRESS = 53,
    /// <summary>Confirmation of resolution.</summary>
    CONFIRMATION_OF_RESOLUTION = 54,
    /// <summary>Merchant response.</summary>
    MERCHANT_RESPONSE = 55,
    /// <summary>Permission description.</summary>
    PERMISSION_DESCRIPTION = 56,
    /// <summary>Status of merchandise.</summary>
    STATUS_OF_MERCHANDISE = 57,
    /// <summary>Lost card details.</summary>
    LOST_CARD_DETAILS = 58,
    /// <summary>Last valid transaction details.</summary>
    LAST_VALID_TRANSACTION_DETAILS = 59,
    /// <summary>Additional proof of return.</summary>
    ADDITIONAL_PROOF_OF_RETURN = 60,
    /// <summary>Declaration.</summary>
    DECLARATION = 61,
    /// <summary>Proof of missing items.</summary>
    PROOF_OF_MISSING_ITEMS = 62,
    /// <summary>Proof of empty package or different item.</summary>
    PROOF_OF_EMPTY_PACKAGE_OR_DIFFERENT_ITEM = 63,
    /// <summary>Proof of item not received.</summary>
    PROOF_OF_ITEM_NOT_RECEIVED = 64,
    /// <summary>Order details.</summary>
    ORDER_DETAILS = 65,
    /// <summary>Listing URL.</summary>
    LISTING_URL = 66,
    /// <summary>Shipping insurance.</summary>
    SHIPPING_INSURANCE = 67,
    /// <summary>Buyer response.</summary>
    BUYER_RESPONSE = 68,
    /// <summary>Photos of shipped item.</summary>
    PHOTOS_OF_SHIPPED_ITEM = 69,
    /// <summary>Other evidence.</summary>
    OTHER = 70,
    /// <summary>Cancellation details.</summary>
    CANCELLATION_DETAILS = 71,
    /// <summary>Merchant contact details.</summary>
    MERCHANT_CONTACT_DETAILS = 72,
    /// <summary>Item details.</summary>
    ITEM_DETAILS = 73,
    /// <summary>Correct recipient information.</summary>
    CORRECT_RECIPIENT_INFORMATION = 74,
    /// <summary>Explanation of funds not delivered.</summary>
    EXPLANATION_OF_FUNDS_NOT_DELIVERED = 75,
    /// <summary>Confirmation of recall.</summary>
    CONFIRMATION_OF_RECALL = 76,
    /// <summary>Communication with the sender.</summary>
    COMMUNICATION_WITH_THE_SENDER = 77,
    /// <summary>Payment reason.</summary>
    PAYMENT_REASON = 78,
    /// <summary>Proof of expected delivery date.</summary>
    PROOF_OF_EXPECTED_DELIVERY_DATE = 79,
    /// <summary>Delivery delay communication.</summary>
    DELIVERY_DELAY_COMMUNICATION = 80,
    /// <summary>Additional scam details.</summary>
    ADDITIONAL_SCAM_DETAILS = 81,
    /// <summary>Reason for late opening.</summary>
    REASON_FOR_LATE_OPENING = 82,
    /// <summary>Communication with the recipient.</summary>
    COMMUNICATION_WITH_THE_RECIPIENT = 83,
    /// <summary>Efforts to verify recipient.</summary>
    EFFORTS_TO_VERIFY_RECIPIENT = 84
}
