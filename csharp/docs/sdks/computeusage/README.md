# ComputeUsage

## Overview

### Available Operations

* [GetComputeUsage](#getcomputeusage) - Get usage

## GetComputeUsage

Get usage

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeUsage" method="get" path="/api/v1/compute/usage" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetComputeUsageRequest req = new GetComputeUsageRequest() {};

var res = await sdk.ComputeUsage.GetComputeUsageAsync(req);

// handle response
```

### Parameters

| Parameter                                                                | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `request`                                                                | [GetComputeUsageRequest](../../Types/Requests/GetComputeUsageRequest.md) | :heavy_check_mark:                                                       | The request object to use for the request.                               |

### Response

**[GetComputeUsageResponse](../../Types/Requests/GetComputeUsageResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |