# Analytics.Keys

## Overview

Create and revoke project keys for sending events.

### Available Operations

* [Create](#create) - Create a capture key and return its secret once
* [List](#list) - List capture key metadata
* [Revoke](#revoke) - Revoke a capture key

## Create

Create a key that can send events to this project. Save the key from this response; its secret is only returned once. Capture keys cannot read analytics or manage projects.

### Example Usage

<!-- UsageSnippet language="go" operationID="analytics_keys_create" method="post" path="/api/v1/analytics/projects/{id}/keys" -->
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

    res, err := s.Analytics.Keys.Create(ctx, "<id>", components.AnalyticsKeyCreate{
        Name: "<value>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.AnalyticsCreatedCaptureKey != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `ctx`                                                                          | [context.Context](https://pkg.go.dev/context#Context)                          | :heavy_check_mark:                                                             | The context to use for the request.                                            |
| `id`                                                                           | `string`                                                                       | :heavy_check_mark:                                                             | ID of the analytics project.                                                   |
| `body`                                                                         | [components.AnalyticsKeyCreate](../../models/components/analyticskeycreate.md) | :heavy_check_mark:                                                             | N/A                                                                            |
| `opts`                                                                         | [][operations.Option](../../models/operations/option.md)                       | :heavy_minus_sign:                                                             | The options for this request.                                                  |

### Response

**[*operations.AnalyticsKeysCreateResponse](../../models/operations/analyticskeyscreateresponse.md), error**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| apierrors.AnalyticsError               | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| apierrors.AnalyticsError               | 500, 503                               | application/json                       |
| apierrors.APIError                     | 4XX, 5XX                               | \*/\*                                  |

## List

List capture key metadata

### Example Usage

<!-- UsageSnippet language="go" operationID="analytics_keys_list" method="get" path="/api/v1/analytics/projects/{id}/keys" -->
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

    res, err := s.Analytics.Keys.List(ctx, "<id>", mka1.Pointer[int64](50), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AnalyticsKeyList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `id`                                                     | `string`                                                 | :heavy_check_mark:                                       | ID of the analytics project.                             |
| `limit`                                                  | `*int64`                                                 | :heavy_minus_sign:                                       | N/A                                                      |
| `after`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.AnalyticsKeysListResponse](../../models/operations/analyticskeyslistresponse.md), error**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| apierrors.AnalyticsError               | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| apierrors.AnalyticsError               | 500, 503                               | application/json                       |
| apierrors.APIError                     | 4XX, 5XX                               | \*/\*                                  |

## Revoke

Revoke a capture key

### Example Usage

<!-- UsageSnippet language="go" operationID="analytics_keys_revoke" method="delete" path="/api/v1/analytics/projects/{id}/keys/{keyId}" -->
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

    res, err := s.Analytics.Keys.Revoke(ctx, "<id>", "<id>")
    if err != nil {
        log.Fatal(err)
    }
    if res.AnalyticsCaptureKey != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `id`                                                     | `string`                                                 | :heavy_check_mark:                                       | ID of the analytics project.                             |
| `keyID`                                                  | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.AnalyticsKeysRevokeResponse](../../models/operations/analyticskeysrevokeresponse.md), error**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| apierrors.AnalyticsError               | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| apierrors.AnalyticsError               | 500, 503                               | application/json                       |
| apierrors.APIError                     | 4XX, 5XX                               | \*/\*                                  |