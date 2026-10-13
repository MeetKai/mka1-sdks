# Flags.Environments

## Overview

### Available Operations

* [List](#list) - List environments
* [Create](#create) - Create an environment
* [Delete](#delete) - Delete an environment and every flag setting in it
* [Update](#update) - Rename an environment
* [Evaluate](#evaluate) - Evaluate every flag for an identity
* [EvaluateWithTraits](#evaluatewithtraits) - Evaluate every flag for an identity with traits
* [RevokeEvaluationKey](#revokeevaluationkey) - Revoke an environment evaluation key
* [GenerateEvaluationKey](#generateevaluationkey) - Generate or replace an environment evaluation key

## List

List environments

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listFeatureFlagEnvironments" method="get" path="/api/v1/flags/environments" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.Environments.ListAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListFeatureFlagEnvironmentsResponse](../../Types/Requests/ListFeatureFlagEnvironmentsResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 401, 403                                   | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## Create

Every existing flag gets a disabled state in the new environment.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createFeatureFlagEnvironment" method="post" path="/api/v1/flags/environments" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.Environments.CreateAsync(body: new FeatureFlagEnvironmentCreateRequest() {
    Key = "<key>",
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `Body`                                                                                               | [FeatureFlagEnvironmentCreateRequest](../../Types/Components/FeatureFlagEnvironmentCreateRequest.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `XOnBehalfOf`                                                                                        | *string*                                                                                             | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |

### Response

**[CreateFeatureFlagEnvironmentResponse](../../Types/Requests/CreateFeatureFlagEnvironmentResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 400, 401, 403, 409                         | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## Delete

Delete an environment and every flag setting in it

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteFeatureFlagEnvironment" method="delete" path="/api/v1/flags/environments/{env}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.Environments.DeleteAsync(env: "<value>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Env`                                                               | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[DeleteFeatureFlagEnvironmentResponse](../../Types/Requests/DeleteFeatureFlagEnvironmentResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 401, 403, 404                              | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## Update

Rename an environment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateFeatureFlagEnvironment" method="patch" path="/api/v1/flags/environments/{env}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.Environments.UpdateAsync(
    env: "<value>",
    body: new FeatureFlagEnvironmentUpdateRequest() {
        Name = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `Env`                                                                                                | *string*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `Body`                                                                                               | [FeatureFlagEnvironmentUpdateRequest](../../Types/Components/FeatureFlagEnvironmentUpdateRequest.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `XOnBehalfOf`                                                                                        | *string*                                                                                             | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |

### Response

**[UpdateFeatureFlagEnvironmentResponse](../../Types/Requests/UpdateFeatureFlagEnvironmentResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 400, 401, 403, 404                         | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## Evaluate

Resolves every non-archived flag of the environment for an anonymous caller, or for the identity given in the query. Sends an ETag and answers 304 to a matching If-None-Match after authenticating the environment evaluation key.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="evaluateFeatureFlags" method="get" path="/api/v1/flags/environments/{env}/evaluate" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK();

var res = await sdk.Flags.Environments.EvaluateAsync(
    security: new EvaluateFeatureFlagsSecurity() {
        EvaluationKeyAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    env: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `security`                                                                           | [EvaluateFeatureFlagsSecurity](../../Types/Requests/EvaluateFeatureFlagsSecurity.md) | :heavy_check_mark:                                                                   | The security requirements to use for the request.                                    |
| `Env`                                                                                | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `Identity`                                                                           | *string*                                                                             | :heavy_minus_sign:                                                                   | Stable identifier of the caller; enables rollouts and overrides.                     |
| `XOnBehalfOf`                                                                        | *string*                                                                             | :heavy_minus_sign:                                                                   | Optional external end-user identifier forwarded by the API gateway.                  |

### Response

**[EvaluateFeatureFlagsResponse](../../Types/Requests/EvaluateFeatureFlagsResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 401                                        | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## EvaluateWithTraits

Evaluate every flag for an identity with traits

### Example Usage

<!-- UsageSnippet language="csharp" operationID="evaluateFeatureFlagsWithTraits" method="post" path="/api/v1/flags/environments/{env}/evaluate" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK();

var res = await sdk.Flags.Environments.EvaluateWithTraitsAsync(
    security: new EvaluateFeatureFlagsWithTraitsSecurity() {
        EvaluationKeyAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    env: "<value>",
    body: new FeatureFlagEvaluateRequest() {}
);

// handle response
```

### Parameters

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `security`                                                                                               | [EvaluateFeatureFlagsWithTraitsSecurity](../../Types/Requests/EvaluateFeatureFlagsWithTraitsSecurity.md) | :heavy_check_mark:                                                                                       | The security requirements to use for the request.                                                        |
| `Env`                                                                                                    | *string*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `Body`                                                                                                   | [FeatureFlagEvaluateRequest](../../Types/Components/FeatureFlagEvaluateRequest.md)                       | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `XOnBehalfOf`                                                                                            | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                      |

### Response

**[EvaluateFeatureFlagsWithTraitsResponse](../../Types/Requests/EvaluateFeatureFlagsWithTraitsResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 400, 401                                   | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## RevokeEvaluationKey

Revocation is idempotent while the environment exists.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="revokeFeatureFlagEvaluationKey" method="delete" path="/api/v1/flags/environments/{env}/evaluation-key" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.Environments.RevokeEvaluationKeyAsync(env: "<value>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Env`                                                               | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[RevokeFeatureFlagEvaluationKeyResponse](../../Types/Requests/RevokeFeatureFlagEvaluationKeyResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 401, 403, 404                              | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## GenerateEvaluationKey

Returns the new plaintext key once. Only its SHA-256 digest and a display hint are stored; generating another key immediately replaces the previous credential on this replica.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="generateFeatureFlagEvaluationKey" method="post" path="/api/v1/flags/environments/{env}/evaluation-key" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.Environments.GenerateEvaluationKeyAsync(env: "<value>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Env`                                                               | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GenerateFeatureFlagEvaluationKeyResponse](../../Types/Requests/GenerateFeatureFlagEvaluationKeyResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 401, 403, 404                              | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |