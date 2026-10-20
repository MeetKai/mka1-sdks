# ComputeVolumes

## Overview

### Available Operations

* [ListStandaloneVolumes](#liststandalonevolumes) - List organization volumes
* [CreateStandaloneVolume](#createstandalonevolume) - Create a standalone shared volume
* [DeleteStandaloneVolume](#deletestandalonevolume) - Permanently delete a standalone volume
* [GetStandaloneVolume](#getstandalonevolume) - Get a standalone volume
* [ListStandaloneVolumeAttachments](#liststandalonevolumeattachments) - List volume attachments

## ListStandaloneVolumes

Lists the organization's volumes, newest first. Deleted volumes are omitted unless `status` is `deleted`; a deleted volume also stays readable by id.

### Example Usage

<!-- UsageSnippet language="go" operationID="listStandaloneVolumes" method="get" path="/api/v1/compute/volumes" -->
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

    res, err := s.ComputeVolumes.ListStandaloneVolumes(ctx, nil, nil, mka1.Pointer[int64](50), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeStandaloneVolumeList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                               | [context.Context](https://pkg.go.dev/context#Context)                                               | :heavy_check_mark:                                                                                  | The context to use for the request.                                                                 |
| `status`                                                                                            | [*components.ComputeStandaloneVolumeState](../../models/components/computestandalonevolumestate.md) | :heavy_minus_sign:                                                                                  | Lists only volumes in this state. Without it, every state but `deleted` is listed.                  |
| `cursor`                                                                                            | `*string`                                                                                           | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |
| `limit`                                                                                             | `*int64`                                                                                            | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |
| `xOnBehalfOf`                                                                                       | `*string`                                                                                           | :heavy_minus_sign:                                                                                  | Optional external end-user identifier forwarded by the API gateway.                                 |
| `opts`                                                                                              | [][operations.Option](../../models/operations/option.md)                                            | :heavy_minus_sign:                                                                                  | The options for this request.                                                                       |

### Response

**[*operations.ListStandaloneVolumesResponse](../../models/operations/liststandalonevolumesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateStandaloneVolume

Create a standalone shared volume

### Example Usage

<!-- UsageSnippet language="go" operationID="createStandaloneVolume" method="post" path="/api/v1/compute/volumes" -->
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

    res, err := s.ComputeVolumes.CreateStandaloneVolume(ctx, "<value>", components.ComputeStandaloneVolumeCreate{
        Name: "<value>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeStandaloneVolume != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                                | :heavy_check_mark:                                                                                   | The context to use for the request.                                                                  |
| `idempotencyKey`                                                                                     | `string`                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `body`                                                                                               | [components.ComputeStandaloneVolumeCreate](../../models/components/computestandalonevolumecreate.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `xOnBehalfOf`                                                                                        | `*string`                                                                                            | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |
| `opts`                                                                                               | [][operations.Option](../../models/operations/option.md)                                             | :heavy_minus_sign:                                                                                   | The options for this request.                                                                        |

### Response

**[*operations.CreateStandaloneVolumeResponse](../../models/operations/createstandalonevolumeresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteStandaloneVolume

Deletion bypasses tenant enablement and budget gates, but is refused while non-terminal attachments exist.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteStandaloneVolume" method="delete" path="/api/v1/compute/volumes/{id}" -->
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

    res, err := s.ComputeVolumes.DeleteStandaloneVolume(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeStandaloneVolume != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `id`                                                                | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.DeleteStandaloneVolumeResponse](../../models/operations/deletestandalonevolumeresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetStandaloneVolume

Get a standalone volume

### Example Usage

<!-- UsageSnippet language="go" operationID="getStandaloneVolume" method="get" path="/api/v1/compute/volumes/{id}" -->
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

    res, err := s.ComputeVolumes.GetStandaloneVolume(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeStandaloneVolume != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `id`                                                                | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetStandaloneVolumeResponse](../../models/operations/getstandalonevolumeresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListStandaloneVolumeAttachments

List volume attachments

### Example Usage

<!-- UsageSnippet language="go" operationID="listStandaloneVolumeAttachments" method="get" path="/api/v1/compute/volumes/{id}/attachments" -->
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

    res, err := s.ComputeVolumes.ListStandaloneVolumeAttachments(ctx, operations.ListStandaloneVolumeAttachmentsRequest{
        ID: "<id>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeStandaloneVolumeAttachmentList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                              | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                                  | :heavy_check_mark:                                                                                                     | The context to use for the request.                                                                                    |
| `request`                                                                                                              | [operations.ListStandaloneVolumeAttachmentsRequest](../../models/operations/liststandalonevolumeattachmentsrequest.md) | :heavy_check_mark:                                                                                                     | The request object to use for the request.                                                                             |
| `opts`                                                                                                                 | [][operations.Option](../../models/operations/option.md)                                                               | :heavy_minus_sign:                                                                                                     | The options for this request.                                                                                          |

### Response

**[*operations.ListStandaloneVolumeAttachmentsResponse](../../models/operations/liststandalonevolumeattachmentsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |