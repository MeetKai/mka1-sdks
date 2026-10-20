# AgentVersions

## Overview

Inspect an agent's configuration history and roll back to a prior version.

### Available Operations

* [ListAgentVersions](#listagentversions) - List agent versions
* [GetAgentVersion](#getagentversion) - Retrieve an agent version
* [RollbackAgentVersion](#rollbackagentversion) - Roll back an agent to a version

## ListAgentVersions

Lists the configuration history for an agent. Each committed change (create, update, rollback) appends a version.

### Example Usage

<!-- UsageSnippet language="go" operationID="listAgentVersions" method="get" path="/api/v1/agents/{agent_id}/versions" -->
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

    res, err := s.AgentVersions.ListAgentVersions(ctx, operations.ListAgentVersionsRequest{
        AgentID: "<id>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentVersionList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `request`                                                                                  | [operations.ListAgentVersionsRequest](../../models/operations/listagentversionsrequest.md) | :heavy_check_mark:                                                                         | The request object to use for the request.                                                 |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.ListAgentVersionsResponse](../../models/operations/listagentversionsresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 404                | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## GetAgentVersion

Retrieve an agent version

### Example Usage

<!-- UsageSnippet language="go" operationID="getAgentVersion" method="get" path="/api/v1/agents/{agent_id}/versions/{version}" -->
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

    res, err := s.AgentVersions.GetAgentVersion(ctx, "<id>", 652149, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentVersion != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `agentID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `version`                                                           | `int64`                                                             | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetAgentVersionResponse](../../models/operations/getagentversionresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 404                | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## RollbackAgentVersion

Restores the target version's configuration as a new current version. History is preserved: the restore is appended as a new version rather than deleting later ones.

### Example Usage

<!-- UsageSnippet language="go" operationID="rollbackAgentVersion" method="post" path="/api/v1/agents/{agent_id}/versions/{version}/rollback" -->
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

    res, err := s.AgentVersions.RollbackAgentVersion(ctx, "<id>", 880902, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Agent != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `agentID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `version`                                                           | `int64`                                                             | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.RollbackAgentVersionResponse](../../models/operations/rollbackagentversionresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 404                | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |