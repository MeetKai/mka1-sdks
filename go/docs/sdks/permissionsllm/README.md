# Permissions.Llm

## Overview

### Available Operations

* [Grant](#grant) - Grant permission to a user or make public
* [Revoke](#revoke) - Revoke permission from a user or remove public access
* [Check](#check) - Check user permission

## Grant

Grant a role to a user for a resource, or grant public access by using "*" as userId. Only owners can grant permissions. Public access is allowed only for writer and reader roles.

### Example Usage

<!-- UsageSnippet language="go" operationID="llm.grant" method="post" path="/api/v1/authorization/llm/grant" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Permissions.Llm.Grant(ctx, components.GrantPermissionRequest{
        ResourceType: components.LlmResourceTypeCompletion,
        ResourceID: "my-completion-123",
        UserID: "user-abc456",
        Role: components.ResourceRoleWriter,
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                      | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    | Example                                                                                                        |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                                          | :heavy_check_mark:                                                                                             | The context to use for the request.                                                                            |                                                                                                                |
| `body`                                                                                                         | [components.GrantPermissionRequest](../../models/components/grantpermissionrequest.md)                         | :heavy_check_mark:                                                                                             | N/A                                                                                                            | {<br/>"resourceType": "completion",<br/>"resourceId": "my-completion-123",<br/>"userId": "user-abc456",<br/>"role": "writer"<br/>} |
| `xOnBehalfOf`                                                                                                  | `*string`                                                                                                      | :heavy_minus_sign:                                                                                             | Optional external end-user identifier forwarded by the API gateway.                                            |                                                                                                                |
| `opts`                                                                                                         | [][operations.Option](../../models/operations/option.md)                                                       | :heavy_minus_sign:                                                                                             | The options for this request.                                                                                  |                                                                                                                |

### Response

**[*operations.LlmGrantResponse](../../models/operations/llmgrantresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Revoke

Revoke a role from a user for a resource, or remove public access by using "*" as userId. Only owners can revoke permissions.

### Example Usage

<!-- UsageSnippet language="go" operationID="llm.revoke" method="post" path="/api/v1/authorization/llm/revoke" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Permissions.Llm.Revoke(ctx, components.RevokePermissionRequest{
        ResourceType: components.LlmResourceTypeCompletion,
        ResourceID: "my-completion-123",
        UserID: "user-abc456",
        Role: components.ResourceRoleReader,
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                      | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    | Example                                                                                                        |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                                          | :heavy_check_mark:                                                                                             | The context to use for the request.                                                                            |                                                                                                                |
| `body`                                                                                                         | [components.RevokePermissionRequest](../../models/components/revokepermissionrequest.md)                       | :heavy_check_mark:                                                                                             | N/A                                                                                                            | {<br/>"resourceType": "completion",<br/>"resourceId": "my-completion-123",<br/>"userId": "user-abc456",<br/>"role": "reader"<br/>} |
| `xOnBehalfOf`                                                                                                  | `*string`                                                                                                      | :heavy_minus_sign:                                                                                             | Optional external end-user identifier forwarded by the API gateway.                                            |                                                                                                                |
| `opts`                                                                                                         | [][operations.Option](../../models/operations/option.md)                                                       | :heavy_minus_sign:                                                                                             | The options for this request.                                                                                  |                                                                                                                |

### Response

**[*operations.LlmRevokeResponse](../../models/operations/llmrevokeresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Check

Check whether the authenticated caller has a specific role on a resource.

### Example Usage

<!-- UsageSnippet language="go" operationID="llm.check" method="get" path="/api/v1/authorization/llm/check" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Permissions.Llm.Check(ctx, components.LlmResourceTypeConversation, "<id>", components.ResourceRoleWriter, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.CheckPermissionResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `ctx`                                                                    | [context.Context](https://pkg.go.dev/context#Context)                    | :heavy_check_mark:                                                       | The context to use for the request.                                      |
| `resourceType`                                                           | [components.LlmResourceType](../../models/components/llmresourcetype.md) | :heavy_check_mark:                                                       | Type of LLM resource                                                     |
| `resourceID`                                                             | `string`                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `role`                                                                   | [components.ResourceRole](../../models/components/resourcerole.md)       | :heavy_check_mark:                                                       | Permission role for the resource (owner > writer > reader)               |
| `xOnBehalfOf`                                                            | `*string`                                                                | :heavy_minus_sign:                                                       | Optional external end-user identifier forwarded by the API gateway.      |
| `opts`                                                                   | [][operations.Option](../../models/operations/option.md)                 | :heavy_minus_sign:                                                       | The options for this request.                                            |

### Response

**[*operations.LlmCheckResponse](../../models/operations/llmcheckresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |