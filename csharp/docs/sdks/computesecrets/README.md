# ComputeSecrets

## Overview

### Available Operations

* [ListComputeSecrets](#listcomputesecrets) - List secrets
* [CreateComputeSecret](#createcomputesecret) - Create a secret
* [DeleteComputeSecret](#deletecomputesecret) - Delete a secret
* [GetComputeSecret](#getcomputesecret) - Get a secret

## ListComputeSecrets

List secrets

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeSecrets" method="get" path="/api/v1/compute/secrets" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeSecrets.ListComputeSecretsAsync(limit: 50);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Cursor`                                                            | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `Limit`                                                             | *long*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListComputeSecretsResponse](../../Types/Requests/ListComputeSecretsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateComputeSecret

Create a secret

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createComputeSecret" method="post" path="/api/v1/compute/secrets" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeSecrets.CreateComputeSecretAsync(body: new ComputeSecretCreate() {
    Data = new Dictionary<string, string>() {
        { "key", "<value>" },
        { "key1", "<value>" },
    },
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                            | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `Body`                                                               | [ComputeSecretCreate](../../Types/Components/ComputeSecretCreate.md) | :heavy_check_mark:                                                   | N/A                                                                  |
| `XOnBehalfOf`                                                        | *string*                                                             | :heavy_minus_sign:                                                   | Optional external end-user identifier forwarded by the API gateway.  |

### Response

**[CreateComputeSecretResponse](../../Types/Requests/CreateComputeSecretResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteComputeSecret

Delete a secret

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteComputeSecret" method="delete" path="/api/v1/compute/secrets/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeSecrets.DeleteComputeSecretAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[DeleteComputeSecretResponse](../../Types/Requests/DeleteComputeSecretResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetComputeSecret

Get a secret

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getComputeSecret" method="get" path="/api/v1/compute/secrets/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeSecrets.GetComputeSecretAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetComputeSecretResponse](../../Types/Requests/GetComputeSecretResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |