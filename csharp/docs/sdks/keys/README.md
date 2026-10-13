# Analytics.Keys

## Overview

Create and revoke project keys for sending events.

### Available Operations

* [Create](#create) - Create a capture key and return its secret once
* [List](#list) - List capture key metadata
* [Revoke](#revoke) - Revoke a capture key

## Create

Create a key that can send events to this project. Save the key from this response; its secret is only returned once. Capture keys cannot read analytics or manage projects.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="analytics_keys_create" method="post" path="/api/v1/analytics/projects/{id}/keys" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Analytics.Keys.CreateAsync(
    id: "<id>",
    body: new AnalyticsKeyCreate() {
        Name = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                          | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `Id`                                                               | *string*                                                           | :heavy_check_mark:                                                 | ID of the analytics project.                                       |
| `Body`                                                             | [AnalyticsKeyCreate](../../Types/Components/AnalyticsKeyCreate.md) | :heavy_check_mark:                                                 | N/A                                                                |

### Response

**[AnalyticsKeysCreateResponse](../../Types/Requests/AnalyticsKeysCreateResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 400, 401, 403, 404, 409, 413, 415, 429   | application/json                         |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 500, 503                                 | application/json                         |
| MeetKai.MKA1.Types.Errors.APIException   | 4XX, 5XX                                 | \*/\*                                    |

## List

List capture key metadata

### Example Usage

<!-- UsageSnippet language="csharp" operationID="analytics_keys_list" method="get" path="/api/v1/analytics/projects/{id}/keys" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Analytics.Keys.ListAsync(
    id: "<id>",
    limit: 50
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `Id`                         | *string*                     | :heavy_check_mark:           | ID of the analytics project. |
| `Limit`                      | *long*                       | :heavy_minus_sign:           | N/A                          |
| `After`                      | *string*                     | :heavy_minus_sign:           | N/A                          |

### Response

**[AnalyticsKeysListResponse](../../Types/Requests/AnalyticsKeysListResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 400, 401, 403, 404, 409, 413, 415, 429   | application/json                         |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 500, 503                                 | application/json                         |
| MeetKai.MKA1.Types.Errors.APIException   | 4XX, 5XX                                 | \*/\*                                    |

## Revoke

Revoke a capture key

### Example Usage

<!-- UsageSnippet language="csharp" operationID="analytics_keys_revoke" method="delete" path="/api/v1/analytics/projects/{id}/keys/{keyId}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Analytics.Keys.RevokeAsync(
    id: "<id>",
    keyId: "<id>"
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `Id`                         | *string*                     | :heavy_check_mark:           | ID of the analytics project. |
| `KeyId`                      | *string*                     | :heavy_check_mark:           | N/A                          |

### Response

**[AnalyticsKeysRevokeResponse](../../Types/Requests/AnalyticsKeysRevokeResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 400, 401, 403, 404, 409, 413, 415, 429   | application/json                         |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 500, 503                                 | application/json                         |
| MeetKai.MKA1.Types.Errors.APIException   | 4XX, 5XX                                 | \*/\*                                    |