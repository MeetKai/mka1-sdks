# Llm.Prompts

## Overview

### Available Operations

* [Create](#create) - Create a prompt
* [List](#list) - List prompts
* [Get](#get) - Get a prompt
* [Update](#update) - Update a prompt
* [Delete](#delete) - Delete a prompt
* [CreateVersion](#createversion) - Create a new version
* [ListVersions](#listversions) - List versions
* [GetVersion](#getversion) - Get a specific version
* [Rollback](#rollback) - Rollback to a version

## Create

Creates a new prompt with its first version. The template supports {{variable}} placeholders.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createPrompt" method="post" path="/api/v1/llm/prompts" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Prompts.CreateAsync(body: new MeetKai.MKA1.Types.Components.CreatePromptRequest() {
    Name = "Customer Support Classifier",
    Description = "Classifies incoming customer messages by intent",
    Template = @"Classify the following customer message into one of these categories: {{categories}}

    Message: {{message}}",
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Body`                                                                                | [Types.Components.CreatePromptRequest](../../Types/Components/CreatePromptRequest.md) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `XOnBehalfOf`                                                                         | *string*                                                                              | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |

### Response

**[Types.Requests.CreatePromptResponse](../../Types/Requests/CreatePromptResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## List

Returns a paginated list of prompts owned by the authenticated user.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPrompts" method="get" path="/api/v1/llm/prompts" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Prompts.ListAsync(
    limit: 20,
    order: ListPromptsOrder.Desc
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Limit`                                                             | *long*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 |
| `After`                                                             | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `Order`                                                             | [ListPromptsOrder](../../Types/Requests/ListPromptsOrder.md)        | :heavy_minus_sign:                                                  | Sort order by creation date                                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[Types.Requests.ListPromptsResponse](../../Types/Requests/ListPromptsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Get

Retrieves a prompt by its ID, including the active template. Pass `version` to get a specific version's template. Pass `variables` as a JSON-encoded map to render the template with substitutions.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPrompt" method="get" path="/api/v1/llm/prompts/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Prompts.GetAsync(id: "prompt_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | prompt_aa87e2b1112a455b8deabed784372198                             |
| `Version`                                                           | *long*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `Variables`                                                         | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[Types.Requests.GetPromptResponse](../../Types/Requests/GetPromptResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Update

Updates prompt metadata. To update the template content, create a new version instead.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updatePrompt" method="put" path="/api/v1/llm/prompts/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Prompts.UpdateAsync(
    id: "prompt_aa87e2b1112a455b8deabed784372198",
    body: new UpdatePromptRequestBody() {
        Name = "Customer Support Classifier v2",
    }
);

// handle response
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                | Example                                                                    |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `Id`                                                                       | *string*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        | prompt_aa87e2b1112a455b8deabed784372198                                    |
| `Body`                                                                     | [UpdatePromptRequestBody](../../Types/Requests/UpdatePromptRequestBody.md) | :heavy_check_mark:                                                         | N/A                                                                        |                                                                            |
| `XOnBehalfOf`                                                              | *string*                                                                   | :heavy_minus_sign:                                                         | Optional external end-user identifier forwarded by the API gateway.        |                                                                            |

### Response

**[Types.Requests.UpdatePromptResponse](../../Types/Requests/UpdatePromptResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Delete

Deletes a prompt and all its versions.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deletePrompt" method="delete" path="/api/v1/llm/prompts/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Prompts.DeleteAsync(id: "prompt_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | prompt_aa87e2b1112a455b8deabed784372198                             |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[Types.Requests.DeletePromptResponse](../../Types/Requests/DeletePromptResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateVersion

Creates a new version of a prompt. The new version automatically becomes the active version. Fields not provided are carried forward from the previous version.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createPromptVersion" method="post" path="/api/v1/llm/prompts/{id}/versions" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Prompts.CreateVersionAsync(
    id: "prompt_aa87e2b1112a455b8deabed784372198",
    body: new CreatePromptVersionRequestBody() {
        Template = @"You are a customer support classifier. Classify the message into: {{categories}}

        Respond with only the category name.

        Message: {{message}}",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              | Example                                                                                  |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `Id`                                                                                     | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      | prompt_aa87e2b1112a455b8deabed784372198                                                  |
| `Body`                                                                                   | [CreatePromptVersionRequestBody](../../Types/Requests/CreatePromptVersionRequestBody.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |                                                                                          |
| `XOnBehalfOf`                                                                            | *string*                                                                                 | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |                                                                                          |

### Response

**[CreatePromptVersionResponse](../../Types/Requests/CreatePromptVersionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListVersions

Returns the version history of a prompt, ordered by version number.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPromptVersions" method="get" path="/api/v1/llm/prompts/{id}/versions" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Prompts.ListVersionsAsync(
    id: "prompt_aa87e2b1112a455b8deabed784372198",
    limit: 20,
    order: ListPromptVersionsOrder.Desc
);

// handle response
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                | Example                                                                    |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `Id`                                                                       | *string*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        | prompt_aa87e2b1112a455b8deabed784372198                                    |
| `Limit`                                                                    | *long*                                                                     | :heavy_minus_sign:                                                         | N/A                                                                        |                                                                            |
| `Order`                                                                    | [ListPromptVersionsOrder](../../Types/Requests/ListPromptVersionsOrder.md) | :heavy_minus_sign:                                                         | Sort order by version number                                               |                                                                            |
| `XOnBehalfOf`                                                              | *string*                                                                   | :heavy_minus_sign:                                                         | Optional external end-user identifier forwarded by the API gateway.        |                                                                            |

### Response

**[ListPromptVersionsResponse](../../Types/Requests/ListPromptVersionsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetVersion

Retrieves a specific version of a prompt by version number.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPromptVersion" method="get" path="/api/v1/llm/prompts/{id}/versions/{version}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Prompts.GetVersionAsync(
    id: "prompt_aa87e2b1112a455b8deabed784372198",
    version: 1
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | prompt_aa87e2b1112a455b8deabed784372198                             |
| `Version`                                                           | *long*                                                              | :heavy_check_mark:                                                  | N/A                                                                 | 1                                                                   |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetPromptVersionResponse](../../Types/Requests/GetPromptVersionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Rollback

Sets the active version of a prompt to a previous version. This does not delete newer versions — it only changes which version is active.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="rollbackPrompt" method="post" path="/api/v1/llm/prompts/{id}/rollback" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Prompts.RollbackAsync(
    id: "prompt_aa87e2b1112a455b8deabed784372198",
    body: new RollbackPromptRequestBody() {
        Version = 1,
    }
);

// handle response
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    | Example                                                                        |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `Id`                                                                           | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            | prompt_aa87e2b1112a455b8deabed784372198                                        |
| `Body`                                                                         | [RollbackPromptRequestBody](../../Types/Requests/RollbackPromptRequestBody.md) | :heavy_check_mark:                                                             | N/A                                                                            |                                                                                |
| `XOnBehalfOf`                                                                  | *string*                                                                       | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |                                                                                |

### Response

**[RollbackPromptResponse](../../Types/Requests/RollbackPromptResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |