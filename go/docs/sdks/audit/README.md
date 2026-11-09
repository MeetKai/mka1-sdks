# Audit

## Overview

### Available Operations

* [ExportCases](#exportcases) - Export audit cases
* [ExportCase](#exportcase) - Export one audit case
* [VerifyCaseLedger](#verifycaseledger) - Verify a case's ledger
* [ExportRequests](#exportrequests) - Export gateway requests
* [ExportFindings](#exportfindings) - Export misuse findings
* [ExportFinding](#exportfinding) - Export one misuse finding

## ExportCases

The organization's audit cases: one row per model response.

### Example Usage

<!-- UsageSnippet language="go" operationID="exportAuditCases" method="get" path="/api/v1/audit/cases/export" -->
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

    res, err := s.Audit.ExportCases(ctx, operations.ExportAuditCasesRequest{})
    if err != nil {
        log.Fatal(err)
    }
    if res.AuditCaseExportRows != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |
| `request`                                                                                | [operations.ExportAuditCasesRequest](../../models/operations/exportauditcasesrequest.md) | :heavy_check_mark:                                                                       | The request object to use for the request.                                               |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |

### Response

**[*operations.ExportAuditCasesResponse](../../models/operations/exportauditcasesresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.AuditAPIError | 400, 401, 403           | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## ExportCase

One case. json and html return the case with its timeline and artifacts; csv and ndjson return its ledger entries.

### Example Usage

<!-- UsageSnippet language="go" operationID="exportAuditCase" method="get" path="/api/v1/audit/cases/{response_id}/export" -->
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

    res, err := s.Audit.ExportCase(ctx, "<id>", operations.ExportAuditCaseFormatJSON.ToPointer(), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.TwoHundredApplicationJSONObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `ctx`                                                                                 | [context.Context](https://pkg.go.dev/context#Context)                                 | :heavy_check_mark:                                                                    | The context to use for the request.                                                   |
| `responseID`                                                                          | `string`                                                                              | :heavy_check_mark:                                                                    | The response id of the case.                                                          |
| `format`                                                                              | [*operations.ExportAuditCaseFormat](../../models/operations/exportauditcaseformat.md) | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `xOnBehalfOf`                                                                         | `*string`                                                                             | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |
| `opts`                                                                                | [][operations.Option](../../models/operations/option.md)                              | :heavy_minus_sign:                                                                    | The options for this request.                                                         |

### Response

**[*operations.ExportAuditCaseResponse](../../models/operations/exportauditcaseresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.AuditAPIError | 401, 403, 404           | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## VerifyCaseLedger

Recomputes the hash chain of every ledger chain the case's entries belong to. A changed, missing or reordered entry makes the chain invalid. Chains are checked from the last entry retention deleted, if any.

### Example Usage

<!-- UsageSnippet language="go" operationID="verifyAuditCaseLedger" method="get" path="/api/v1/audit/cases/{response_id}/ledger/verify" -->
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

    res, err := s.Audit.VerifyCaseLedger(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.LedgerVerification != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `responseID`                                                        | `string`                                                            | :heavy_check_mark:                                                  | The response id of the case.                                        |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.VerifyAuditCaseLedgerResponse](../../models/operations/verifyauditcaseledgerresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.AuditAPIError | 401, 403, 404           | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## ExportRequests

The organization's API requests as the gateway logged them: one row per request.

### Example Usage

<!-- UsageSnippet language="go" operationID="exportGatewayRequests" method="get" path="/api/v1/audit/requests/export" -->
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

    res, err := s.Audit.ExportRequests(ctx, operations.ExportGatewayRequestsRequest{})
    if err != nil {
        log.Fatal(err)
    }
    if res.GatewayRequestExportRows != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                              | :heavy_check_mark:                                                                                 | The context to use for the request.                                                                |
| `request`                                                                                          | [operations.ExportGatewayRequestsRequest](../../models/operations/exportgatewayrequestsrequest.md) | :heavy_check_mark:                                                                                 | The request object to use for the request.                                                         |
| `opts`                                                                                             | [][operations.Option](../../models/operations/option.md)                                           | :heavy_minus_sign:                                                                                 | The options for this request.                                                                      |

### Response

**[*operations.ExportGatewayRequestsResponse](../../models/operations/exportgatewayrequestsresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.AuditAPIError | 400, 401, 403           | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## ExportFindings

The organization's misuse findings, newest first.

### Example Usage

<!-- UsageSnippet language="go" operationID="exportMisuseFindings" method="get" path="/api/v1/audit/misuse/findings/export" -->
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

    res, err := s.Audit.ExportFindings(ctx, operations.ExportMisuseFindingsFormatJSON.ToPointer(), nil, nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.MisuseFindingExportRows != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `ctx`                                                                                           | [context.Context](https://pkg.go.dev/context#Context)                                           | :heavy_check_mark:                                                                              | The context to use for the request.                                                             |
| `format`                                                                                        | [*operations.ExportMisuseFindingsFormat](../../models/operations/exportmisusefindingsformat.md) | :heavy_minus_sign:                                                                              | json returns a JSON array of rows; csv returns a header row and one line per row.               |
| `dateFrom`                                                                                      | [*time.Time](https://pkg.go.dev/time#Time)                                                      | :heavy_minus_sign:                                                                              | Only records at or after this time.                                                             |
| `dateTo`                                                                                        | [*time.Time](https://pkg.go.dev/time#Time)                                                      | :heavy_minus_sign:                                                                              | Only records at or before this time.                                                            |
| `xOnBehalfOf`                                                                                   | `*string`                                                                                       | :heavy_minus_sign:                                                                              | Optional external end-user identifier forwarded by the API gateway.                             |
| `opts`                                                                                          | [][operations.Option](../../models/operations/option.md)                                        | :heavy_minus_sign:                                                                              | The options for this request.                                                                   |

### Response

**[*operations.ExportMisuseFindingsResponse](../../models/operations/exportmisusefindingsresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.AuditAPIError | 400, 401, 403           | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## ExportFinding

One finding with its actions and ledger events, as CSV.

### Example Usage

<!-- UsageSnippet language="go" operationID="exportMisuseFinding" method="get" path="/api/v1/audit/misuse/findings/{finding_id}/export" -->
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

    res, err := s.Audit.ExportFinding(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Res != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `findingID`                                                         | `string`                                                            | :heavy_check_mark:                                                  | The finding id.                                                     |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ExportMisuseFindingResponse](../../models/operations/exportmisusefindingresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.AuditAPIError | 401, 403, 404           | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |