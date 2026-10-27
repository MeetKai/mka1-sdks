# Billing

## Overview

### Available Operations

* [GetOrganizationBilling](#getorganizationbilling) - Read organization billing. API keys require read:billing and either a human owner/admin or delegated service account. Keys are bound to their organization; cross-organization reads require a human cluster administrator with read:cluster.
* [SetOrganizationBillingEnabled](#setorganizationbillingenabled) - Enable or disable organization billing. Requires a human cluster administrator. API keys require both write:billing and the bootstrap-only write:cluster scope. Service-account keys cannot enable or disable billing.
* [UpdateOrganizationBillingProfile](#updateorganizationbillingprofile) - Update the bound organization's billing profile. API keys require write:billing and either a human owner/admin or delegated service account. The organization is resolved from the API key.
* [CreateOrganizationBillingSetup](#createorganizationbillingsetup) - Create a payment-provider setup session for the bound organization. API keys require write:billing and either a human owner/admin or delegated service account. The organization is resolved from the API key.
* [CreateOrganizationBillingPortal](#createorganizationbillingportal) - Create a payment-provider portal session for the bound organization. API keys require write:billing and either a human owner/admin or delegated service account. The organization is resolved from the API key.
* [ListOrganizationBillingInvoices](#listorganizationbillinginvoices) - List invoices for an organization. API keys require read:billing and either a human owner/admin or delegated service account. Cross-organization reads require a human cluster administrator with read:cluster.

## GetOrganizationBilling

Read organization billing. API keys require read:billing and either a human owner/admin or delegated service account. Keys are bound to their organization; cross-organization reads require a human cluster administrator with read:cluster.

### Example Usage

<!-- UsageSnippet language="go" operationID="getOrganizationBilling" method="get" path="/api/v1/budgeting/billing/org" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Billing.GetOrganizationBilling(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `orgID`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.GetOrganizationBillingResponse](../../models/operations/getorganizationbillingresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## SetOrganizationBillingEnabled

Enable or disable organization billing. Requires a human cluster administrator. API keys require both write:billing and the bootstrap-only write:cluster scope. Service-account keys cannot enable or disable billing.

### Example Usage

<!-- UsageSnippet language="go" operationID="setOrganizationBillingEnabled" method="put" path="/api/v1/budgeting/billing/org/enabled" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Billing.SetOrganizationBillingEnabled(ctx, "<id>", operations.SetOrganizationBillingEnabledRequestBody{
        Enabled: false,
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                  | Type                                                                                                                       | Required                                                                                                                   | Description                                                                                                                |
| -------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                                                      | :heavy_check_mark:                                                                                                         | The context to use for the request.                                                                                        |
| `orgID`                                                                                                                    | `string`                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `body`                                                                                                                     | [operations.SetOrganizationBillingEnabledRequestBody](../../models/operations/setorganizationbillingenabledrequestbody.md) | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `opts`                                                                                                                     | [][operations.Option](../../models/operations/option.md)                                                                   | :heavy_minus_sign:                                                                                                         | The options for this request.                                                                                              |

### Response

**[*operations.SetOrganizationBillingEnabledResponse](../../models/operations/setorganizationbillingenabledresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## UpdateOrganizationBillingProfile

Update the bound organization's billing profile. API keys require write:billing and either a human owner/admin or delegated service account. The organization is resolved from the API key.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateOrganizationBillingProfile" method="put" path="/api/v1/budgeting/billing/org/profile" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Billing.UpdateOrganizationBillingProfile(ctx, operations.UpdateOrganizationBillingProfileRequest{
        LegalName: "<value>",
        BillingEmail: "Leo44@hotmail.com",
        Address: operations.AddressRequest{
            Line1: "<value>",
            City: "Strongsville",
            PostalCode: "49423-7634",
            Country: "Togo",
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                | Type                                                                                                                     | Required                                                                                                                 | Description                                                                                                              |
| ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                                                    | :heavy_check_mark:                                                                                                       | The context to use for the request.                                                                                      |
| `request`                                                                                                                | [operations.UpdateOrganizationBillingProfileRequest](../../models/operations/updateorganizationbillingprofilerequest.md) | :heavy_check_mark:                                                                                                       | The request object to use for the request.                                                                               |
| `opts`                                                                                                                   | [][operations.Option](../../models/operations/option.md)                                                                 | :heavy_minus_sign:                                                                                                       | The options for this request.                                                                                            |

### Response

**[*operations.UpdateOrganizationBillingProfileResponse](../../models/operations/updateorganizationbillingprofileresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateOrganizationBillingSetup

Create a payment-provider setup session for the bound organization. API keys require write:billing and either a human owner/admin or delegated service account. The organization is resolved from the API key.

### Example Usage

<!-- UsageSnippet language="go" operationID="createOrganizationBillingSetup" method="post" path="/api/v1/budgeting/billing/org/setup-session" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Billing.CreateOrganizationBillingSetup(ctx, operations.CreateOrganizationBillingSetupRequest{})
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                            | Type                                                                                                                 | Required                                                                                                             | Description                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                                                | :heavy_check_mark:                                                                                                   | The context to use for the request.                                                                                  |
| `request`                                                                                                            | [operations.CreateOrganizationBillingSetupRequest](../../models/operations/createorganizationbillingsetuprequest.md) | :heavy_check_mark:                                                                                                   | The request object to use for the request.                                                                           |
| `opts`                                                                                                               | [][operations.Option](../../models/operations/option.md)                                                             | :heavy_minus_sign:                                                                                                   | The options for this request.                                                                                        |

### Response

**[*operations.CreateOrganizationBillingSetupResponse](../../models/operations/createorganizationbillingsetupresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateOrganizationBillingPortal

Create a payment-provider portal session for the bound organization. API keys require write:billing and either a human owner/admin or delegated service account. The organization is resolved from the API key.

### Example Usage

<!-- UsageSnippet language="go" operationID="createOrganizationBillingPortal" method="post" path="/api/v1/budgeting/billing/org/portal-session" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Billing.CreateOrganizationBillingPortal(ctx, operations.CreateOrganizationBillingPortalRequest{})
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                              | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                                  | :heavy_check_mark:                                                                                                     | The context to use for the request.                                                                                    |
| `request`                                                                                                              | [operations.CreateOrganizationBillingPortalRequest](../../models/operations/createorganizationbillingportalrequest.md) | :heavy_check_mark:                                                                                                     | The request object to use for the request.                                                                             |
| `opts`                                                                                                                 | [][operations.Option](../../models/operations/option.md)                                                               | :heavy_minus_sign:                                                                                                     | The options for this request.                                                                                          |

### Response

**[*operations.CreateOrganizationBillingPortalResponse](../../models/operations/createorganizationbillingportalresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListOrganizationBillingInvoices

List invoices for an organization. API keys require read:billing and either a human owner/admin or delegated service account. Cross-organization reads require a human cluster administrator with read:cluster.

### Example Usage

<!-- UsageSnippet language="go" operationID="listOrganizationBillingInvoices" method="get" path="/api/v1/budgeting/billing/org/invoices" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Billing.ListOrganizationBillingInvoices(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `orgID`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ListOrganizationBillingInvoicesResponse](../../models/operations/listorganizationbillinginvoicesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |