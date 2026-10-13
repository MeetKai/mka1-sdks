# Usage

## Overview

### Available Operations

* [Sandbox](#sandbox) - Get Sandbox Usage
* [Costs](#costs) - Aggregate cost by dimension

## Sandbox

Aggregate sandbox usage (session lifecycle, execution, and workspace operations) over a time range, bucketed and optionally grouped. Buckets are calendar-aligned in UTC: `start_time` is snapped down and `end_time` snapped up to the nearest bucket-width boundary, so the first and last buckets may extend slightly beyond the requested range. Org-scoped: callers see their own usage, org admins their team's; cluster admins may pass `all_orgs` or `org_ids`. Cost and spend reporting lives in the budgeting API (`/api/v1/budgeting/usage/costs`).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSandboxUsage" method="get" path="/api/v1/sandbox/usage" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetSandboxUsageRequest req = new GetSandboxUsageRequest() {
    StartTime = 311532,
};

var res = await sdk.Usage.SandboxAsync(req);

// handle response
```

### Parameters

| Parameter                                                                | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `request`                                                                | [GetSandboxUsageRequest](../../Types/Requests/GetSandboxUsageRequest.md) | :heavy_check_mark:                                                       | The request object to use for the request.                               |

### Response

**[GetSandboxUsageResponse](../../Types/Requests/GetSandboxUsageResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## Costs

Sums stored per-entry cost over [start_time, end_time), grouped by any of service, task_type, model, api_key_id, team_id, user_id, external_user_id, org_id. Point-in-time correct for chargeback/showback.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCosts" method="get" path="/api/v1/budgeting/usage/costs" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Usage.CostsAsync(
    startTime: 624757,
    endTime: 189930,
    groupBy: ""
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `StartTime`        | *long*             | :heavy_check_mark: | N/A                |
| `EndTime`          | *long*             | :heavy_check_mark: | N/A                |
| `GroupBy`          | *string*           | :heavy_minus_sign: | N/A                |
| `OrgId`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[GetCostsResponse](../../Types/Requests/GetCostsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |