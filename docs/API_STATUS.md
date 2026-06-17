# PayPal API Implementation Status

This document tracks the completeness of this SDK against the official PayPal REST API endpoints.

## Status Definitions
* 🟢 **Supported**: Fully implemented, tested, and ready for production use.
* 🟡 **Planned**: On the roadmap for a future release.
* 🔴 **Not Supported**: No current plans to implement (Pull Requests are welcome).
* ⚪ **Obsolete**: Not implemented and will not be built because the endpoint is no longer relevant.

---

## Core & Authentication
| Feature / Endpoint | PayPal API Reference | Status | Notes |
| :--- | :--- | :---: | :--- |
| Generate Access Token | `/v1/oauth2/token` | 🟢 Supported | Handled automatically by client initialization |

---

## Orders   
| Feature / Endpoint    | PayPal API Reference                              | Status | Notes |
|:----------------------|:--------------------------------------------------| :---: | :--- |
| Create Order          | `/v2/checkout/orders`                             | 🟢 Supported |
| Show Order Details    | `/v2/checkout/orders/{id}`                        | 🟢 Supported | |
| Update Order          | `/v2/checkout/orders/{id}`                        | 🟢 Supported |
| Confirm the Order     | `/v2/checkout/orders/{id}/confirm-payment-source` | 🟢 Supported |
| Authorize Payment     | `/v2/checkout/orders/{id}/authorize`              | 🟢 Supported | |
| Capture Payment       | `/v2/checkout/orders/{id}/capture`                | 🟢 Supported | |
| Add Tracking          | `/v2/checkout/orders/{id}/track`                  | 🟢 Supported |
| Update Tracking       | `/v2/checkout/orders/{id}/trackers/{tracker_id}`  | 🟢 Supported |
| Receive Updated Order | `/v2/checkout/orders/order-update-callback`       | 🟢 Supported |

---

## Payments
| Feature / Endpoint             | PayPal API Reference                                         | Status | Notes |
|:-------------------------------|:-------------------------------------------------------------| :---: | :--- |
| Show Authorized Details        | `/v2/payments/authorizations/{authorization_id}`             | 🟢 Supported | |
| Capture Authorized Payment     | `/v2/payments/authorizations/{authorization_id}/capture`     | 🟢 Supported | |
| Reauthorize Authorized Payment | `/v2/payments/authorizations/{authorization_id}/reauthorize` | 🟢 Supported | |
| Void Authorized Payment        | `/v2/payments/authorizations/{authorization_id}/void`        | 🟢 Supported | |
| Show Captured Details          | `/v2/payments/captures/{capture_id}`                         | 🟢 Supported | |
| Refund Captured Payment        | `/v2/payments/captures/{capture_id}/refund`                  | 🟢 Supported | |
| Find Eligible Methods          | `/v2/payments/find-eligible-methods`                         | 🟢 Supported | |
| Show Refund Details            | `/v2/payments/refunds/{id}`                                  | 🟢 Supported | |

---

## Payment Method Tokens
| Feature / Endpoint     | PayPal API Reference            | Status | Notes |
|:-----------------------|:--------------------------------| :---: | :--- |
| Create Payment Token   | `/v3/vault/payment-tokens`      | 🟢 Supported | |
| List All Tokens        | `/v3/vault/payment-tokens`      | 🟢 Supported | |
| Retrieve Payment Token | `/v3/vault/payment-tokens/{id}` | 🟢 Supported | |
| Delete Payment Token   | `/v3/vault/payment-tokens/{id}` | 🟢 Supported | |
| Create Setup Token     | `/v3/vault/setup-tokens`        | 🟢 Supported | |
| Retrieve Setup Token   | `/v3/vault/setup-tokens/{id}`   | 🟢 Supported | |

---

## Shipment Tracking
| Feature / Endpoint        | PayPal API Reference          |    Status    | Notes |
|:--------------------------|:------------------------------|:------------:| :--- |
| Add Batch Tracking        | `/v1/shipping/trackers-batch` |  ⚪ Obsolete  | |
| Add Tracking              | `/v1/shipping/trackers`       | 🟢 Supported | |
| List Tracking Information | `/v1/shipping/trackers`       | 🟢 Supported | |
| Update/Cancel Tracking    | `/v1/shipping/trackers/{id}`  | 🟢 Supported | |
| Show Tracking Information | `/v1/shipping/trackers/{id}`  | 🟢 Supported | |

---

## Catalog Products
| Feature / Endpoint   | PayPal API Reference                 |    Status    | Notes |
|:---------------------|:-------------------------------------|:------------:| :--- |
| Create Product       | `/v1/catalogs/products`              |  🟢 Supported  | |
| List Products        | `/v1/catalogs/products`              |  🟢 Supported  | |
| Show Product Details | `/v1/catalogs/products/{product_id}` |  🟢 Supported  | |
| Update Product       | `/v1/catalogs/products/{product_id}` |  🟢 Supported  | |

---

## Currency Exchange
| Feature / Endpoint          | PayPal API Reference          |    Status    | Notes |
|:----------------------------|:------------------------------|:------------:| :--- |
| Create Exchange Rate Quote  | `/v2/pricing/quote-exchange-rates` |  🟢 Supported  | |

---

## Disputes
| Feature / Endpoint                         | PayPal API Reference                                 |    Status    | Notes          |
|:-------------------------------------------|:-----------------------------------------------------|:------------:|:---------------|
| Send Message About Dispute To Other Party  | `/v1/customer/disputes/{id}/send-message`            |  🟡 Planned  |                |
| Settle Dispute                             | `/v1/customer/disputes/{id}/adjudicate`              |  🟡 Planned  | Sandbox only.  |
| Make Offer To Resolve Dispute              | `/v1/customer/disputes/{id}/make-offer`              |  🟡 Planned  |                |
| Update dispute status                      | `/v1/customer/disputes/{id}/require-evidence`        |  🟡 Planned  | Sandbox only.  |
| Accept Claim                               | `/v1/customer/disputes/{id}/accept-claim`            |  🟡 Planned  |                |
| Provide Evidence                           | `/v1/customer/disputes/{id}/provide-evidence`        |  🟡 Planned  |                |
| Acknowledge Returned Item                  | `/v1/customer/disputes/{id}/acknowledge-return-item` |  🟡 Planned  |                |
| Show Dispute Details                       | `/v1/customer/disputes/{id}`                         |  🟡 Planned  |                |
| Partially Update Dispute                   | `/v1/customer/disputes/{id}`                         |  🟡 Planned  |                |
| List Disputes                              | `/v1/customer/disputes`                              |  🟡 Planned  |                |
| Appeal Dispute                             | `/v1/customer/disputes/{id}/appeal`                  |  🟡 Planned  |                |
| Deny Offer To Resolve Dispute              | `/v1/customer/disputes/{id}/deny-offer`              |  🟡 Planned  |                |
| Escalate Dispute To Claim                  | `/v1/customer/disputes/{id}/escalate`                |  🟡 Planned  |                |
| Provide Supporting Information For Dispute | `/v1/customer/disputes/{id}/provide-supporting-info` |  🟡 Planned  |                |
| Accept Offer To Resolve Dispute            | `/v1/customer/disputes/{id}/accept-offer`            |  🟡 Planned  |                |

---

## Identity
| Feature / Endpoint        | PayPal API Reference                  |      Status      | Notes |
|:--------------------------|:--------------------------------------|:----------------:| :--- |
| Show User Profile Details | `/v1/identity/openidconnect/userinfo` | 🔴 Not Supported | |
| Create User               | `/v2/scim/Users`                      | 🔴 Not Supported | |
| List Users                | `/v2/scim/Users`                      | 🔴 Not Supported | |
| Update User               | `/v2/scim/Users/{id}`                 | 🔴 Not Supported | |
| Show User Details         | `/v2/scim/Users/{id}`                 | 🔴 Not Supported | |
| Delete User               | `/v2/scim/Users/{id}`                 | 🔴 Not Supported | |

---

## Invoices
| Feature / Endpoint                | PayPal API Reference                                            |    Status    | Notes |
|:----------------------------------|:----------------------------------------------------------------|:------------:| :--- |
| Create Draft Invoice              | `/v2/invoicing/invoices`                                        |  🟢 Supported  | |
| List Invoices                     | `/v2/invoicing/invoices`                                        |  🟢 Supported  | |
| Send Invoice                      | `/v2/invoicing/invoices/{invoice_id}/send`                      |  🟢 Supported  | |
| Show Invoice Details              | `/v2/invoicing/invoices/{invoice_id}`                           |  🟢 Supported  | |
| Fully Update Invoice              | `/v2/invoicing/invoices/{invoice_id}`                           |  🟢 Supported  | |
| Delete Invoice                    | `/v2/invoicing/invoices/{invoice_id}`                           |  🟢 Supported  | |
| Search For Invoices               | `/v2/invoicing/search-invoices`                                 |  🟢 Supported  | |
| Cancel Sent Invoice               | `/v2/invoicing/invoices/{invoice_id}/cancel`                    |  🟢 Supported  | |
| Send Invoice Reminder             | `/v2/invoicing/invoices/{invoice_id}/remind`                    |  🟢 Supported  | |
| Record Payment For Invoice        | `/v2/invoicing/invoices/{invoice_id}/payments`                  |  🟢 Supported  | |
| Delete External Payment           | `/v2/invoicing/invoices/{invoice_id}/payments/{transaction_id}` |  🟢 Supported  | |
| Record Refund For Invoice         | `/v2/invoicing/invoices/{invoice_id}/refunds`                   |  🟢 Supported  | |
| Delete External Refund            | `/v2/invoicing/invoices/{invoice_id}/refunds/{transaction_id}`  |  🟢 Supported  | |
| Generate Invoice Number           | `/v2/invoicing/generate-next-invoice-number`                    |  🟢 Supported  | |
| Generate QR Code                  | `/v2/invoicing/invoices/{invoice_id}/generate-qr-code`          |  🟢 Supported  | |
| List Templates                    | `/v2/invoicing/templates`                                       |  🔴 Not Supported  | |
| Create Template                   | `/v2/invoicing/templates`                                       |  🔴 Not Supported  | |
| Show Template Details             | `/v2/invoicing/templates/{template_id}`                         |  🔴 Not Supported  | |
| Fully Update Template             | `/v2/invoicing/templates/{template_id}`                         |  🔴 Not Supported  | |
| Delete Template                   | `/v2/invoicing/templates/{template_id}`                         |  🔴 Not Supported  | |
| Setup Auto Reminder               | `/v2/invoicing/setup-reminders`                                 |  🔴 Not Supported  | |
| Retrieve an Invoice Auto Reminder | `/v2/invoicing/reminders/{id}`                                  |  🔴 Not Supported  | |
| Update Invoice Auto Reminder      | `/v2/invoicing/reminders/{id}`                                  |  🔴 Not Supported  | |
| Get All Invoice Auto Reminder     | `/v2/invoicing/reminders`                                       |  🔴 Not Supported  | |
| Suspend Invoice Auto Reminder     | `/v2/invoicing/reminders/{id}/suspend`                          |  🔴 Not Supported  | |
| Resume Invoice Auto Reminder      | `/v2/invoicing/reminders/{id}/resume`                           |  🔴 Not Supported  | |
| Cancel Auto Reminders             | `/v2/invoicing/invoices/{id}/cancel-reminders`                  |  🔴 Not Supported  | |

---

## Partner Referrals
| Feature / Endpoint      | PayPal API Reference                                   |    Status    | Notes |
|:------------------------|:-------------------------------------------------------|:------------:| :--- |
| Create Partner Referral | `/v2/customer/partner-referrals`                       |  🔴 Not Supported  | |
| Show Referral Data      | `/v2/customer/partner-referrals/{partner_referral_id}` |  🔴 Not Supported  | |

---

## Payment Experience Web Profiles
| Feature / Endpoint                      | PayPal API Reference                       |      Status       | Notes |
|:----------------------------------------|:-------------------------------------------|:-----------------:| :--- |
| Create Web Experience Profile           | `/v1/payment-experience/web-profiles`      | 🔴 Not Supported  | |
| List Web Experience Profiles            | `/v1/payment-experience/web-profiles`      | 🔴 Not Supported  | |
| Update Web Experience Profile           | `/v1/payment-experience/web-profiles/{id}` | 🔴 Not Supported  | |
| Partially Update Web Experience Profile | `/v1/payment-experience/web-profiles/{id}` | 🔴 Not Supported  | |
| Show Web Experience Profile Details     | `/v1/payment-experience/web-profiles/{id}` | 🔴 Not Supported  | |
| Delete Web Experience Profile           | `/v1/payment-experience/web-profiles/{id}` | 🔴 Not Supported  | |

---

## Payouts
| Feature / Endpoint           | PayPal API Reference                                |    Status    | Notes |
|:-----------------------------|:----------------------------------------------------|:------------:| :--- |
| Create Batch Payout          | `/v1/payments/payouts`                              |  🔴 Not Supported  | |
| Show Payout Batch Details    | `/v1/payments/payouts/{id}`                         |  🔴 Not Supported  | |
| Show Payout Item Details     | `/v1/payments/payouts-item/{payout_item_id}`        |  🔴 Not Supported  | |
| Cancel Unclaimed Payout Item | `/v1/payments/payouts-item/{payout_item_id}/cancel` |  🔴 Not Supported  | |

---

## Referenced Payouts
| Feature / Endpoint                    | PayPal API Reference                                      |    Status    | Notes |
|:--------------------------------------|:----------------------------------------------------------|:------------:| :--- |
| Create Referenced Batch Payout        | `/v1/payments/referenced-payouts`                         |  🔴 Not Supported  | |
| List Items in Referenced Batch Payout | `/v1/payments/referenced-payouts/{payouts_batch_id}`      |  🔴 Not Supported  | |
| Create Referenced Payout Item         | `/v1/payments/referenced-payouts-items`                   |  🔴 Not Supported  | |
| Show Referenced Payout Item Details   | `/v1/payments/referenced-payouts-items/{payouts_item_id}` |  🔴 Not Supported  | |

---

## Subscriptions
| Feature / Endpoint         | PayPal API Reference                            |    Status    | Notes |
|:---------------------------|:------------------------------------------------|:------------:| :--- |
| Create Plan                | `/v1/billing/plans`                             |  🟢 Supported  | |
| List Plans                 | `/v1/billing/plans`                             |  🟢 Supported  | |
| Show Plan Details          | `/v1/billing/plans/{id}`                        |  🟢 Supported  | |
| Update Plan                | `/v1/billing/plans/{id}`                        |  🟢 Supported  | |
| Activate Plan              | `/v1/billing/plans/{id}/activate`               |  🟢 Supported  | |
| Deactivate Plan            | `/v1/billing/plans/{id}/deactivate`             |  🟢 Supported  | |
| Update Pricing             | `/v1/billing/plans/{id}/update-pricing-schemes` |  🟢 Supported  | |
| Create Subscription        | `/v1/billing/subscriptions`                     |  🟢 Supported  | |
| List Subscriptions         | `/v1/billing/subscriptions`                     |  🟢 Supported  | |
| Show Subscription Details  | `/v1/billing/subscriptions/{id}`                |  🟢 Supported  | |
| Update Subscription        | `/v1/billing/subscriptions/{id}`                |  🟢 Supported  | |
| Revise Plan                | `/v1/billing/subscriptions/{id}/revise`         |  🟢 Supported  | |
| Suspend Subscription       | `/v1/billing/subscriptions/{id}/suspend`        |  🟢 Supported  | |
| Cancel Subscription        | `/v1/billing/subscriptions/{id}/cancel`         |  🟢 Supported  | |
| Activate Subscription      | `/v1/billing/subscriptions/{id}/activate`       |  🟢 Supported  | |
| Capture Authorized Payment | `/v1/billing/subscriptions/{id}/capture`        |  🟢 Supported  | |
| List Transactions          | `/v1/billing/subscriptions/{id}/transactions`   |  🟢 Supported  | |

---

## Transaction Search
| Feature / Endpoint              | PayPal API Reference                    |    Status    | Notes |
|:--------------------------------|:----------------------------------------|:------------:| :--- |
| List Transactions               | `/v1/reporting/transactions`            |  🟡 Planned  | |
| List All Balances               | `/v1/reporting/balances`                |  🟡 Planned  | |
| List All Balance & Net Activity | `/v1/reporting/get-balance-net-summary` |  🔴 Not Supported  | |
| List All Daily Summary          | `/v1/reporting/get-daily-summary`       |  🔴 Not Supported  | |

---

## Webhooks Management
| Feature / Endpoint              | PayPal API Reference                                    |    Status    | Notes |
|:--------------------------------|:--------------------------------------------------------|:------------:| :--- |
| Create Webhook                  | `/v1/notifications/webhooks`                            |  🟢 Supported  | |
| List Webhooks                   | `/v1/notifications/webhooks`                            |  🟢 Supported  | |
| Show Webhook Details            | `/v1/notifications/webhooks/{webhook_id}`               |  🟢 Supported  | |
| Update Webhook                  | `/v1/notifications/webhooks/{webhook_id}`               |  🟢 Supported  | |
| Delete Webhook                  | `/v1/notifications/webhooks/{webhook_id}`               |  🟢 Supported  | |
| List Event Subscriptions        | `/v1/notifications/webhooks/{webhook_id}/event-types`   |  🔴 Not Supported  | |
| Create Webhook Lookup           | `/v1/notifications/webhooks-lookup`                     |  🔴 Not Supported  | |
| List Webhook Lookups            | `/v1/notifications/webhooks-lookup`                     |  🔴 Not Supported  | |
| Show Webhook Lookup Details     | `/v1/notifications/webhooks-lookup/{webhook_lookup_id}` |  🔴 Not Supported  | |
| Delete Webhook Lookup           | `/v1/notifications/webhooks-lookup/{webhook_lookup_id}` |  🔴 Not Supported  | |
| Verify Webhook Signature        | `/v1/notifications/verify-webhook-signature`            |  🟢 Supported  | |
| List Available Events           | `/v1/notifications/webhooks-event-types`                |  🔴 Not Supported  | |
| List Event Notifications        | `/v1/notifications/webhooks-events`                     |  🔴 Not Supported  | |
| Show Event Notification Details | `/v1/notifications/webhooks-events/{event_id}`          |  🔴 Not Supported  | |
| Resend Event Notification       | `/v1/notifications/webhooks-events/{event_id}/resend`   |  🔴 Not Supported  | |
| Simulate Webhook Event          | `/v1/notifications/simulate-event`                      |  🔴 Not Supported  | |

---

## Payment Links and Buttons
| Feature / Endpoint        | PayPal API Reference                  |    Status    | Notes |
|:--------------------------|:--------------------------------------|:------------:| :--- |
| Creates Payment Resource  | `/v1/checkout/payment-resources`      |  🟡 Planned  | |
| List Payment Resources    | `/v1/checkout/payment-resources`      |  🟡 Planned  | |
| Retrieve Payment Resource | `/v1/checkout/payment-resources/{id}` |  🟡 Planned  | |
| Replace Payment Resource  | `/v1/checkout/payment-resources/{id}` |  🟡 Planned  | |
| Delete payment resource   | `/v1/checkout/payment-resources/{id}` |  🟡 Planned  | |