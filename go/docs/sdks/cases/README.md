# Support.Cases

## Overview

### Available Operations

* [List](#list) - List support cases
* [Create](#create) - Open a support case
* [Get](#get) - Get a support case
* [Comment](#comment) - Comment on a support case
* [Resolve](#resolve) - Resolve a support case

## List

Support cases visible to the caller, most recently updated first. Requires `read:support`.

### Example Usage

<!-- UsageSnippet language="go" operationID="listSupportCases" method="get" path="/api/v1/support/cases" -->
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

    res, err := s.Support.Cases.List(ctx, nil, mka1.Pointer[int64](20), mka1.Pointer[int64](0), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SupportCaseList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `ctx`                                                                           | [context.Context](https://pkg.go.dev/context#Context)                           | :heavy_check_mark:                                                              | The context to use for the request.                                             |
| `status`                                                                        | `*string`                                                                       | :heavy_minus_sign:                                                              | Comma-separated statuses to include: `open`, `waiting_on_customer`, `resolved`. |
| `limit`                                                                         | `*int64`                                                                        | :heavy_minus_sign:                                                              | Maximum number of items to return.                                              |
| `offset`                                                                        | `*int64`                                                                        | :heavy_minus_sign:                                                              | Number of items to skip.                                                        |
| `xOnBehalfOf`                                                                   | `*string`                                                                       | :heavy_minus_sign:                                                              | Optional external end-user identifier forwarded by the API gateway.             |
| `opts`                                                                          | [][operations.Option](../../models/operations/option.md)                        | :heavy_minus_sign:                                                              | The options for this request.                                                   |

### Response

**[*operations.ListSupportCasesResponse](../../models/operations/listsupportcasesresponse.md), error**

### Errors

| Error Type                | Status Code               | Content Type              |
| ------------------------- | ------------------------- | ------------------------- |
| apierrors.SupportAPIError | 400, 401, 403             | application/json          |
| apierrors.APIError        | 4XX, 5XX                  | \*/\*                     |

## Create

Requires `write:support`.

### Example Usage

<!-- UsageSnippet language="go" operationID="createSupportCase" method="post" path="/api/v1/support/cases" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Support.Cases.Create(ctx, components.CreateSupportCaseRequest{
        Subject: "<value>",
        Description: "within encode where among incidentally cricket",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SupportCase != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `body`                                                                                     | [components.CreateSupportCaseRequest](../../models/components/createsupportcaserequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `xOnBehalfOf`                                                                              | `*string`                                                                                  | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.CreateSupportCaseResponse](../../models/operations/createsupportcaseresponse.md), error**

### Errors

| Error Type                | Status Code               | Content Type              |
| ------------------------- | ------------------------- | ------------------------- |
| apierrors.SupportAPIError | 400, 401, 403             | application/json          |
| apierrors.APIError        | 4XX, 5XX                  | \*/\*                     |

## Get

One support case with its timeline. Requires `read:support`.

### Example Usage

<!-- UsageSnippet language="go" operationID="getSupportCase" method="get" path="/api/v1/support/cases/{case_id}" -->
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

    res, err := s.Support.Cases.Get(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SupportCase != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `caseID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | The support case id.                                                |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetSupportCaseResponse](../../models/operations/getsupportcaseresponse.md), error**

### Errors

| Error Type                | Status Code               | Content Type              |
| ------------------------- | ------------------------- | ------------------------- |
| apierrors.SupportAPIError | 401, 403, 404             | application/json          |
| apierrors.APIError        | 4XX, 5XX                  | \*/\*                     |

## Comment

Adds a comment. A comment on a case that is waiting on you or resolved reopens it. Requires `write:support`.

### Example Usage

<!-- UsageSnippet language="go" operationID="commentOnSupportCase" method="post" path="/api/v1/support/cases/{case_id}/comments" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Support.Cases.Comment(ctx, "<id>", components.SupportCaseCommentRequest{
        Body: "<value>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SupportCase != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `ctx`                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                        | :heavy_check_mark:                                                                           | The context to use for the request.                                                          |
| `caseID`                                                                                     | `string`                                                                                     | :heavy_check_mark:                                                                           | The support case id.                                                                         |
| `body`                                                                                       | [components.SupportCaseCommentRequest](../../models/components/supportcasecommentrequest.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `xOnBehalfOf`                                                                                | `*string`                                                                                    | :heavy_minus_sign:                                                                           | Optional external end-user identifier forwarded by the API gateway.                          |
| `opts`                                                                                       | [][operations.Option](../../models/operations/option.md)                                     | :heavy_minus_sign:                                                                           | The options for this request.                                                                |

### Response

**[*operations.CommentOnSupportCaseResponse](../../models/operations/commentonsupportcaseresponse.md), error**

### Errors

| Error Type                | Status Code               | Content Type              |
| ------------------------- | ------------------------- | ------------------------- |
| apierrors.SupportAPIError | 400, 401, 403, 404        | application/json          |
| apierrors.APIError        | 4XX, 5XX                  | \*/\*                     |

## Resolve

Marks the case resolved, with an optional closing comment. Requires `write:support`.

### Example Usage

<!-- UsageSnippet language="go" operationID="resolveSupportCase" method="post" path="/api/v1/support/cases/{case_id}/resolve" -->
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

    res, err := s.Support.Cases.Resolve(ctx, "<id>", nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SupportCase != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `ctx`                                                                                         | [context.Context](https://pkg.go.dev/context#Context)                                         | :heavy_check_mark:                                                                            | The context to use for the request.                                                           |
| `caseID`                                                                                      | `string`                                                                                      | :heavy_check_mark:                                                                            | The support case id.                                                                          |
| `xOnBehalfOf`                                                                                 | `*string`                                                                                     | :heavy_minus_sign:                                                                            | Optional external end-user identifier forwarded by the API gateway.                           |
| `body`                                                                                        | [*components.SupportCaseResolveRequest](../../models/components/supportcaseresolverequest.md) | :heavy_minus_sign:                                                                            | N/A                                                                                           |
| `opts`                                                                                        | [][operations.Option](../../models/operations/option.md)                                      | :heavy_minus_sign:                                                                            | The options for this request.                                                                 |

### Response

**[*operations.ResolveSupportCaseResponse](../../models/operations/resolvesupportcaseresponse.md), error**

### Errors

| Error Type                | Status Code               | Content Type              |
| ------------------------- | ------------------------- | ------------------------- |
| apierrors.SupportAPIError | 400, 401, 403, 404, 409   | application/json          |
| apierrors.APIError        | 4XX, 5XX                  | \*/\*                     |