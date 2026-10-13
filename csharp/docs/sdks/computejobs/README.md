# ComputeJobs

## Overview

### Available Operations

* [ListJobs](#listjobs) - List jobs
* [CreateJob](#createjob) - Create a job
* [GetJob](#getjob) - Get a job
* [ListJobEvents](#listjobevents) - List job events
* [ListJobInstances](#listjobinstances) - List observed job instances
* [ListJobLogs](#listjoblogs) - List job logs
* [TerminateJob](#terminatejob) - Terminate a job

## ListJobs

List jobs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listJobs" method="get" path="/api/v1/compute/jobs" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeJobs.ListJobsAsync(limit: 50);

// handle response
```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `State`                                                                | [ComputeResourceState](../../Types/Components/ComputeResourceState.md) | :heavy_minus_sign:                                                     | N/A                                                                    |
| `Cursor`                                                               | *string*                                                               | :heavy_minus_sign:                                                     | N/A                                                                    |
| `Limit`                                                                | *long*                                                                 | :heavy_minus_sign:                                                     | N/A                                                                    |
| `XOnBehalfOf`                                                          | *string*                                                               | :heavy_minus_sign:                                                     | Optional external end-user identifier forwarded by the API gateway.    |

### Response

**[ListJobsResponse](../../Types/Requests/ListJobsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateJob

Create a job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createJob" method="post" path="/api/v1/compute/jobs" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeJobs.CreateJobAsync(
    idempotencyKey: "<value>",
    body: new ComputeJobCreate() {
        Compute = new ComputeRequest() {
            Accelerator = "<value>",
            EphemeralDiskGb = 166801,
            GpuCount = 580753,
        },
        Container = ComputeContainerCreateUnion.CreateComputeContainerCreate2(
            new ComputeContainerCreate2() {
                Image = "https://picsum.photos/seed/vABc84qaab/2231/967",
                ScriptB64 = "<value>",
            }
        ),
    }
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `IdempotencyKey`                                                    | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `Body`                                                              | [ComputeJobCreate](../../Types/Components/ComputeJobCreate.md)      | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[CreateJobResponse](../../Types/Requests/CreateJobResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetJob

Get a job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getJob" method="get" path="/api/v1/compute/jobs/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeJobs.GetJobAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetJobResponse](../../Types/Requests/GetJobResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListJobEvents

List job events

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listJobEvents" method="get" path="/api/v1/compute/jobs/{id}/events" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListJobEventsRequest req = new ListJobEventsRequest() {
    Id = "<id>",
};

var res = await sdk.ComputeJobs.ListJobEventsAsync(req);

// handle response
```

### Parameters

| Parameter                                                            | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `request`                                                            | [ListJobEventsRequest](../../Types/Requests/ListJobEventsRequest.md) | :heavy_check_mark:                                                   | The request object to use for the request.                           |

### Response

**[ListJobEventsResponse](../../Types/Requests/ListJobEventsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListJobInstances

List observed job instances

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listJobInstances" method="get" path="/api/v1/compute/jobs/{id}/instances" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListJobInstancesRequest req = new ListJobInstancesRequest() {
    Id = "<id>",
};

var res = await sdk.ComputeJobs.ListJobInstancesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `request`                                                                  | [ListJobInstancesRequest](../../Types/Requests/ListJobInstancesRequest.md) | :heavy_check_mark:                                                         | The request object to use for the request.                                 |

### Response

**[ListJobInstancesResponse](../../Types/Requests/ListJobInstancesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListJobLogs

List job logs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listJobLogs" method="get" path="/api/v1/compute/jobs/{id}/logs" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListJobLogsRequest req = new ListJobLogsRequest() {
    Id = "<id>",
};

var res = await sdk.ComputeJobs.ListJobLogsAsync(req);

// handle response
```

### Parameters

| Parameter                                                        | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `request`                                                        | [ListJobLogsRequest](../../Types/Requests/ListJobLogsRequest.md) | :heavy_check_mark:                                               | The request object to use for the request.                       |

### Response

**[ListJobLogsResponse](../../Types/Requests/ListJobLogsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## TerminateJob

Terminate a job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="terminateJob" method="post" path="/api/v1/compute/jobs/{id}/terminate" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeJobs.TerminateJobAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[TerminateJobResponse](../../Types/Requests/TerminateJobResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |