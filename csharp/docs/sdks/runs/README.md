# Tracking.Runs

## Overview

### Available Operations

* [Create](#create) - Create
* [Get](#get) - Get
* [Search](#search) - Search
* [Update](#update) - Update
* [Delete](#delete) - Delete
* [Restore](#restore) - Restore
* [LogMetric](#logmetric) - LogMetric
* [LogParameter](#logparameter) - LogParameter
* [SetTag](#settag) - SetTag
* [DeleteTag](#deletetag) - DeleteTag
* [LogBatch](#logbatch) - LogBatch
* [LogInputs](#loginputs) - LogInputs
* [GetMetricHistory](#getmetrichistory) - GetMetricHistory

## Create

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingRunsCreate" method="post" path="/api/2.0/mlflow/runs/create" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Tracking.Runs.CreateAsync(body: new TrackingRunsCreateRequestBody() {
    ExperimentId = "<id>",
});

// handle response
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `Body`                                                                                 | [TrackingRunsCreateRequestBody](../../Types/Requests/TrackingRunsCreateRequestBody.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `XOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |

### Response

**[TrackingRunsCreateResponse](../../Types/Requests/TrackingRunsCreateResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Get

 Requires `read:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingRunsGet" method="get" path="/api/2.0/mlflow/runs/get" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Tracking.Runs.GetAsync(runId: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `RunId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[TrackingRunsGetResponse](../../Types/Requests/TrackingRunsGetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Search

Explicit experiment IDs are required; every experiment must belong to the caller. Requires `read:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingRunsSearch" method="post" path="/api/2.0/mlflow/runs/search" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Tracking.Runs.SearchAsync(body: new TrackingRunsSearchRequestBody() {
    ExperimentIds = new List<string>() {
        "<value 1>",
    },
});

// handle response
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `Body`                                                                                 | [TrackingRunsSearchRequestBody](../../Types/Requests/TrackingRunsSearchRequestBody.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `XOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |

### Response

**[TrackingRunsSearchResponse](../../Types/Requests/TrackingRunsSearchResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Update

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingRunsUpdate" method="post" path="/api/2.0/mlflow/runs/update" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Tracking.Runs.UpdateAsync(body: new TrackingRunsUpdateRequestBody() {
    RunId = "<id>",
});

// handle response
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `Body`                                                                                 | [TrackingRunsUpdateRequestBody](../../Types/Requests/TrackingRunsUpdateRequestBody.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `XOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |

### Response

**[TrackingRunsUpdateResponse](../../Types/Requests/TrackingRunsUpdateResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Delete

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingRunsDelete" method="post" path="/api/2.0/mlflow/runs/delete" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Tracking.Runs.DeleteAsync(body: new TrackingRunsDeleteRequestBody() {
    RunId = "<id>",
});

// handle response
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `Body`                                                                                 | [TrackingRunsDeleteRequestBody](../../Types/Requests/TrackingRunsDeleteRequestBody.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `XOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |

### Response

**[TrackingRunsDeleteResponse](../../Types/Requests/TrackingRunsDeleteResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Restore

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingRunsRestore" method="post" path="/api/2.0/mlflow/runs/restore" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Tracking.Runs.RestoreAsync(body: new TrackingRunsRestoreRequestBody() {
    RunId = "<id>",
});

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `Body`                                                                                   | [TrackingRunsRestoreRequestBody](../../Types/Requests/TrackingRunsRestoreRequestBody.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `XOnBehalfOf`                                                                            | *string*                                                                                 | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |

### Response

**[TrackingRunsRestoreResponse](../../Types/Requests/TrackingRunsRestoreResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## LogMetric

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingRunsLogMetric" method="post" path="/api/2.0/mlflow/runs/log-metric" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Tracking.Runs.LogMetricAsync(body: new TrackingRunsLogMetricRequestBody() {
    RunId = "<id>",
    Key = "<key>",
    Value = 1403.55D,
    Timestamp = 778356,
});

// handle response
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `Body`                                                                                       | [TrackingRunsLogMetricRequestBody](../../Types/Requests/TrackingRunsLogMetricRequestBody.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `XOnBehalfOf`                                                                                | *string*                                                                                     | :heavy_minus_sign:                                                                           | Optional external end-user identifier forwarded by the API gateway.                          |

### Response

**[TrackingRunsLogMetricResponse](../../Types/Requests/TrackingRunsLogMetricResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## LogParameter

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingRunsLogParameter" method="post" path="/api/2.0/mlflow/runs/log-parameter" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Tracking.Runs.LogParameterAsync(body: new TrackingRunsLogParameterRequestBody() {
    RunId = "<id>",
    Key = "<key>",
    Value = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `Body`                                                                                             | [TrackingRunsLogParameterRequestBody](../../Types/Requests/TrackingRunsLogParameterRequestBody.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `XOnBehalfOf`                                                                                      | *string*                                                                                           | :heavy_minus_sign:                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                |

### Response

**[TrackingRunsLogParameterResponse](../../Types/Requests/TrackingRunsLogParameterResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## SetTag

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingRunsSetTag" method="post" path="/api/2.0/mlflow/runs/set-tag" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Tracking.Runs.SetTagAsync(body: new TrackingRunsSetTagRequestBody() {
    RunId = "<id>",
    Key = "<key>",
    Value = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `Body`                                                                                 | [TrackingRunsSetTagRequestBody](../../Types/Requests/TrackingRunsSetTagRequestBody.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `XOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |

### Response

**[TrackingRunsSetTagResponse](../../Types/Requests/TrackingRunsSetTagResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteTag

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingRunsDeleteTag" method="post" path="/api/2.0/mlflow/runs/delete-tag" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Tracking.Runs.DeleteTagAsync(body: new TrackingRunsDeleteTagRequestBody() {
    RunId = "<id>",
    Key = "<key>",
});

// handle response
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `Body`                                                                                       | [TrackingRunsDeleteTagRequestBody](../../Types/Requests/TrackingRunsDeleteTagRequestBody.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `XOnBehalfOf`                                                                                | *string*                                                                                     | :heavy_minus_sign:                                                                           | Optional external end-user identifier forwarded by the API gateway.                          |

### Response

**[TrackingRunsDeleteTagResponse](../../Types/Requests/TrackingRunsDeleteTagResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## LogBatch

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingRunsLogBatch" method="post" path="/api/2.0/mlflow/runs/log-batch" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Tracking.Runs.LogBatchAsync(body: new TrackingRunsLogBatchRequestBody() {
    RunId = "<id>",
});

// handle response
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `Body`                                                                                     | [TrackingRunsLogBatchRequestBody](../../Types/Requests/TrackingRunsLogBatchRequestBody.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `XOnBehalfOf`                                                                              | *string*                                                                                   | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |

### Response

**[TrackingRunsLogBatchResponse](../../Types/Requests/TrackingRunsLogBatchResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## LogInputs

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingRunsLogInputs" method="post" path="/api/2.0/mlflow/runs/log-inputs" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Tracking.Runs.LogInputsAsync(body: new TrackingRunsLogInputsRequestBody() {
    RunId = "<id>",
    Datasets = new List<DatasetInput>() {
        new DatasetInput() {
            Dataset = new Dataset() {
                Name = "<value>",
                Digest = "<value>",
                SourceType = "<value>",
                Source = "<value>",
            },
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `Body`                                                                                       | [TrackingRunsLogInputsRequestBody](../../Types/Requests/TrackingRunsLogInputsRequestBody.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `XOnBehalfOf`                                                                                | *string*                                                                                     | :heavy_minus_sign:                                                                           | Optional external end-user identifier forwarded by the API gateway.                          |

### Response

**[TrackingRunsLogInputsResponse](../../Types/Requests/TrackingRunsLogInputsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetMetricHistory

 Requires `read:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingRunsGetMetricHistory" method="get" path="/api/2.0/mlflow/metrics/get-history" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

TrackingRunsGetMetricHistoryRequest req = new TrackingRunsGetMetricHistoryRequest() {
    RunId = "<id>",
    MetricKey = "<value>",
};

var res = await sdk.Tracking.Runs.GetMetricHistoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `request`                                                                                          | [TrackingRunsGetMetricHistoryRequest](../../Types/Requests/TrackingRunsGetMetricHistoryRequest.md) | :heavy_check_mark:                                                                                 | The request object to use for the request.                                                         |

### Response

**[TrackingRunsGetMetricHistoryResponse](../../Types/Requests/TrackingRunsGetMetricHistoryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |