# Permissions.Llm

## Overview

### Available Operations

* [Grant](#grant) - Grant permission to a user or make public
* [Revoke](#revoke) - Revoke permission from a user or remove public access
* [Check](#check) - Check user permission

## Grant

Grant a role to a user for a resource, or grant public access by using "*" as userId. Only owners can grant permissions. Public access is allowed only for writer and reader roles.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="llm.grant" method="post" path="/api/v1/authorization/llm/grant" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Permissions.Llm.GrantAsync(body: new GrantPermissionRequest() {
    ResourceType = LlmResourceType.Completion,
    ResourceId = "my-completion-123",
    UserId = "user-abc456",
    Role = ResourceRole.Writer,
});

// handle response
```

### Parameters

| Parameter                                                                                                      | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    | Example                                                                                                        |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `Body`                                                                                                         | [GrantPermissionRequest](../../Types/Components/GrantPermissionRequest.md)                                     | :heavy_check_mark:                                                                                             | N/A                                                                                                            | {<br/>"resourceType": "completion",<br/>"resourceId": "my-completion-123",<br/>"userId": "user-abc456",<br/>"role": "writer"<br/>} |
| `XOnBehalfOf`                                                                                                  | *string*                                                                                                       | :heavy_minus_sign:                                                                                             | Optional external end-user identifier forwarded by the API gateway.                                            |                                                                                                                |

### Response

**[LlmGrantResponse](../../Types/Requests/LlmGrantResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Revoke

Revoke a role from a user for a resource, or remove public access by using "*" as userId. Only owners can revoke permissions.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="llm.revoke" method="post" path="/api/v1/authorization/llm/revoke" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Permissions.Llm.RevokeAsync(body: new RevokePermissionRequest() {
    ResourceType = LlmResourceType.Completion,
    ResourceId = "my-completion-123",
    UserId = "user-abc456",
    Role = ResourceRole.Reader,
});

// handle response
```

### Parameters

| Parameter                                                                                                      | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    | Example                                                                                                        |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `Body`                                                                                                         | [RevokePermissionRequest](../../Types/Components/RevokePermissionRequest.md)                                   | :heavy_check_mark:                                                                                             | N/A                                                                                                            | {<br/>"resourceType": "completion",<br/>"resourceId": "my-completion-123",<br/>"userId": "user-abc456",<br/>"role": "reader"<br/>} |
| `XOnBehalfOf`                                                                                                  | *string*                                                                                                       | :heavy_minus_sign:                                                                                             | Optional external end-user identifier forwarded by the API gateway.                                            |                                                                                                                |

### Response

**[LlmRevokeResponse](../../Types/Requests/LlmRevokeResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Check

Check whether the authenticated caller has a specific role on a resource.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="llm.check" method="get" path="/api/v1/authorization/llm/check" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Permissions.Llm.CheckAsync(
    resourceType: LlmResourceType.Conversation,
    resourceId: "<id>",
    role: ResourceRole.Writer
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ResourceType`                                                      | [LlmResourceType](../../Types/Components/LlmResourceType.md)        | :heavy_check_mark:                                                  | Type of LLM resource                                                |
| `ResourceId`                                                        | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `Role`                                                              | [ResourceRole](../../Types/Components/ResourceRole.md)              | :heavy_check_mark:                                                  | Permission role for the resource (owner > writer > reader)          |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[LlmCheckResponse](../../Types/Requests/LlmCheckResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |