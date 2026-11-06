# Status.Incidents

## Overview

### Available Operations

* [List](#list) - List incidents
* [Get](#get) - Get an incident

## List

Incidents, most recently started first.

### Example Usage

<!-- UsageSnippet language="go" operationID="listStatusIncidents" method="get" path="/api/v1/status/incidents" -->
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

    res, err := s.Status.Incidents.List(ctx, operations.ListStatusIncidentsRequest{})
    if err != nil {
        log.Fatal(err)
    }
    if res.StatusIncidentList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ctx`                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                          | :heavy_check_mark:                                                                             | The context to use for the request.                                                            |
| `request`                                                                                      | [operations.ListStatusIncidentsRequest](../../models/operations/liststatusincidentsrequest.md) | :heavy_check_mark:                                                                             | The request object to use for the request.                                                     |
| `opts`                                                                                         | [][operations.Option](../../models/operations/option.md)                                       | :heavy_minus_sign:                                                                             | The options for this request.                                                                  |

### Response

**[*operations.ListStatusIncidentsResponse](../../models/operations/liststatusincidentsresponse.md), error**

### Errors

| Error Type                | Status Code               | Content Type              |
| ------------------------- | ------------------------- | ------------------------- |
| apierrors.SupportAPIError | 400, 401                  | application/json          |
| apierrors.APIError        | 4XX, 5XX                  | \*/\*                     |

## Get

One incident with its full timeline of updates.

### Example Usage

<!-- UsageSnippet language="go" operationID="getStatusIncident" method="get" path="/api/v1/status/incidents/{incident_id}" -->
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

    res, err := s.Status.Incidents.Get(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.StatusIncident != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `incidentID`                                                        | `string`                                                            | :heavy_check_mark:                                                  | The incident id.                                                    |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetStatusIncidentResponse](../../models/operations/getstatusincidentresponse.md), error**

### Errors

| Error Type                | Status Code               | Content Type              |
| ------------------------- | ------------------------- | ------------------------- |
| apierrors.SupportAPIError | 401, 404                  | application/json          |
| apierrors.APIError        | 4XX, 5XX                  | \*/\*                     |