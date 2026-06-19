# Examples

This page is an index of practical, task-focused examples for `PayPalSDK`.

> Start with [Client Setup](examples/common/client-setup.md) first, then open the API area you need.

---

## Table of Contents

- [Common](#common)
- [Checkout and Orders](#checkout-and-orders)
- [Payments](#payments)
- [Recurring Billing](#recurring-billing)
- [Invoicing](#invoicing)
- [Webhooks](#webhooks)
- [Vault and Tokens](#vault-and-tokens)
- [Other API Areas](#other-api-areas)

---

## Common

| Document | Description |
|---|---|
| [Client Setup](examples/common/client-setup.md) | Configure credentials and create a reusable `PayPalHttpClient` |
| [Error Handling](examples/common/error-handling.md) | Standard `IsSuccessStatusCode` + API error parsing pattern |

## Checkout and Orders

| Document | Description |
|---|---|
| [Orders](examples/orders.md) | Create, inspect, authorize, and capture checkout orders |
| [Order Tracking](examples/tracking.md) | Add and update shipment trackers |

## Payments

| Document | Description |
|---|---|
| [Payments](examples/payments.md) | Capture authorizations, refund captures, and read payment details |

## Recurring Billing

| Document | Description |
|---|---|
| [Subscriptions](examples/subscriptions.md) | Create plans/subscriptions and manage lifecycle actions |

## Invoicing

| Document | Description |
|---|---|
| [Invoices](examples/invoices.md) | Create, send, search, and manage invoice payments/refunds |

## Webhooks

| Document | Description |
|---|---|
| [Webhooks](examples/webhooks.md) | Create/list/update webhooks and verify webhook signatures |

## Vault and Tokens

| Document | Description |
|---|---|
| [Payment Method Tokens](examples/payment-method-tokens.md) | Create, retrieve, list, and delete vault tokens |

## Other API Areas

| Document | Description |
|---|---|
| [Product Catalog](examples/product-catalog.md) | Create/list/show/update catalog products |
| [Currency Exchange](examples/currency-exchange.md) | Quote exchange rates |
| [Disputes](examples/disputes.md) | Dispute messaging and resolution actions |
| [Transaction Search](examples/transaction-search.md) | Reporting endpoints for balances and transactions |

---

## How to Use These Examples

1. Start with [Client Setup](examples/common/client-setup.md).
2. Pick one API area and run only that flow.
3. Keep sandbox and live credentials separate.
4. Confirm endpoint availability in [API Status](API_STATUS.md).

---

## Notes

- Examples focus on endpoints currently marked supported in [API Status](API_STATUS.md).
- If a linked page does not exist yet, treat it as planned documentation work.
