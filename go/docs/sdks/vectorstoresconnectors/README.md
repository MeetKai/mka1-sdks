# Llm.VectorStores.Connectors

## Overview

### Available Operations

* [Create](#create) - Create a vector store connector
* [List](#list) - List vector store connectors
* [Get](#get) - Get a vector store connector
* [Update](#update) - Update a vector store connector
* [Delete](#delete) - Delete a vector store connector
* [Sync](#sync) - Sync a vector store connector once
* [Link](#link) - Link a vector store to a connector
* [Unlink](#unlink) - Unsync a connector from a vector store
* [ListRuns](#listruns) - List a connector's sync runs
* [GetRun](#getrun) - Get a sync run with its skipped and failed objects
* [ListObjects](#listobjects) - List what a connector has mirrored
* [Browse](#browse) - Browse a connector's location

## Create

Creates a connector to an external location. The location and credential are validated by listing once. With auto_sync on and stores given, the first sync starts at once. Requires an API key: the connector keeps running after a console session ends, and every sync runs as that key's principal.

### Example Usage

<!-- UsageSnippet language="go" operationID="createVectorStoreConnector" method="post" path="/api/v1/llm/vector_stores/connectors" -->
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

    res, err := s.Llm.VectorStores.Connectors.Create(ctx, operations.CreateCreateVectorStoreConnectorRequestBodyS3(
        components.VectorStoreConnectorCreateS3{
            Location: components.VectorStoreConnectorS3Location{
                Bucket: "<value>",
                Region: "<value>",
            },
            Credentials: components.VectorStoreConnectorS3Credentials{
                AccessKeyID: "<id>",
                SecretAccessKey: "<value>",
            },
            Name: "<value>",
        },
    ), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreConnector != nil {
        switch res.VectorStoreConnector.Location.Type {
            case components.LocationTypeVectorStoreConnectorS3Location:
                // res.VectorStoreConnector.Location.VectorStoreConnectorS3Location is populated
            case components.LocationTypeVectorStoreConnectorSharePointLocation:
                // res.VectorStoreConnector.Location.VectorStoreConnectorSharePointLocation is populated
            default:
                // Unknown type - use res.VectorStoreConnector.Location.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                                                                            | Type                                                                                                                 | Required                                                                                                             | Description                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                                                | :heavy_check_mark:                                                                                                   | The context to use for the request.                                                                                  |
| `body`                                                                                                               | [operations.CreateVectorStoreConnectorRequestBody](../../models/operations/createvectorstoreconnectorrequestbody.md) | :heavy_check_mark:                                                                                                   | N/A                                                                                                                  |
| `xOnBehalfOf`                                                                                                        | `*string`                                                                                                            | :heavy_minus_sign:                                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                                  |
| `opts`                                                                                                               | [][operations.Option](../../models/operations/option.md)                                                             | :heavy_minus_sign:                                                                                                   | The options for this request.                                                                                        |

### Response

**[*operations.CreateVectorStoreConnectorResponse](../../models/operations/createvectorstoreconnectorresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## List

Connectors created by the caller's principal, or every connector in the organization for an organization admin. `vector_store_id` answers what feeds a store.

### Example Usage

<!-- UsageSnippet language="go" operationID="listVectorStoreConnectors" method="get" path="/api/v1/llm/vector_stores/connectors" -->
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

    res, err := s.Llm.VectorStores.Connectors.List(ctx, operations.ListVectorStoreConnectorsRequest{})
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreConnectorList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                  | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                                      | :heavy_check_mark:                                                                                         | The context to use for the request.                                                                        |
| `request`                                                                                                  | [operations.ListVectorStoreConnectorsRequest](../../models/operations/listvectorstoreconnectorsrequest.md) | :heavy_check_mark:                                                                                         | The request object to use for the request.                                                                 |
| `opts`                                                                                                     | [][operations.Option](../../models/operations/option.md)                                                   | :heavy_minus_sign:                                                                                         | The options for this request.                                                                              |

### Response

**[*operations.ListVectorStoreConnectorsResponse](../../models/operations/listvectorstoreconnectorsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Get

Get a vector store connector

### Example Usage

<!-- UsageSnippet language="go" operationID="getVectorStoreConnector" method="get" path="/api/v1/llm/vector_stores/connectors/{connector_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.Connectors.Get(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreConnector != nil {
        switch res.VectorStoreConnector.Location.Type {
            case components.LocationTypeVectorStoreConnectorS3Location:
                // res.VectorStoreConnector.Location.VectorStoreConnectorS3Location is populated
            case components.LocationTypeVectorStoreConnectorSharePointLocation:
                // res.VectorStoreConnector.Location.VectorStoreConnectorSharePointLocation is populated
            default:
                // Unknown type - use res.VectorStoreConnector.Location.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `connectorID`                                                       | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetVectorStoreConnectorResponse](../../models/operations/getvectorstoreconnectorresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Update

Changes name, credential, selection rules or sync settings. A rule change starts a sync at once while auto_sync is on. Made with an API key of the connector's principal, the call also moves the connector to that key.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateVectorStoreConnector" method="post" path="/api/v1/llm/vector_stores/connectors/{connector_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.Connectors.Update(ctx, "<id>", operations.UpdateVectorStoreConnectorRequestBody{}, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreConnector != nil {
        switch res.VectorStoreConnector.Location.Type {
            case components.LocationTypeVectorStoreConnectorS3Location:
                // res.VectorStoreConnector.Location.VectorStoreConnectorS3Location is populated
            case components.LocationTypeVectorStoreConnectorSharePointLocation:
                // res.VectorStoreConnector.Location.VectorStoreConnectorSharePointLocation is populated
            default:
                // Unknown type - use res.VectorStoreConnector.Location.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                                                                            | Type                                                                                                                 | Required                                                                                                             | Description                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                                                | :heavy_check_mark:                                                                                                   | The context to use for the request.                                                                                  |
| `connectorID`                                                                                                        | `string`                                                                                                             | :heavy_check_mark:                                                                                                   | N/A                                                                                                                  |
| `body`                                                                                                               | [operations.UpdateVectorStoreConnectorRequestBody](../../models/operations/updatevectorstoreconnectorrequestbody.md) | :heavy_check_mark:                                                                                                   | N/A                                                                                                                  |
| `xOnBehalfOf`                                                                                                        | `*string`                                                                                                            | :heavy_minus_sign:                                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                                  |
| `opts`                                                                                                               | [][operations.Option](../../models/operations/option.md)                                                             | :heavy_minus_sign:                                                                                                   | The options for this request.                                                                                        |

### Response

**[*operations.UpdateVectorStoreConnectorResponse](../../models/operations/updatevectorstoreconnectorresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Delete

Unsyncs the connector from every linked store and deletes its files, with the caller's own access. The removal runs in the background and is returned; the connector shows status `removing` until it is gone.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteVectorStoreConnector" method="delete" path="/api/v1/llm/vector_stores/connectors/{connector_id}" -->
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

    res, err := s.Llm.VectorStores.Connectors.Delete(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreConnectorRemoval != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `connectorID`                                                       | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.DeleteVectorStoreConnectorResponse](../../models/operations/deletevectorstoreconnectorresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Sync

Runs the sync once, whether auto_sync is on or off. A request made while a run is in progress returns that run. Refused when no store is linked.

### Example Usage

<!-- UsageSnippet language="go" operationID="syncVectorStoreConnector" method="post" path="/api/v1/llm/vector_stores/connectors/{connector_id}/sync" -->
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

    res, err := s.Llm.VectorStores.Connectors.Sync(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreConnectorRunSummary != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `connectorID`                                                       | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.SyncVectorStoreConnectorResponse](../../models/operations/syncvectorstoreconnectorresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Link

The connector's current files are attached to the store at once, without downloading again. A connector that has never synced starts its first sync if auto_sync is on.

### Example Usage

<!-- UsageSnippet language="go" operationID="linkVectorStoreConnector" method="post" path="/api/v1/llm/vector_stores/connectors/{connector_id}/vector_stores" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.Connectors.Link(ctx, "<id>", operations.LinkVectorStoreConnectorRequestBody{
        VectorStoreID: "<id>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreConnector != nil {
        switch res.VectorStoreConnector.Location.Type {
            case components.LocationTypeVectorStoreConnectorS3Location:
                // res.VectorStoreConnector.Location.VectorStoreConnectorS3Location is populated
            case components.LocationTypeVectorStoreConnectorSharePointLocation:
                // res.VectorStoreConnector.Location.VectorStoreConnectorSharePointLocation is populated
            default:
                // Unknown type - use res.VectorStoreConnector.Location.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                                                                        | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                                            | :heavy_check_mark:                                                                                               | The context to use for the request.                                                                              |
| `connectorID`                                                                                                    | `string`                                                                                                         | :heavy_check_mark:                                                                                               | N/A                                                                                                              |
| `body`                                                                                                           | [operations.LinkVectorStoreConnectorRequestBody](../../models/operations/linkvectorstoreconnectorrequestbody.md) | :heavy_check_mark:                                                                                               | N/A                                                                                                              |
| `xOnBehalfOf`                                                                                                    | `*string`                                                                                                        | :heavy_minus_sign:                                                                                               | Optional external end-user identifier forwarded by the API gateway.                                              |
| `opts`                                                                                                           | [][operations.Option](../../models/operations/option.md)                                                         | :heavy_minus_sign:                                                                                               | The options for this request.                                                                                    |

### Response

**[*operations.LinkVectorStoreConnectorResponse](../../models/operations/linkvectorstoreconnectorresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Unlink

Unlinks the store and removes the connector's files from it, with the caller's own access. When the last store is unlinked the connector's files are deleted. The removal runs in the background and is returned.

### Example Usage

<!-- UsageSnippet language="go" operationID="unlinkVectorStoreConnector" method="delete" path="/api/v1/llm/vector_stores/connectors/{connector_id}/vector_stores/{vector_store_id}" -->
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

    res, err := s.Llm.VectorStores.Connectors.Unlink(ctx, "<id>", "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreConnectorRemoval != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `connectorID`                                                       | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `vectorStoreID`                                                     | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.UnlinkVectorStoreConnectorResponse](../../models/operations/unlinkvectorstoreconnectorresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListRuns

List a connector's sync runs

### Example Usage

<!-- UsageSnippet language="go" operationID="listVectorStoreConnectorRuns" method="get" path="/api/v1/llm/vector_stores/connectors/{connector_id}/runs" -->
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

    res, err := s.Llm.VectorStores.Connectors.ListRuns(ctx, operations.ListVectorStoreConnectorRunsRequest{
        ConnectorID: "<id>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreConnectorRunList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                        | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                                            | :heavy_check_mark:                                                                                               | The context to use for the request.                                                                              |
| `request`                                                                                                        | [operations.ListVectorStoreConnectorRunsRequest](../../models/operations/listvectorstoreconnectorrunsrequest.md) | :heavy_check_mark:                                                                                               | The request object to use for the request.                                                                       |
| `opts`                                                                                                           | [][operations.Option](../../models/operations/option.md)                                                         | :heavy_minus_sign:                                                                                               | The options for this request.                                                                                    |

### Response

**[*operations.ListVectorStoreConnectorRunsResponse](../../models/operations/listvectorstoreconnectorrunsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetRun

Get a sync run with its skipped and failed objects

### Example Usage

<!-- UsageSnippet language="go" operationID="getVectorStoreConnectorRun" method="get" path="/api/v1/llm/vector_stores/connectors/{connector_id}/runs/{run_id}" -->
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

    res, err := s.Llm.VectorStores.Connectors.GetRun(ctx, operations.GetVectorStoreConnectorRunRequest{
        ConnectorID: "<id>",
        RunID: "<id>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreConnectorRun != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                    | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                                        | :heavy_check_mark:                                                                                           | The context to use for the request.                                                                          |
| `request`                                                                                                    | [operations.GetVectorStoreConnectorRunRequest](../../models/operations/getvectorstoreconnectorrunrequest.md) | :heavy_check_mark:                                                                                           | The request object to use for the request.                                                                   |
| `opts`                                                                                                       | [][operations.Option](../../models/operations/option.md)                                                     | :heavy_minus_sign:                                                                                           | The options for this request.                                                                                |

### Response

**[*operations.GetVectorStoreConnectorRunResponse](../../models/operations/getvectorstoreconnectorrunresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListObjects

Every object the connector tracks, with its status and, when skipped or failed, the reason. Ordered by source_path.

### Example Usage

<!-- UsageSnippet language="go" operationID="listVectorStoreConnectorObjects" method="get" path="/api/v1/llm/vector_stores/connectors/{connector_id}/objects" -->
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

    res, err := s.Llm.VectorStores.Connectors.ListObjects(ctx, operations.ListVectorStoreConnectorObjectsRequest{
        ConnectorID: "<id>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreConnectorObjectList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                              | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                                  | :heavy_check_mark:                                                                                                     | The context to use for the request.                                                                                    |
| `request`                                                                                                              | [operations.ListVectorStoreConnectorObjectsRequest](../../models/operations/listvectorstoreconnectorobjectsrequest.md) | :heavy_check_mark:                                                                                                     | The request object to use for the request.                                                                             |
| `opts`                                                                                                                 | [][operations.Option](../../models/operations/option.md)                                                               | :heavy_minus_sign:                                                                                                     | The options for this request.                                                                                          |

### Response

**[*operations.ListVectorStoreConnectorObjectsResponse](../../models/operations/listvectorstoreconnectorobjectsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Browse

Reads the location live, one folder at a time, with the connector's stored credential. Each object says whether the connector's current rules select it. Works before any sync has run and changes nothing.

### Example Usage

<!-- UsageSnippet language="go" operationID="browseVectorStoreConnector" method="get" path="/api/v1/llm/vector_stores/connectors/{connector_id}/browse" -->
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

    res, err := s.Llm.VectorStores.Connectors.Browse(ctx, operations.BrowseVectorStoreConnectorRequest{
        ConnectorID: "<id>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreConnectorBrowseList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                    | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                                        | :heavy_check_mark:                                                                                           | The context to use for the request.                                                                          |
| `request`                                                                                                    | [operations.BrowseVectorStoreConnectorRequest](../../models/operations/browsevectorstoreconnectorrequest.md) | :heavy_check_mark:                                                                                           | The request object to use for the request.                                                                   |
| `opts`                                                                                                       | [][operations.Option](../../models/operations/option.md)                                                     | :heavy_minus_sign:                                                                                           | The options for this request.                                                                                |

### Response

**[*operations.BrowseVectorStoreConnectorResponse](../../models/operations/browsevectorstoreconnectorresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |