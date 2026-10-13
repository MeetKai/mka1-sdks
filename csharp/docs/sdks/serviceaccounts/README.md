# Auth.ServiceAccounts

## Overview

### Available Operations

* [Create](#create) - Create a service account
* [List](#list) - List service accounts
* [Get](#get) - Get a service account
* [Delete](#delete) - Delete a service account
* [ListApiKeys](#listapikeys) - List a service account's API keys
* [UpdateApiKey](#updateapikey) - Update a service-account API key
* [DeleteApiKey](#deleteapikey) - Delete a service-account API key
* [RegenerateApiKey](#regenerateapikey) - Rotate a service-account API key's secret

## Create

Mint a non-human principal scoped to this org (org owner/admin only).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createServiceAccount" method="post" path="/api/v1/authentication/orgs/{orgId}/service-accounts" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.ServiceAccounts.CreateAsync(orgId: "<id>");

// handle response
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `OrgId`                                                                                    | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `XOnBehalfOf`                                                                              | *string*                                                                                   | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |
| `Body`                                                                                     | [CreateServiceAccountRequestBody](../../Types/Requests/CreateServiceAccountRequestBody.md) | :heavy_minus_sign:                                                                         | N/A                                                                                        |

### Response

**[CreateServiceAccountResponse](../../Types/Requests/CreateServiceAccountResponse.md)**

### Errors

| Error Type                                                             | Status Code                                                            | Content Type                                                           |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.CreateServiceAccountBadRequestException      | 400                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.CreateServiceAccountUnauthorizedException    | 401                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.CreateServiceAccountForbiddenException       | 403                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.CreateServiceAccountNotFoundException        | 404                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.CreateServiceAccountConflictException        | 409                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.CreateServiceAccountGoneException            | 410                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.CreateServiceAccountTooManyRequestsException | 429                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.APIException                                 | 4XX, 5XX                                                               | \*/\*                                                                  |

## List

List service accounts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listServiceAccounts" method="get" path="/api/v1/authentication/orgs/{orgId}/service-accounts" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.ServiceAccounts.ListAsync(orgId: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `OrgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListServiceAccountsResponse](../../Types/Requests/ListServiceAccountsResponse.md)**

### Errors

| Error Type                                                            | Status Code                                                           | Content Type                                                          |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.ListServiceAccountsBadRequestException      | 400                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.ListServiceAccountsUnauthorizedException    | 401                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.ListServiceAccountsForbiddenException       | 403                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.ListServiceAccountsNotFoundException        | 404                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.ListServiceAccountsConflictException        | 409                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.ListServiceAccountsGoneException            | 410                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.ListServiceAccountsTooManyRequestsException | 429                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.APIException                                | 4XX, 5XX                                                              | \*/\*                                                                 |

## Get

Get a service account

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getServiceAccount" method="get" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.ServiceAccounts.GetAsync(
    orgId: "<id>",
    saId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `OrgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `SaId`                                                              | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetServiceAccountResponse](../../Types/Requests/GetServiceAccountResponse.md)**

### Errors

| Error Type                                                          | Status Code                                                         | Content Type                                                        |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.GetServiceAccountBadRequestException      | 400                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.GetServiceAccountUnauthorizedException    | 401                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.GetServiceAccountForbiddenException       | 403                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.GetServiceAccountNotFoundException        | 404                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.GetServiceAccountConflictException        | 409                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.GetServiceAccountGoneException            | 410                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.GetServiceAccountTooManyRequestsException | 429                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.APIException                              | 4XX, 5XX                                                            | \*/\*                                                               |

## Delete

Delete a service account

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteServiceAccount" method="delete" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.ServiceAccounts.DeleteAsync(
    orgId: "<id>",
    saId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `OrgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `SaId`                                                              | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[DeleteServiceAccountResponse](../../Types/Requests/DeleteServiceAccountResponse.md)**

### Errors

| Error Type                                                             | Status Code                                                            | Content Type                                                           |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.DeleteServiceAccountBadRequestException      | 400                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.DeleteServiceAccountUnauthorizedException    | 401                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.DeleteServiceAccountForbiddenException       | 403                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.DeleteServiceAccountNotFoundException        | 404                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.DeleteServiceAccountConflictException        | 409                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.DeleteServiceAccountGoneException            | 410                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.DeleteServiceAccountTooManyRequestsException | 429                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.APIException                                 | 4XX, 5XX                                                               | \*/\*                                                                  |

## ListApiKeys

List a service account's API keys

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listServiceAccountApiKeys" method="get" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}/api-keys" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.ServiceAccounts.ListApiKeysAsync(
    orgId: "<id>",
    saId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `OrgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `SaId`                                                              | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListServiceAccountApiKeysResponse](../../Types/Requests/ListServiceAccountApiKeysResponse.md)**

### Errors

| Error Type                                                                  | Status Code                                                                 | Content Type                                                                |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.ListServiceAccountApiKeysBadRequestException      | 400                                                                         | application/json                                                            |
| MeetKai.MKA1.Types.Errors.ListServiceAccountApiKeysUnauthorizedException    | 401                                                                         | application/json                                                            |
| MeetKai.MKA1.Types.Errors.ListServiceAccountApiKeysForbiddenException       | 403                                                                         | application/json                                                            |
| MeetKai.MKA1.Types.Errors.ListServiceAccountApiKeysNotFoundException        | 404                                                                         | application/json                                                            |
| MeetKai.MKA1.Types.Errors.ListServiceAccountApiKeysConflictException        | 409                                                                         | application/json                                                            |
| MeetKai.MKA1.Types.Errors.ListServiceAccountApiKeysGoneException            | 410                                                                         | application/json                                                            |
| MeetKai.MKA1.Types.Errors.ListServiceAccountApiKeysTooManyRequestsException | 429                                                                         | application/json                                                            |
| MeetKai.MKA1.Types.Errors.APIException                                      | 4XX, 5XX                                                                    | \*/\*                                                                       |

## UpdateApiKey

Update a service-account API key

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateServiceAccountApiKey" method="patch" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}/api-keys/{keyId}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

UpdateServiceAccountApiKeyRequest req = new UpdateServiceAccountApiKeyRequest() {
    OrgId = "<id>",
    SaId = "<id>",
    KeyId = "<id>",
};

var res = await sdk.Auth.ServiceAccounts.UpdateApiKeyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `request`                                                                                      | [UpdateServiceAccountApiKeyRequest](../../Types/Requests/UpdateServiceAccountApiKeyRequest.md) | :heavy_check_mark:                                                                             | The request object to use for the request.                                                     |

### Response

**[UpdateServiceAccountApiKeyResponse](../../Types/Requests/UpdateServiceAccountApiKeyResponse.md)**

### Errors

| Error Type                                                                   | Status Code                                                                  | Content Type                                                                 |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.UpdateServiceAccountApiKeyBadRequestException      | 400                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.UpdateServiceAccountApiKeyUnauthorizedException    | 401                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.UpdateServiceAccountApiKeyForbiddenException       | 403                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.UpdateServiceAccountApiKeyNotFoundException        | 404                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.UpdateServiceAccountApiKeyConflictException        | 409                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.UpdateServiceAccountApiKeyGoneException            | 410                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.UpdateServiceAccountApiKeyTooManyRequestsException | 429                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.APIException                                       | 4XX, 5XX                                                                     | \*/\*                                                                        |

## DeleteApiKey

Delete a service-account API key

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteServiceAccountApiKey" method="delete" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}/api-keys/{keyId}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.ServiceAccounts.DeleteApiKeyAsync(
    orgId: "<id>",
    saId: "<id>",
    keyId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `OrgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `SaId`                                                              | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `KeyId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[DeleteServiceAccountApiKeyResponse](../../Types/Requests/DeleteServiceAccountApiKeyResponse.md)**

### Errors

| Error Type                                                                   | Status Code                                                                  | Content Type                                                                 |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.DeleteServiceAccountApiKeyBadRequestException      | 400                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.DeleteServiceAccountApiKeyUnauthorizedException    | 401                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.DeleteServiceAccountApiKeyForbiddenException       | 403                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.DeleteServiceAccountApiKeyNotFoundException        | 404                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.DeleteServiceAccountApiKeyConflictException        | 409                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.DeleteServiceAccountApiKeyGoneException            | 410                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.DeleteServiceAccountApiKeyTooManyRequestsException | 429                                                                          | application/json                                                             |
| MeetKai.MKA1.Types.Errors.APIException                                       | 4XX, 5XX                                                                     | \*/\*                                                                        |

## RegenerateApiKey

Rotate a service-account API key's secret

### Example Usage

<!-- UsageSnippet language="csharp" operationID="regenerateServiceAccountApiKey" method="post" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}/api-keys/{keyId}/regenerate" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.ServiceAccounts.RegenerateApiKeyAsync(
    orgId: "<id>",
    saId: "<id>",
    keyId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `OrgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `SaId`                                                              | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `KeyId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[RegenerateServiceAccountApiKeyResponse](../../Types/Requests/RegenerateServiceAccountApiKeyResponse.md)**

### Errors

| Error Type                                                                       | Status Code                                                                      | Content Type                                                                     |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.RegenerateServiceAccountApiKeyBadRequestException      | 400                                                                              | application/json                                                                 |
| MeetKai.MKA1.Types.Errors.RegenerateServiceAccountApiKeyUnauthorizedException    | 401                                                                              | application/json                                                                 |
| MeetKai.MKA1.Types.Errors.RegenerateServiceAccountApiKeyForbiddenException       | 403                                                                              | application/json                                                                 |
| MeetKai.MKA1.Types.Errors.RegenerateServiceAccountApiKeyNotFoundException        | 404                                                                              | application/json                                                                 |
| MeetKai.MKA1.Types.Errors.RegenerateServiceAccountApiKeyConflictException        | 409                                                                              | application/json                                                                 |
| MeetKai.MKA1.Types.Errors.RegenerateServiceAccountApiKeyGoneException            | 410                                                                              | application/json                                                                 |
| MeetKai.MKA1.Types.Errors.RegenerateServiceAccountApiKeyTooManyRequestsException | 429                                                                              | application/json                                                                 |
| MeetKai.MKA1.Types.Errors.APIException                                           | 4XX, 5XX                                                                         | \*/\*                                                                            |