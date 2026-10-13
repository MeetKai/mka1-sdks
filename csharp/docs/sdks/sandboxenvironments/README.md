# Sandbox.Environments

## Overview

### Available Operations

* [List](#list) - List Environments
* [Create](#create) - Create Environment
* [Get](#get) - Get Environment
* [Update](#update) - Update Environment
* [Delete](#delete) - Delete Environment
* [RunSetup](#runsetup) - Run Environment Setup

## List

List the caller's saved environments, plus the per-environment repository limit.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listSandboxEnvironments" method="get" path="/api/v1/sandbox/environments" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Environments.ListAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListSandboxEnvironmentsResponse](../../Types/Requests/ListSandboxEnvironmentsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Create

Save a named environment: repositories to clone, environment variables, network access, and an optional bash setup script. Sessions created from it copy these settings. Do not put secrets in `environment_variables`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createSandboxEnvironment" method="post" path="/api/v1/sandbox/environments" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Environments.CreateAsync(body: new SaveEnvironmentRequest() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `Body`                                                                     | [SaveEnvironmentRequest](../../Types/Components/SaveEnvironmentRequest.md) | :heavy_check_mark:                                                         | N/A                                                                        |
| `XOnBehalfOf`                                                              | *string*                                                                   | :heavy_minus_sign:                                                         | Optional external end-user identifier forwarded by the API gateway.        |

### Response

**[CreateSandboxEnvironmentResponse](../../Types/Requests/CreateSandboxEnvironmentResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## Get

Return one of the caller's saved environments.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSandboxEnvironment" method="get" path="/api/v1/sandbox/environments/{environment_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Environments.GetAsync(environmentId: 438435);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `EnvironmentId`                                                     | *long*                                                              | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetSandboxEnvironmentResponse](../../Types/Requests/GetSandboxEnvironmentResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## Update

Replace a saved environment's settings. Omit `network_access` to keep the stored value. Sessions already created from the environment keep the settings they started with.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateSandboxEnvironment" method="put" path="/api/v1/sandbox/environments/{environment_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Environments.UpdateAsync(
    environmentId: 946665,
    body: new SaveEnvironmentRequest() {
        Name = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `EnvironmentId`                                                            | *long*                                                                     | :heavy_check_mark:                                                         | N/A                                                                        |
| `Body`                                                                     | [SaveEnvironmentRequest](../../Types/Components/SaveEnvironmentRequest.md) | :heavy_check_mark:                                                         | N/A                                                                        |
| `XOnBehalfOf`                                                              | *string*                                                                   | :heavy_minus_sign:                                                         | Optional external end-user identifier forwarded by the API gateway.        |

### Response

**[UpdateSandboxEnvironmentResponse](../../Types/Requests/UpdateSandboxEnvironmentResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## Delete

Delete a saved environment. Sessions already created from it are not affected.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteSandboxEnvironment" method="delete" path="/api/v1/sandbox/environments/{environment_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Environments.DeleteAsync(environmentId: 252282);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `EnvironmentId`                                                     | *long*                                                              | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[DeleteSandboxEnvironmentResponse](../../Types/Requests/DeleteSandboxEnvironmentResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## RunSetup

Run the setup script of the environment the session was created from. Call it once the session's repositories have cloned. A `running` status means setup has not finished yet and calling again is safe; once setup has succeeded, later calls return `succeeded` without running it again.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="runSandboxEnvironmentSetup" method="post" path="/api/v1/sandbox/sessions/{session_id}/environment-setup" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Environments.RunSetupAsync(sessionId: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SessionId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[RunSandboxEnvironmentSetupResponse](../../Types/Requests/RunSandboxEnvironmentSetupResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |