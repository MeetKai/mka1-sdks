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

<!-- UsageSnippet language="csharp" operationID="listServices" method="get" path="/api/v1/compute/services" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeServices.ListServicesAsync(limit: 50);

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

**[ListServicesResponse](../../Types/Requests/ListServicesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateService

Create a service

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createService" method="post" path="/api/v1/compute/services" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeServices.CreateServiceAsync(
    idempotencyKey: "<value>",
    body: new ComputeResourceCreate() {
        Compute = new ComputeRequest() {
            Accelerator = "<value>",
            EphemeralDiskGb = 709572,
            GpuCount = 103964,
        },
        Container = ComputeContainerCreateUnion.CreateComputeContainerCreate2(
            new ComputeContainerCreate2() {
                Image = "https://loremflickr.com/676/3598?lock=35726374653792",
                ScriptB64 = "<value>",
            }
        ),
    }
);

// handle response
```

### Parameters

| Parameter                                                                | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `IdempotencyKey`                                                         | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `Body`                                                                   | [ComputeResourceCreate](../../Types/Components/ComputeResourceCreate.md) | :heavy_check_mark:                                                       | N/A                                                                      |
| `XOnBehalfOf`                                                            | *string*                                                                 | :heavy_minus_sign:                                                       | Optional external end-user identifier forwarded by the API gateway.      |

### Response

**[CreateServiceResponse](../../Types/Requests/CreateServiceResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetService

Get a service

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getService" method="get" path="/api/v1/compute/services/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeServices.GetServiceAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetServiceResponse](../../Types/Requests/GetServiceResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListServiceEvents

List service events

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listServiceEvents" method="get" path="/api/v1/compute/services/{id}/events" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListServiceEventsRequest req = new ListServiceEventsRequest() {
    Id = "<id>",
};

var res = await sdk.ComputeServices.ListServiceEventsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `request`                                                                    | [ListServiceEventsRequest](../../Types/Requests/ListServiceEventsRequest.md) | :heavy_check_mark:                                                           | The request object to use for the request.                                   |

### Response

**[ListServiceEventsResponse](../../Types/Requests/ListServiceEventsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListServiceInstances

List observed service instances

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listServiceInstances" method="get" path="/api/v1/compute/services/{id}/instances" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListServiceInstancesRequest req = new ListServiceInstancesRequest() {
    Id = "<id>",
};

var res = await sdk.ComputeServices.ListServiceInstancesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `request`                                                                          | [ListServiceInstancesRequest](../../Types/Requests/ListServiceInstancesRequest.md) | :heavy_check_mark:                                                                 | The request object to use for the request.                                         |

### Response

**[ListServiceInstancesResponse](../../Types/Requests/ListServiceInstancesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListServiceLogs

List service logs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listServiceLogs" method="get" path="/api/v1/compute/services/{id}/logs" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListServiceLogsRequest req = new ListServiceLogsRequest() {
    Id = "<id>",
};

var res = await sdk.ComputeServices.ListServiceLogsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `request`                                                                | [ListServiceLogsRequest](../../Types/Requests/ListServiceLogsRequest.md) | :heavy_check_mark:                                                       | The request object to use for the request.                               |

### Response

**[ListServiceLogsResponse](../../Types/Requests/ListServiceLogsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## UpdateServiceScaling

Replace a service scaling policy

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateServiceScaling" method="patch" path="/api/v1/compute/services/{id}/scaling" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

UpdateServiceScalingRequest req = new UpdateServiceScalingRequest() {
    Id = "<id>",
    IdempotencyKey = "<value>",
    Body = new ComputeScalingInput() {
        MaxReplicas = 693036,
        MinReplicas = 178601,
    },
};

var res = await sdk.ComputeServices.UpdateServiceScalingAsync(req);

// handle response
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `request`                                                                          | [UpdateServiceScalingRequest](../../Types/Requests/UpdateServiceScalingRequest.md) | :heavy_check_mark:                                                                 | The request object to use for the request.                                         |

### Response

**[UpdateServiceScalingResponse](../../Types/Requests/UpdateServiceScalingResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## TerminateService

Terminate a service

### Example Usage

<!-- UsageSnippet language="csharp" operationID="terminateService" method="post" path="/api/v1/compute/services/{id}/terminate" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeServices.TerminateServiceAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[TerminateServiceResponse](../../Types/Requests/TerminateServiceResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |