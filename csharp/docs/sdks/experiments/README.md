# Tracking.Experiments

## Overview

### Available Operations

* [Create](#create) - Create
* [Search](#search) - Search
* [Get](#get) - Get
* [GetByName](#getbyname) - GetByName
* [Delete](#delete) - Delete

## Create

Create a namespaced experiment. Artifact locations are managed by the service. Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingExperimentsCreate" method="post" path="/api/2.0/mlflow/experiments/create" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Tracking.Experiments.CreateAsync(body: new TrackingExperimentsCreateRequestBody() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `Body`                                                                                               | [TrackingExperimentsCreateRequestBody](../../Types/Requests/TrackingExperimentsCreateRequestBody.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `XOnBehalfOf`                                                                                        | *string*                                                                                             | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |

### Response

**[TrackingExperimentsCreateResponse](../../Types/Requests/TrackingExperimentsCreateResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Search

 Requires `read:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingExperimentsSearch" method="post" path="/api/2.0/mlflow/experiments/search" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Tracking.Experiments.SearchAsync(body: new TrackingExperimentsSearchRequestBody() {});

// handle response
```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `Body`                                                                                               | [TrackingExperimentsSearchRequestBody](../../Types/Requests/TrackingExperimentsSearchRequestBody.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `XOnBehalfOf`                                                                                        | *string*                                                                                             | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |

### Response

**[TrackingExperimentsSearchResponse](../../Types/Requests/TrackingExperimentsSearchResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Get

 Requires `read:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingExperimentsGet" method="get" path="/api/2.0/mlflow/experiments/get" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Tracking.Experiments.GetAsync(experimentId: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ExperimentId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[TrackingExperimentsGetResponse](../../Types/Requests/TrackingExperimentsGetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetByName

 Requires `read:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingExperimentsGetByName" method="get" path="/api/2.0/mlflow/experiments/get-by-name" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Tracking.Experiments.GetByNameAsync(experimentName: "<value>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ExperimentName`                                                    | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[TrackingExperimentsGetByNameResponse](../../Types/Requests/TrackingExperimentsGetByNameResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Delete

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="trackingExperimentsDelete" method="post" path="/api/2.0/mlflow/experiments/delete" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Tracking.Experiments.DeleteAsync(body: new TrackingExperimentsDeleteRequestBody() {
    ExperimentId = "<id>",
});

// handle response
```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `Body`                                                                                               | [TrackingExperimentsDeleteRequestBody](../../Types/Requests/TrackingExperimentsDeleteRequestBody.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `XOnBehalfOf`                                                                                        | *string*                                                                                             | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |

### Response

**[TrackingExperimentsDeleteResponse](../../Types/Requests/TrackingExperimentsDeleteResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |