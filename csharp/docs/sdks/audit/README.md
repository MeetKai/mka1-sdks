# Flags.Audit

## Overview

### Available Operations

* [List](#list) - List audit entries, newest first

## List

List audit entries, newest first

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listFeatureFlagAuditEntries" method="get" path="/api/v1/flags/audit" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.Audit.ListAsync(limit: 50);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Limit`                                                             | *long*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 |
| `Before`                                                            | *long*                                                              | :heavy_minus_sign:                                                  | Return entries with an id lower than this (from next_before).       |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListFeatureFlagAuditEntriesResponse](../../Types/Requests/ListFeatureFlagAuditEntriesResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 400, 401, 403                              | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |