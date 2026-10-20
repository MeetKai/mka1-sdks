# ComputeServices

## Overview

### Available Operations

* [ListServices](#listservices) - List services
* [CreateService](#createservice) - Create a service
* [GetService](#getservice) - Get a service
* [ListServiceEvents](#listserviceevents) - List service events
* [ListServiceInstances](#listserviceinstances) - List observed service instances
* [ListServiceLogs](#listservicelogs) - List service logs
* [UpdateServiceScaling](#updateservicescaling) - Replace a service scaling policy
* [TerminateService](#terminateservice) - Terminate a service

## ListServices

List services

### Example Usage

<!-- UsageSnippet language="go" operationID="listServices" method="get" path="/api/v1/compute/services" -->
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

    res, err := s.ComputeServices.ListServices(ctx, nil, nil, mka1.Pointer[int64](50), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeServiceList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `ctx`                                                                               | [context.Context](https://pkg.go.dev/context#Context)                               | :heavy_check_mark:                                                                  | The context to use for the request.                                                 |
| `state`                                                                             | [*components.ComputeResourceState](../../models/components/computeresourcestate.md) | :heavy_minus_sign:                                                                  | N/A                                                                                 |
| `cursor`                                                                            | `*string`                                                                           | :heavy_minus_sign:                                                                  | N/A                                                                                 |
| `limit`                                                                             | `*int64`                                                                            | :heavy_minus_sign:                                                                  | N/A                                                                                 |
| `xOnBehalfOf`                                                                       | `*string`                                                                           | :heavy_minus_sign:                                                                  | Optional external end-user identifier forwarded by the API gateway.                 |
| `opts`                                                                              | [][operations.Option](../../models/operations/option.md)                            | :heavy_minus_sign:                                                                  | The options for this request.                                                       |

### Response

**[*operations.ListServicesResponse](../../models/operations/listservicesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateService

Create a service

### Example Usage

<!-- UsageSnippet language="go" operationID="createService" method="post" path="/api/v1/compute/services" -->
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

    res, err := s.ComputeServices.CreateService(ctx, "<value>", components.ComputeResourceCreate{
        Compute: components.ComputeRequest{
            Accelerator: "<value>",
            EphemeralDiskGb: 709572,
            GpuCount: 103964,
        },
        Container: components.CreateComputeContainerCreateUnionComputeContainerCreate2(
            components.ComputeContainerCreate2{
                Image: "https://loremflickr.com/676/3598?lock=35726374653792",
                ScriptB64: "<value>",
            },
        ),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeService != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `ctx`                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                | :heavy_check_mark:                                                                   | The context to use for the request.                                                  |
| `idempotencyKey`                                                                     | `string`                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `body`                                                                               | [components.ComputeResourceCreate](../../models/components/computeresourcecreate.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `xOnBehalfOf`                                                                        | `*string`                                                                            | :heavy_minus_sign:                                                                   | Optional external end-user identifier forwarded by the API gateway.                  |
| `opts`                                                                               | [][operations.Option](../../models/operations/option.md)                             | :heavy_minus_sign:                                                                   | The options for this request.                                                        |

### Response

**[*operations.CreateServiceResponse](../../models/operations/createserviceresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetService

Get a service

### Example Usage

<!-- UsageSnippet language="go" operationID="getService" method="get" path="/api/v1/compute/services/{id}" -->
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

    res, err := s.ComputeServices.GetService(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeService != nil {
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

**[*operations.GetServiceResponse](../../models/operations/getserviceresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListServiceEvents

List service events

### Example Usage

<!-- UsageSnippet language="go" operationID="listServiceEvents" method="get" path="/api/v1/compute/services/{id}/events" -->
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

    res, err := s.ComputeServices.ListServiceEvents(ctx, operations.ListServiceEventsRequest{
        ID: "<id>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeEventList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `request`                                                                                  | [operations.ListServiceEventsRequest](../../models/operations/listserviceeventsrequest.md) | :heavy_check_mark:                                                                         | The request object to use for the request.                                                 |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.ListServiceEventsResponse](../../models/operations/listserviceeventsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListServiceInstances

List observed service instances

### Example Usage

<!-- UsageSnippet language="go" operationID="listServiceInstances" method="get" path="/api/v1/compute/services/{id}/instances" -->
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

    res, err := s.ComputeServices.ListServiceInstances(ctx, operations.ListServiceInstancesRequest{
        ID: "<id>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeInstanceList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                            | :heavy_check_mark:                                                                               | The context to use for the request.                                                              |
| `request`                                                                                        | [operations.ListServiceInstancesRequest](../../models/operations/listserviceinstancesrequest.md) | :heavy_check_mark:                                                                               | The request object to use for the request.                                                       |
| `opts`                                                                                           | [][operations.Option](../../models/operations/option.md)                                         | :heavy_minus_sign:                                                                               | The options for this request.                                                                    |

### Response

**[*operations.ListServiceInstancesResponse](../../models/operations/listserviceinstancesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListServiceLogs

List service logs

### Example Usage

<!-- UsageSnippet language="go" operationID="listServiceLogs" method="get" path="/api/v1/compute/services/{id}/logs" -->
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

    res, err := s.ComputeServices.ListServiceLogs(ctx, operations.ListServiceLogsRequest{
        ID: "<id>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeLogList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `ctx`                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                  | :heavy_check_mark:                                                                     | The context to use for the request.                                                    |
| `request`                                                                              | [operations.ListServiceLogsRequest](../../models/operations/listservicelogsrequest.md) | :heavy_check_mark:                                                                     | The request object to use for the request.                                             |
| `opts`                                                                                 | [][operations.Option](../../models/operations/option.md)                               | :heavy_minus_sign:                                                                     | The options for this request.                                                          |

### Response

**[*operations.ListServiceLogsResponse](../../models/operations/listservicelogsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## UpdateServiceScaling

Replace a service scaling policy

### Example Usage

<!-- UsageSnippet language="go" operationID="updateServiceScaling" method="patch" path="/api/v1/compute/services/{id}/scaling" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.ComputeServices.UpdateServiceScaling(ctx, operations.UpdateServiceScalingRequest{
        ID: "<id>",
        IdempotencyKey: "<value>",
        Body: components.ComputeScalingInput{
            MaxReplicas: 800181,
            MinReplicas: 693036,
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeService != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                            | :heavy_check_mark:                                                                               | The context to use for the request.                                                              |
| `request`                                                                                        | [operations.UpdateServiceScalingRequest](../../models/operations/updateservicescalingrequest.md) | :heavy_check_mark:                                                                               | The request object to use for the request.                                                       |
| `opts`                                                                                           | [][operations.Option](../../models/operations/option.md)                                         | :heavy_minus_sign:                                                                               | The options for this request.                                                                    |

### Response

**[*operations.UpdateServiceScalingResponse](../../models/operations/updateservicescalingresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## TerminateService

Terminate a service

### Example Usage

<!-- UsageSnippet language="go" operationID="terminateService" method="post" path="/api/v1/compute/services/{id}/terminate" -->
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

    res, err := s.ComputeServices.TerminateService(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeService != nil {
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

**[*operations.TerminateServiceResponse](../../models/operations/terminateserviceresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |