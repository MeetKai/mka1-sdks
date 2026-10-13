# ComputeTenants

## Overview

### Available Operations

* [ListComputeTenants](#listcomputetenants) - List tenants
* [GetComputeTenant](#getcomputetenant) - Get a tenant
* [PutComputeTenant](#putcomputetenant) - Update a tenant

## ListComputeTenants

Cluster-administrator-only.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeTenants" method="get" path="/api/v1/compute/tenants" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeTenants.ListComputeTenantsAsync(limit: 50);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Enabled`                                                           | *bool*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 |
| `Cursor`                                                            | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `Limit`                                                             | *long*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListComputeTenantsResponse](../../Types/Requests/ListComputeTenantsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetComputeTenant

Cluster-administrator-only.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeTenant" method="get" path="/api/v1/compute/tenants/{org_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeTenants.GetComputeTenantAsync(orgId: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `OrgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetComputeTenantResponse](../../Types/Requests/GetComputeTenantResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## PutComputeTenant

Cluster-administrator-only idempotent upsert.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="putComputeTenant" method="put" path="/api/v1/compute/tenants/{org_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeTenants.PutComputeTenantAsync(
    orgId: "<id>",
    body: new ComputeTenantUpdate() {}
);

// handle response
```

### Parameters

| Parameter                                                            | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `OrgId`                                                              | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `Body`                                                               | [ComputeTenantUpdate](../../Types/Components/ComputeTenantUpdate.md) | :heavy_check_mark:                                                   | N/A                                                                  |
| `XOnBehalfOf`                                                        | *string*                                                             | :heavy_minus_sign:                                                   | Optional external end-user identifier forwarded by the API gateway.  |

### Response

**[PutComputeTenantResponse](../../Types/Requests/PutComputeTenantResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |