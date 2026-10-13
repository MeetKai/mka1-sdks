# Usage

## Overview

### Available Operations

* [sandbox](#sandbox) - Get Sandbox Usage
* [costs](#costs) - Aggregate cost by dimension

## sandbox

Aggregate sandbox usage (session lifecycle, execution, and workspace operations) over a time range, bucketed and optionally grouped. Buckets are calendar-aligned in UTC: `start_time` is snapped down and `end_time` snapped up to the nearest bucket-width boundary, so the first and last buckets may extend slightly beyond the requested range. Org-scoped: callers see their own usage, org admins their team's; cluster admins may pass `all_orgs` or `org_ids`. Cost and spend reporting lives in the budgeting API (`/api/v1/budgeting/usage/costs`).

### Example Usage

<!-- UsageSnippet language="python" operationID="getSandboxUsage" method="get" path="/api/v1/sandbox/usage" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.usage.sandbox(start_time=311532, all_orgs=False)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `start_time`                                                                        | *int*                                                                               | :heavy_check_mark:                                                                  | Start time as Unix seconds, inclusive                                               |
| `end_time`                                                                          | *OptionalNullable[int]*                                                             | :heavy_minus_sign:                                                                  | End time as Unix seconds, exclusive. Defaults to now.                               |
| `bucket_width`                                                                      | [Optional[models.SandboxUsageBucketWidth]](../../models/sandboxusagebucketwidth.md) | :heavy_minus_sign:                                                                  | Time bucket width.                                                                  |
| `group_by`                                                                          | List[*str*]                                                                         | :heavy_minus_sign:                                                                  | Repeat or comma-separate grouping dimensions.                                       |
| `all_orgs`                                                                          | *Optional[bool]*                                                                    | :heavy_minus_sign:                                                                  | Aggregate usage across all organizations (cluster admins only).                     |
| `org_ids`                                                                           | List[*str*]                                                                         | :heavy_minus_sign:                                                                  | Filter by organization IDs (cluster admins only, implies cluster scope).            |
| `x_on_behalf_of`                                                                    | *Optional[str]*                                                                     | :heavy_minus_sign:                                                                  | Optional external end-user identifier forwarded by the API gateway.                 |
| `retries`                                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                    | :heavy_minus_sign:                                                                  | Configuration to override the default retry behavior of the client.                 |

### Response

**[models.SandboxUsagePage](../../models/sandboxusagepage.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## costs

Sums stored per-entry cost over [start_time, end_time), grouped by any of service, task_type, model, api_key_id, team_id, user_id, external_user_id, org_id. Point-in-time correct for chargeback/showback.

### Example Usage

<!-- UsageSnippet language="python" operationID="getCosts" method="get" path="/api/v1/budgeting/usage/costs" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.usage.costs(start_time=624757, end_time=189930, group_by="")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `start_time`                                                        | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `end_time`                                                          | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `group_by`                                                          | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetCostsResponse](../../models/getcostsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |