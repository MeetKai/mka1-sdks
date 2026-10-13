# Flags

## Overview

### Available Operations

* [List](#list) - List flags
* [Create](#create) - Create a flag
* [Delete](#delete) - Delete a flag and its settings in every environment
* [Get](#get) - Get a flag
* [Update](#update) - Update a flag's name, description, default value, or project
* [Archive](#archive) - Archive a flag
* [SetEnvironmentState](#setenvironmentstate) - Replace a flag's settings in one environment
* [Unarchive](#unarchive) - Restore an archived flag

## List

Every flag with a per-environment digest of its state.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listFeatureFlags" method="get" path="/api/v1/flags" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.ListAsync(includeArchived: false);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `IncludeArchived`                                                             | *bool*                                                                        | :heavy_minus_sign:                                                            | N/A                                                                           |
| `ProjectId`                                                                   | *string*                                                                      | :heavy_minus_sign:                                                            | Return only flags assigned to this project. Flag keys remain globally unique. |
| `XOnBehalfOf`                                                                 | *string*                                                                      | :heavy_minus_sign:                                                            | Optional external end-user identifier forwarded by the API gateway.           |

### Response

**[ListFeatureFlagsResponse](../../Types/Requests/ListFeatureFlagsResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 400, 401, 403, 404                         | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## Create

The flag starts disabled in every environment and belongs to Default when project_id is omitted.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createFeatureFlag" method="post" path="/api/v1/flags" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.CreateAsync(body: new FeatureFlagCreateRequest() {
    DefaultValue = "<value>",
    Key = "<key>",
    Name = "<value>",
    ValueType = FeatureFlagValueType.Boolean,
});

// handle response
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `Body`                                                                         | [FeatureFlagCreateRequest](../../Types/Components/FeatureFlagCreateRequest.md) | :heavy_check_mark:                                                             | N/A                                                                            |
| `XOnBehalfOf`                                                                  | *string*                                                                       | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |

### Response

**[CreateFeatureFlagResponse](../../Types/Requests/CreateFeatureFlagResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 400, 401, 403, 404, 409                    | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## Delete

Delete a flag and its settings in every environment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteFeatureFlag" method="delete" path="/api/v1/flags/{key}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.DeleteAsync(key: "<key>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Key`                                                               | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[DeleteFeatureFlagResponse](../../Types/Requests/DeleteFeatureFlagResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 401, 403, 404                              | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## Get

Get a flag

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getFeatureFlag" method="get" path="/api/v1/flags/{key}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.GetAsync(key: "<key>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Key`                                                               | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetFeatureFlagResponse](../../Types/Requests/GetFeatureFlagResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 401, 403, 404                              | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## Update

Update a flag's name, description, default value, or project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateFeatureFlag" method="patch" path="/api/v1/flags/{key}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.UpdateAsync(
    key: "<key>",
    body: new FeatureFlagUpdateRequest() {}
);

// handle response
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `Key`                                                                          | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `Body`                                                                         | [FeatureFlagUpdateRequest](../../Types/Components/FeatureFlagUpdateRequest.md) | :heavy_check_mark:                                                             | N/A                                                                            |
| `XOnBehalfOf`                                                                  | *string*                                                                       | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |

### Response

**[UpdateFeatureFlagResponse](../../Types/Requests/UpdateFeatureFlagResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 400, 401, 403, 404                         | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## Archive

Archived flags are excluded from evaluation in every environment; their settings are kept.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="archiveFeatureFlag" method="post" path="/api/v1/flags/{key}/archive" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.ArchiveAsync(key: "<key>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Key`                                                               | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ArchiveFeatureFlagResponse](../../Types/Requests/ArchiveFeatureFlagResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 401, 403, 404                              | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## SetEnvironmentState

Replace a flag's settings in one environment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setFeatureFlagEnvironmentState" method="put" path="/api/v1/flags/{key}/environments/{env}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

SetFeatureFlagEnvironmentStateRequest req = new SetFeatureFlagEnvironmentStateRequest() {
    Key = "<key>",
    Env = "<value>",
    Body = new FeatureFlagStateInput() {
        Enabled = true,
        Overrides = new List<FeatureFlagOverride>() {
            new FeatureFlagOverride() {
                Enabled = true,
                Identity = "<value>",
            },
        },
        RolloutPercentage = 29814,
        Rules = new List<FeatureFlagRule>() {
            new FeatureFlagRule() {
                Conditions = new List<FeatureFlagCondition>() {},
                Enabled = false,
            },
        },
        Value = "<value>",
    },
};

var res = await sdk.Flags.SetEnvironmentStateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                              | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `request`                                                                                              | [SetFeatureFlagEnvironmentStateRequest](../../Types/Requests/SetFeatureFlagEnvironmentStateRequest.md) | :heavy_check_mark:                                                                                     | The request object to use for the request.                                                             |

### Response

**[SetFeatureFlagEnvironmentStateResponse](../../Types/Requests/SetFeatureFlagEnvironmentStateResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 400, 401, 403, 404, 409, 412               | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## Unarchive

Restore an archived flag

### Example Usage

<!-- UsageSnippet language="csharp" operationID="unarchiveFeatureFlag" method="post" path="/api/v1/flags/{key}/unarchive" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.UnarchiveAsync(key: "<key>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Key`                                                               | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[UnarchiveFeatureFlagResponse](../../Types/Requests/UnarchiveFeatureFlagResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 401, 403, 404                              | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |