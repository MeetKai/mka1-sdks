# Auth.Orgs

## Overview

### Available Operations

* [GetById](#getbyid) - Get basic organization details
* [Update](#update) - Patch organization metadata (cluster-admin)
* [GetQuota](#getquota) - Get an org's usage quota
* [UpdateQuota](#updatequota) - Set an org's usage quota (cluster-admin)
* [GetRateLimit](#getratelimit) - Get an org's rate limit
* [UpdateRateLimit](#updateratelimit) - Set an org's rate limit (cluster-admin)

## GetById

Returns basic fields and the full metadata object to a member of the organization or a cluster admin. It never includes member identities, invitations, or API-key details.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getOrgById" method="get" path="/api/v1/authentication/orgs/{orgId}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK();

var res = await sdk.Auth.Orgs.GetByIdAsync(
    security: new GetOrgByIdSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    orgId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `security`                                                          | [GetOrgByIdSecurity](../../Types/Requests/GetOrgByIdSecurity.md)    | :heavy_check_mark:                                                  | The security requirements to use for the request.                   |
| `OrgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetOrgByIdResponse](../../Types/Requests/GetOrgByIdResponse.md)**

### Errors

| Error Type                                                   | Status Code                                                  | Content Type                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| MeetKai.MKA1.Types.Errors.GetOrgByIdBadRequestException      | 400                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.GetOrgByIdUnauthorizedException    | 401                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.GetOrgByIdForbiddenException       | 403                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.GetOrgByIdNotFoundException        | 404                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.GetOrgByIdConflictException        | 409                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.GetOrgByIdGoneException            | 410                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.GetOrgByIdTooManyRequestsException | 429                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.GetOrgByIdInternalServerError      | 500                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.APIException                       | 4XX, 5XX                                                     | \*/\*                                                        |

## Update

Merges supplied top-level metadata keys while preserving omitted siblings. metadata.codeConfig accepts one releaseManifestUrl; codeConfig:null removes that override.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateOrganization" method="patch" path="/api/v1/authentication/orgs/{orgId}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK();

var res = await sdk.Auth.Orgs.UpdateAsync(
    security: new UpdateOrganizationSecurity() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    orgId: "<id>",
    body: new UpdateOrganizationBody() {
        Metadata = new OrganizationMetadata() {},
    }
);

// handle response
```

### Parameters

| Parameter                                                                        | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `security`                                                                       | [UpdateOrganizationSecurity](../../Types/Requests/UpdateOrganizationSecurity.md) | :heavy_check_mark:                                                               | The security requirements to use for the request.                                |
| `OrgId`                                                                          | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `Body`                                                                           | [UpdateOrganizationBody](../../Types/Components/UpdateOrganizationBody.md)       | :heavy_check_mark:                                                               | N/A                                                                              |
| `XOnBehalfOf`                                                                    | *string*                                                                         | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |

### Response

**[UpdateOrganizationResponse](../../Types/Requests/UpdateOrganizationResponse.md)**

### Errors

| Error Type                                                                 | Status Code                                                                | Content Type                                                               |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.UpdateOrganizationBadRequestException            | 400                                                                        | application/json                                                           |
| MeetKai.MKA1.Types.Errors.UpdateOrganizationUnauthorizedException          | 401                                                                        | application/json                                                           |
| MeetKai.MKA1.Types.Errors.UpdateOrganizationForbiddenException             | 403                                                                        | application/json                                                           |
| MeetKai.MKA1.Types.Errors.UpdateOrganizationNotFoundException              | 404                                                                        | application/json                                                           |
| MeetKai.MKA1.Types.Errors.UpdateOrganizationConflictException              | 409                                                                        | application/json                                                           |
| MeetKai.MKA1.Types.Errors.UpdateOrganizationGoneException                  | 410                                                                        | application/json                                                           |
| MeetKai.MKA1.Types.Errors.UpdateOrganizationRequestEntityTooLargeException | 413                                                                        | application/json                                                           |
| MeetKai.MKA1.Types.Errors.UpdateOrganizationTooManyRequestsException       | 429                                                                        | application/json                                                           |
| MeetKai.MKA1.Types.Errors.UpdateOrganizationInternalServerError            | 500                                                                        | application/json                                                           |
| MeetKai.MKA1.Types.Errors.APIException                                     | 4XX, 5XX                                                                   | \*/\*                                                                      |

## GetQuota

Get an org's usage quota

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getOrgQuota" method="get" path="/api/v1/authentication/orgs/{orgId}/quota" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Orgs.GetQuotaAsync(orgId: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `OrgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetOrgQuotaResponse](../../Types/Requests/GetOrgQuotaResponse.md)**

### Errors

| Error Type                                                    | Status Code                                                   | Content Type                                                  |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.GetOrgQuotaBadRequestException      | 400                                                           | application/json                                              |
| MeetKai.MKA1.Types.Errors.GetOrgQuotaUnauthorizedException    | 401                                                           | application/json                                              |
| MeetKai.MKA1.Types.Errors.GetOrgQuotaForbiddenException       | 403                                                           | application/json                                              |
| MeetKai.MKA1.Types.Errors.GetOrgQuotaNotFoundException        | 404                                                           | application/json                                              |
| MeetKai.MKA1.Types.Errors.GetOrgQuotaConflictException        | 409                                                           | application/json                                              |
| MeetKai.MKA1.Types.Errors.GetOrgQuotaGoneException            | 410                                                           | application/json                                              |
| MeetKai.MKA1.Types.Errors.GetOrgQuotaTooManyRequestsException | 429                                                           | application/json                                              |
| MeetKai.MKA1.Types.Errors.APIException                        | 4XX, 5XX                                                      | \*/\*                                                         |

## UpdateQuota

Set an org's usage quota (cluster-admin)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateOrgQuota" method="patch" path="/api/v1/authentication/orgs/{orgId}/quota" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Orgs.UpdateQuotaAsync(orgId: "<id>");

// handle response
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `OrgId`                                                                        | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `XOnBehalfOf`                                                                  | *string*                                                                       | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |
| `Body`                                                                         | [UpdateOrgQuotaRequestBody](../../Types/Requests/UpdateOrgQuotaRequestBody.md) | :heavy_minus_sign:                                                             | N/A                                                                            |

### Response

**[UpdateOrgQuotaResponse](../../Types/Requests/UpdateOrgQuotaResponse.md)**

### Errors

| Error Type                                                       | Status Code                                                      | Content Type                                                     |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.UpdateOrgQuotaBadRequestException      | 400                                                              | application/json                                                 |
| MeetKai.MKA1.Types.Errors.UpdateOrgQuotaUnauthorizedException    | 401                                                              | application/json                                                 |
| MeetKai.MKA1.Types.Errors.UpdateOrgQuotaForbiddenException       | 403                                                              | application/json                                                 |
| MeetKai.MKA1.Types.Errors.UpdateOrgQuotaNotFoundException        | 404                                                              | application/json                                                 |
| MeetKai.MKA1.Types.Errors.UpdateOrgQuotaConflictException        | 409                                                              | application/json                                                 |
| MeetKai.MKA1.Types.Errors.UpdateOrgQuotaGoneException            | 410                                                              | application/json                                                 |
| MeetKai.MKA1.Types.Errors.UpdateOrgQuotaTooManyRequestsException | 429                                                              | application/json                                                 |
| MeetKai.MKA1.Types.Errors.APIException                           | 4XX, 5XX                                                         | \*/\*                                                            |

## GetRateLimit

Get an org's rate limit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getOrgRateLimit" method="get" path="/api/v1/authentication/orgs/{orgId}/rate-limit" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Orgs.GetRateLimitAsync(orgId: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `OrgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetOrgRateLimitResponse](../../Types/Requests/GetOrgRateLimitResponse.md)**

### Errors

| Error Type                                                        | Status Code                                                       | Content Type                                                      |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.GetOrgRateLimitBadRequestException      | 400                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.GetOrgRateLimitUnauthorizedException    | 401                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.GetOrgRateLimitForbiddenException       | 403                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.GetOrgRateLimitNotFoundException        | 404                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.GetOrgRateLimitConflictException        | 409                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.GetOrgRateLimitGoneException            | 410                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.GetOrgRateLimitTooManyRequestsException | 429                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.APIException                            | 4XX, 5XX                                                          | \*/\*                                                             |

## UpdateRateLimit

Set an org's rate limit (cluster-admin)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateOrgRateLimit" method="patch" path="/api/v1/authentication/orgs/{orgId}/rate-limit" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Orgs.UpdateRateLimitAsync(orgId: "<id>");

// handle response
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `OrgId`                                                                                | *string*                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `XOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `Body`                                                                                 | [UpdateOrgRateLimitRequestBody](../../Types/Requests/UpdateOrgRateLimitRequestBody.md) | :heavy_minus_sign:                                                                     | N/A                                                                                    |

### Response

**[UpdateOrgRateLimitResponse](../../Types/Requests/UpdateOrgRateLimitResponse.md)**

### Errors

| Error Type                                                           | Status Code                                                          | Content Type                                                         |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.UpdateOrgRateLimitBadRequestException      | 400                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.UpdateOrgRateLimitUnauthorizedException    | 401                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.UpdateOrgRateLimitForbiddenException       | 403                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.UpdateOrgRateLimitNotFoundException        | 404                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.UpdateOrgRateLimitConflictException        | 409                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.UpdateOrgRateLimitGoneException            | 410                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.UpdateOrgRateLimitTooManyRequestsException | 429                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.APIException                               | 4XX, 5XX                                                             | \*/\*                                                                |