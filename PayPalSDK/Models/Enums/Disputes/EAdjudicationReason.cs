using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Disputes;

/// <summary>
/// Represents the possible reasons for an adjudication outcome.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EAdjudicationReason>))]
public enum EAdjudicationReason
{
    /// <summary>Expected amount difference due to fees.</summary>
    AMOUNT_DIFFERENCE_EXPECTED_DUE_TO_FEES = 0,
    /// <summary>Billing agreement change was disclosed.</summary>
    BILLING_AGREEMENT_CHANGE_DISCLOSED = 1,
    /// <summary>Billing agreement change was not disclosed.</summary>
    BILLING_AGREEMENT_CHANGE_NOT_DISCLOSED = 2,
    /// <summary>Billing agreement date change was disclosed.</summary>
    BILLING_AGREEMENT_DATE_CHANGE_DISCLOSED = 3,
    /// <summary>Billing agreement date change was not disclosed.</summary>
    BILLING_AGREEMENT_DATE_CHANGE_NOT_DISCLOSED = 4,
    /// <summary>Buyer attempted to return the item.</summary>
    BUYER_ATTEMPTED_RETURN = 5,
    /// <summary>Buyer was billed only once.</summary>
    BUYER_BILLED_ONLY_ONCE = 6,
    /// <summary>Buyer canceled the case.</summary>
    BUYER_CANCELLED_CASE = 7,
    /// <summary>Buyer canceled the service.</summary>
    BUYER_CANCELLED_SERVICE = 8,
    /// <summary>Buyer failed to describe the issue.</summary>
    BUYER_FAILED_TO_DESCRIBE_ISSUE = 9,
    /// <summary>Buyer has possession of the merchandise or service.</summary>
    BUYER_HAS_POSSESSION_OF_THE_MERCHANDISE_OR_SERVICE = 10,
    /// <summary>Buyer made no attempt to resolve with seller.</summary>
    BUYER_MADE_NO_ATTEMPT_TO_RESOLVE_WITH_SELLER = 11,
    /// <summary>Buyer is not in possession of item to return.</summary>
    BUYER_NOT_IN_POSSESSION_OF_ITEM_TO_RETURN = 12,
    /// <summary>Buyer provided a credit receipt.</summary>
    BUYER_PROVIDED_CREDIT_RECEIPT = 13,
    /// <summary>Buyer received a duplicate refund.</summary>
    BUYER_RECEIVED_DUPLICATE_REFUND = 14,
    /// <summary>Cancelled per terms of billing agreement.</summary>
    CANCELLED_PER_TERMS_OF_BILLING_AGREEMENT = 15,
    /// <summary>Card was not stolen.</summary>
    CARD_NOT_STOLEN = 16,
    /// <summary>Card was not stolen before authorization.</summary>
    CARD_NOT_STOLEN_BEFORE_AUTH = 17,
    /// <summary>Customer recognizes the transaction.</summary>
    CUSTOMER_RECOGNIZES_TRANSACTION = 18,
    /// <summary>Decision based on available information.</summary>
    DECISION_BASED_ON_AVAILABLE_INFORMATION = 19,
    /// <summary>Delivery after expected delivery date.</summary>
    DELIVERY_AFTER_EXPECTED_DELIVERY_DATE = 20,
    /// <summary>Delivery due within expected delivery date.</summary>
    DELIVERY_DUE_WITHIN_EXPECTED_DELIVERY_DATE = 21,
    /// <summary>Delivery or service was refused.</summary>
    DELIVERY_OR_SERVICE_REFUSED = 22,
    /// <summary>Documentation matches the amount charged.</summary>
    DOCUMENTATION_MATCHES_AMOUNT_CHARGED = 23,
    /// <summary>Documentation matches the amount in PayPal account.</summary>
    DOCUMENTATION_MATCHES_AMOUNT_IN_PAYPAL_ACCOUNT = 24,
    /// <summary>Duplicate add funds.</summary>
    DUPLICATE_ADD_FUNDS = 25,
    /// <summary>Effortless seller protection applies.</summary>
    EFFORTLESS_SELLER_PROTECTION = 26,
    /// <summary>In-person delivery was made.</summary>
    IN_PERSON_DELIVERY = 27,
    /// <summary>Ineligible for buyer protection policy.</summary>
    INELIGIBLE_BUYER_PROTECTION_POLICY = 28,
    /// <summary>Ineligible for seller protection policy.</summary>
    INELIGIBLE_SELLER_PROTECTION_POLICY = 29,
    /// <summary>Inquiry offer for item replaced.</summary>
    INQUIRY_OFFER_ITEM_REPLACED = 30,
    /// <summary>Inquiry offer for partial refund.</summary>
    INQUIRY_OFFER_PARTIAL_REFUND = 31,
    /// <summary>Inquiry offer for refund with item return.</summary>
    INQUIRY_OFFER_REFUND_WITH_ITEM_RETURN = 32,
    /// <summary>Inquiry offer for refund with replacement.</summary>
    INQUIRY_OFFER_REFUND_WITH_REPLACEMENT = 33,
    /// <summary>Invalid appeal reason.</summary>
    INVALID_APPEAL_REASON = 34,
    /// <summary>Invalid chargeback ruled in seller favor.</summary>
    INVALID_CHARGEBACK_SELLER_FAVOUR = 35,
    /// <summary>Invalid delivery proof.</summary>
    INVALID_DELIVERY_PROOF = 36,
    /// <summary>Invalid delivery proof signature.</summary>
    INVALID_DELIVERY_PROOF_SIGNATURE = 37,
    /// <summary>Invalid documentation.</summary>
    INVALID_DOCUMENTATION = 38,
    /// <summary>Invalid proof of shipment.</summary>
    INVALID_PROOF_OF_SHIPMENT = 39,
    /// <summary>Invalid refund proof.</summary>
    INVALID_REFUND_PROOF = 40,
    /// <summary>Invalid return delivery with no signature proof.</summary>
    INVALID_RETURN_DELIVERY_NO_SIGNATURE_PROOF = 41,
    /// <summary>Invalid return delivery proof.</summary>
    INVALID_RETURN_DELIVERY_PROOF = 42,
    /// <summary>Invalid tracking information.</summary>
    INVALID_TRACKING = 43,
    /// <summary>Item was altered or repaired.</summary>
    ITEM_ALTERED_REPAIRED = 44,
    /// <summary>Item not as advertised.</summary>
    ITEM_NOT_AS_ADVERTISED = 45,
    /// <summary>Item not as described.</summary>
    ITEM_NOT_AS_DESCRIBED = 46,
    /// <summary>Item was not damaged.</summary>
    ITEM_NOT_DAMAGED = 47,
    /// <summary>Item was not delivered.</summary>
    ITEM_NOT_DELIVERED = 48,
    /// <summary>Item was not returned to seller.</summary>
    ITEM_NOT_RETURNED_TO_SELLER = 49,
    /// <summary>Item was not shipped.</summary>
    ITEM_NOT_SHIPPED = 50,
    /// <summary>Item of different quality or quantity.</summary>
    ITEM_OF_DIFFERENT_QUALITY_OR_QUANTITY = 51,
    /// <summary>Item out of stock and not delivered.</summary>
    ITEM_OUT_OF_STOCK_AND_NOT_DELIVERED = 52,
    /// <summary>Item returned to seller.</summary>
    ITEM_RETURNED_TO_SELLER = 53,
    /// <summary>Item or service was misrepresented.</summary>
    ITEM_SERVICE_MISREPRESENTED = 54,
    /// <summary>Item or service was not misrepresented.</summary>
    ITEM_SERVICE_NOT_MISREPRESENTED = 55,
    /// <summary>Item or service received by buyer.</summary>
    ITEM_SERVICE_RECEIVED_BY_BUYER = 56,
    /// <summary>Item sold as described.</summary>
    ITEM_SOLD_AS_DESCRIBED = 57,
    /// <summary>Item value was unaffected.</summary>
    ITEM_VALUE_UNAFFECTED = 58,
    /// <summary>Multiple appeals with the same reason.</summary>
    MULTIPLE_APPEALS_WITH_SAME_REASON = 59,
    /// <summary>No documentation from buyer.</summary>
    NO_DOCUMENTATION_FROM_BUYER = 60,
    /// <summary>No documentation supporting due of credit.</summary>
    NO_DOCUMENTATION_SUPPORTING_DUE_OF_CREDIT = 61,
    /// <summary>No proof of delivery.</summary>
    NO_PROOF_OF_DELIVERY = 62,
    /// <summary>No proof of delivery for intangible items.</summary>
    NO_PROOF_OF_DELIVERY_INTANGIBLE = 63,
    /// <summary>No protection for digital goods or services.</summary>
    NO_PROTECTION_FOR_DIGITAL_GOODS_SERVICE = 64,
    /// <summary>No response from buyer.</summary>
    NO_RESPONSE_FROM_BUYER = 65,
    /// <summary>No response from buyer for additional info request.</summary>
    NO_RESPONSE_FROM_BUYER_FOR_ADDITIONAL_INFO_REQUEST = 66,
    /// <summary>No response from seller.</summary>
    NO_SELLER_RESPONSE = 67,
    /// <summary>No seller response for additional info request.</summary>
    NO_SELLER_RESPONSE_FOR_ADDITIONAL_INFO_REQUEST = 68,
    /// <summary>No valid shipment proof.</summary>
    NO_VALID_SHIPMENT_PROOF = 69,
    /// <summary>Not a billing error.</summary>
    NOT_A_BILLING_ERROR = 70,
    /// <summary>Not an unauthorized transaction.</summary>
    NOT_AN_UNAUTHORIZED_TRANSACTION = 71,
    /// <summary>Not duplicate funds added once.</summary>
    NOT_DUPLICATE_FUNDS_ADDED_ONCE = 72,
    /// <summary>Not duplicate funds withdrawn once.</summary>
    NOT_DUPLICATE_FUNDS_WITHDRAWN_ONCE = 73,
    /// <summary>Not shipped to the correct address.</summary>
    NOT_SHIPPED_TO_CORRECT_ADDRESS = 74,
    /// <summary>Partial refund issued for missing items.</summary>
    PARTIAL_REFUND_ISSUED_FOR_MISSING_ITEMS = 75,
    /// <summary>Partial refund offer was accepted.</summary>
    PARTIAL_REFUND_OFFER_ACCEPTED = 76,
    /// <summary>Payment was already reversed.</summary>
    PAYMENT_REVERSED_ALREADY = 77,
    /// <summary>POS submitted instead of POD.</summary>
    POS_SUBMITTED_INSTEAD_OF_POD = 78,
    /// <summary>Preauth installment is due.</summary>
    PREAUTH_INSTALLMENT_DUE = 79,
    /// <summary>Proof of billing after cancellation accepted.</summary>
    PROOF_OF_BILLING_AFTER_CANCELLATION_ACCEPTED = 80,
    /// <summary>Proof of duplicate denied or insufficient.</summary>
    PROOF_OF_DUPLICATE_DENIED_OR_INSUFFICIENT = 81,
    /// <summary>Proof of incorrect transaction amount accepted.</summary>
    PROOF_OF_INCORRECT_TRANSACTION_AMOUNT_ACCEPTED = 82,
    /// <summary>Proof of paid by other means not submitted.</summary>
    PROOF_OF_PAID_BY_OTHER_MEANS_NOT_SUBMITTED = 83,
    /// <summary>Proof of tracking not submitted.</summary>
    PROOF_OF_TRACKING_NOT_SUBMITTED = 84,
    /// <summary>Protected by PayPal.</summary>
    PROTECTED_BY_PAYPAL = 85,
    /// <summary>Represented by PayPal.</summary>
    REPRESENTED_BY_PAYPAL = 86,
    /// <summary>Seller accepted multiple payments.</summary>
    SELLER_ACCEPTED_MULTIPLE_PAYMENTS = 87,
    /// <summary>Seller agreed to refund without return.</summary>
    SELLER_AGREED_REFUND_WITHOUT_RETURN = 88,
    /// <summary>Seller agreed to issue credit.</summary>
    SELLER_AGREED_TO_ISSUE_CREDIT = 89,
    /// <summary>Seller issued credit to buyer.</summary>
    SELLER_ISSUED_CREDIT_TO_BUYER = 90,
    /// <summary>Seller issued a refund.</summary>
    SELLER_ISSUED_REFUND = 91,
    /// <summary>Seller is not reachable.</summary>
    SELLER_NOT_REACHABLE = 92,
    /// <summary>Seller received payment twice or for replacement.</summary>
    SELLER_RECEIVED_PAYMENT_TWICE_OR_FOR_REPLACEMENT = 93,
    /// <summary>Seller refused a refund.</summary>
    SELLER_REFUSED_REFUND = 94,
    /// <summary>Seller refused a return.</summary>
    SELLER_REFUSED_RETURN = 95,
    /// <summary>Seller surcharged the buyer.</summary>
    SELLER_SURCHARGED_BUYER = 96,
    /// <summary>Service was not completed as agreed.</summary>
    SERVICE_NOT_COMPLETED_AS_AGREED = 97,
    /// <summary>Shipping company will not ship.</summary>
    SHIPPING_COMPANY_WONT_SHIP = 98,
    /// <summary>Tracking proof is not enough.</summary>
    TRACKING_PROOF_NOT_ENOUGH = 99,
    /// <summary>Transaction authorized by cardholder.</summary>
    TRANSACTION_AUTHORIZED_BY_CARDHOLDER = 100,
    /// <summary>Transaction canceled after authorization date.</summary>
    TRANSACTION_CANCELLED_AFTER_AUTHORIZATION_DATE = 101,
    /// <summary>Transaction canceled before shipment or service date.</summary>
    TRANSACTION_CANCELLED_BEFORE_SHIPMENT_SERVICE_DATE = 102,
    /// <summary>Transaction matches buyer spending pattern.</summary>
    TRANSACTION_MATCHES_BUYER_SPENDING_PATTERN = 103,
    /// <summary>Transaction was processed correctly.</summary>
    TRANSACTION_PROCESSED_CORRECTLY = 104,
    /// <summary>Trusted buyer payout.</summary>
    TRUSTED_BUYER_PAYOUT = 105,
    /// <summary>Unused shipping label.</summary>
    UNUSED_SHIPPING_LABEL = 106,
    /// <summary>Valid proof of delivery.</summary>
    VALID_PROOF_OF_DELIVERY = 107,
    /// <summary>Valid proof of delivery with signature.</summary>
    VALID_PROOF_OF_DELIVERY_WITH_SIGNATURE = 108,
    /// <summary>Valid proof of refund.</summary>
    VALID_PROOF_OF_REFUND = 109,
    /// <summary>Valid proof supporting the claim.</summary>
    VALID_PROOF_SUPPORTING_CLAIM = 110,
    /// <summary>Valid return delivery proof.</summary>
    VALID_RETURN_DELIVERY_PROOF = 111,
    /// <summary>Valid return delivery proof with signature.</summary>
    VALID_RETURN_DELIVERY_PROOF_WITH_SIGNATURE = 112,
    /// <summary>Valid shipment proof.</summary>
    VALID_SHIPMENT_PROOF = 113,
    /// <summary>Value affected significantly.</summary>
    VALUE_AFFECTED_SIGNIFICANTLY = 114,
    /// <summary>Protection policy applies.</summary>
    PROTECTION_POLICY_APPLIES = 115,
    /// <summary>Significantly not as described delayed filing.</summary>
    SNAD_DELAYED_FILING = 116,
    /// <summary>Funds transferred to incorrect recipient.</summary>
    FUNDS_TRANSFERRED_TO_INCORRECT_RECIPIENT = 117,
    //NO_SELLER_RESPONSE_FOR_ADDITIONAL_INFO_REQUEST = 118,
    /// <summary>In transit beyond timeframe with invalid proof of shipment or delivery.</summary>
    IN_TRANSIT_BEYOND_TIMEFRAME_INVALID_PROOF_OF_SHIPMENT_OR_DELIVERY = 119,
    //VALID_PROOF_SUPPORTING_CLAIM = 120,
    /// <summary>Invalid evidence.</summary>
    INVALID_EVIDENCE = 121,
    /// <summary>Invalid proof delivered to unspecified location.</summary>
    INVALID_PROOF_DELIVERED_TO_UNSPECIFIED_LOCATION = 122,
    /// <summary>Invalid proof delivered to incorrect address.</summary>
    INVALID_PROOF_DELIVERED_TO_INCORRECT_ADDRESS = 123,
    /// <summary>Invalid proof unable to track.</summary>
    INVALID_PROOF_UNABLE_TO_TRACK = 124,
    /// <summary>Shipping address not present in proof of shipment or delivery.</summary>
    SHIPPING_ADDRESS_NOT_PRESENT_IN_PROOF_OF_SHIPMENT_OR_DELIVERY = 125,
    /// <summary>Invalid proof item returned to sender.</summary>
    INVALID_PROOF_ITEM_RETURNED_TO_SENDER = 126,
    /// <summary>Delivered without required signature in proof of delivery.</summary>
    DELIVERED_WITHOUT_REQUIRED_SIGNATURE_IN_PROOF_OF_DELIVERY = 127,
    /// <summary>No shipment tracking provided in proof of delivery.</summary>
    NO_SHIPMENT_TRACKING_PROVIDED_IN_PROOF_OF_DELIVERY = 128,
    /// <summary>Other issue with proof of shipment or delivery.</summary>
    OTHER_ISSUE_WITH_PROOF_OF_SHIPMENT_OR_DELIVERY = 129,
    /// <summary>Insufficient evidence provided.</summary>
    INSUFFICIENT_EVIDENCE_PROVIDED = 130,
    /// <summary>Evidence cannot be linked to the transaction.</summary>
    EVIDENCE_CANNOT_BE_LINKED_TO_TRANSACTION = 131,
    /// <summary>Evidence does not show fulfillment or customer benefit.</summary>
    EVIDENCE_DOES_NOT_SHOW_FULFILLMENT_OR_CUSTOMER_BENEFIT = 132,
    /// <summary>Seller shipped or fulfilled beyond the allowed period.</summary>
    SELLER_SHIPPED_OR_FULFILLED_BEYOND_ALLOWED_PERIOD = 133,
    /// <summary>Item ineligible for seller protection.</summary>
    ITEM_INELIGIBLE_FOR_SELLER_PROTECTION = 134,
    /// <summary>Evidence does not show service completed.</summary>
    EVIDENCE_DOES_NOT_SHOW_SERVICE_COMPLETED = 135,
    /// <summary>Valid return shipment proof.</summary>
    VALID_RETURN_SHIPMENT_PROOF = 136,
    /// <summary>Item was an empty box.</summary>
    ITEM_EMPTY_BOX = 137,
    /// <summary>Item is unusable.</summary>
    ITEM_UNUSABLE = 138,
    /// <summary>Item missing quantity or quality.</summary>
    ITEM_MISSING_QUANTITY_OR_QUALITY = 139,
    /// <summary>Refund amount mismatch.</summary>
    REFUND_AMOUNT_MISMATCH = 140,
    /// <summary>Duplicate payment.</summary>
    DUPLICATE_PAYMENT = 141,
    /// <summary>Seller promised refund but not issued.</summary>
    SELLER_PROMISED_REFUND_NOT_ISSUED = 142,
    /// <summary>Customer charged incorrect amount.</summary>
    CUSTOMER_CHARGED_INCORRECT_AMOUNT = 143,
    /// <summary>Duplicate payment by other means.</summary>
    DUPLICATE_PAYMENT_BY_OTHER_MEANS = 144,
    /// <summary>Goodwill payout.</summary>
    GOODWILL_PAYOUT = 145
}
