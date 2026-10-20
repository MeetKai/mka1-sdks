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

<!-- UsageSnippet language="go" operationID="createPrompt" method="post" path="/api/v1/llm/prompts" -->
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

    res, err := s.Llm.Prompts.Create(ctx, components.CreatePromptRequest{
        Name: "Customer Support Classifier",
        Description: mka1.Pointer("Classifies incoming customer messages by intent"),
        Template: "Classify the following customer message into one of these categories: {{categories}}\n\nMessage: {{message}}",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.CreatePromptResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                        | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `ctx`                                                                            | [context.Context](https://pkg.go.dev/context#Context)                            | :heavy_check_mark:                                                               | The context to use for the request.                                              |
| `body`                                                                           | [components.CreatePromptRequest](../../models/components/createpromptrequest.md) | :heavy_check_mark:                                                               | N/A                                                                              |
| `xOnBehalfOf`                                                                    | `*string`                                                                        | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |
| `opts`                                                                           | [][operations.Option](../../models/operations/option.md)                         | :heavy_minus_sign:                                                               | The options for this request.                                                    |

### Response

**[*operations.CreatePromptResponse](../../models/operations/createpromptresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## List

Returns a paginated list of prompts owned by the authenticated user.

### Example Usage

<!-- UsageSnippet language="go" operationID="listPrompts" method="get" path="/api/v1/llm/prompts" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Prompts.List(ctx, mka1.Pointer[int64](20), nil, operations.ListPromptsOrderDesc.ToPointer(), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ListPromptsResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `ctx`                                                                       | [context.Context](https://pkg.go.dev/context#Context)                       | :heavy_check_mark:                                                          | The context to use for the request.                                         |
| `limit`                                                                     | `*int64`                                                                    | :heavy_minus_sign:                                                          | N/A                                                                         |
| `after`                                                                     | `*string`                                                                   | :heavy_minus_sign:                                                          | N/A                                                                         |
| `order`                                                                     | [*operations.ListPromptsOrder](../../models/operations/listpromptsorder.md) | :heavy_minus_sign:                                                          | Sort order by creation date                                                 |
| `xOnBehalfOf`                                                               | `*string`                                                                   | :heavy_minus_sign:                                                          | Optional external end-user identifier forwarded by the API gateway.         |
| `opts`                                                                      | [][operations.Option](../../models/operations/option.md)                    | :heavy_minus_sign:                                                          | The options for this request.                                               |

### Response

**[*operations.ListPromptsResponse](../../models/operations/listpromptsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Get

Retrieves a prompt by its ID, including the active template. Pass `version` to get a specific version's template. Pass `variables` as a JSON-encoded map to render the template with substitutions.

### Example Usage

<!-- UsageSnippet language="go" operationID="getPrompt" method="get" path="/api/v1/llm/prompts/{id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Prompts.Get(ctx, "prompt_aa87e2b1112a455b8deabed784372198", nil, nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.GetPromptResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `id`                                                                | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | prompt_aa87e2b1112a455b8deabed784372198                             |
| `version`                                                           | `*int64`                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `variables`                                                         | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetPromptResponse](../../models/operations/getpromptresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Update

Updates prompt metadata. To update the template content, create a new version instead.

### Example Usage

<!-- UsageSnippet language="go" operationID="updatePrompt" method="put" path="/api/v1/llm/prompts/{id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Prompts.Update(ctx, "prompt_aa87e2b1112a455b8deabed784372198", operations.UpdatePromptRequestBody{
        Name: mka1.Pointer("Customer Support Classifier v2"),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.UpdatePromptResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              | Example                                                                                  |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |                                                                                          |
| `id`                                                                                     | `string`                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      | prompt_aa87e2b1112a455b8deabed784372198                                                  |
| `body`                                                                                   | [operations.UpdatePromptRequestBody](../../models/operations/updatepromptrequestbody.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |                                                                                          |
| `xOnBehalfOf`                                                                            | `*string`                                                                                | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |                                                                                          |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |                                                                                          |

### Response

**[*operations.UpdatePromptResponse](../../models/operations/updatepromptresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Delete

Deletes a prompt and all its versions.

### Example Usage

<!-- UsageSnippet language="go" operationID="deletePrompt" method="delete" path="/api/v1/llm/prompts/{id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Prompts.Delete(ctx, "prompt_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.DeletePromptResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `id`                                                                | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | prompt_aa87e2b1112a455b8deabed784372198                             |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeletePromptResponse](../../models/operations/deletepromptresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateVersion

Creates a new version of a prompt. The new version automatically becomes the active version. Fields not provided are carried forward from the previous version.

### Example Usage

<!-- UsageSnippet language="go" operationID="createPromptVersion" method="post" path="/api/v1/llm/prompts/{id}/versions" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Prompts.CreateVersion(ctx, "prompt_aa87e2b1112a455b8deabed784372198", operations.CreatePromptVersionRequestBody{
        Template: "You are a customer support classifier. Classify the message into: {{categories}}\n\nRespond with only the category name.\n\nMessage: {{message}}",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.CreateVersionResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                              | Type                                                                                                   | Required                                                                                               | Description                                                                                            | Example                                                                                                |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                  | :heavy_check_mark:                                                                                     | The context to use for the request.                                                                    |                                                                                                        |
| `id`                                                                                                   | `string`                                                                                               | :heavy_check_mark:                                                                                     | N/A                                                                                                    | prompt_aa87e2b1112a455b8deabed784372198                                                                |
| `body`                                                                                                 | [operations.CreatePromptVersionRequestBody](../../models/operations/createpromptversionrequestbody.md) | :heavy_check_mark:                                                                                     | N/A                                                                                                    |                                                                                                        |
| `xOnBehalfOf`                                                                                          | `*string`                                                                                              | :heavy_minus_sign:                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                    |                                                                                                        |
| `opts`                                                                                                 | [][operations.Option](../../models/operations/option.md)                                               | :heavy_minus_sign:                                                                                     | The options for this request.                                                                          |                                                                                                        |

### Response

**[*operations.CreatePromptVersionResponse](../../models/operations/createpromptversionresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListVersions

Returns the version history of a prompt, ordered by version number.

### Example Usage

<!-- UsageSnippet language="go" operationID="listPromptVersions" method="get" path="/api/v1/llm/prompts/{id}/versions" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Prompts.ListVersions(ctx, "prompt_aa87e2b1112a455b8deabed784372198", mka1.Pointer[int64](20), operations.ListPromptVersionsOrderDesc.ToPointer(), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ListVersionsResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               | Example                                                                                   |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `ctx`                                                                                     | [context.Context](https://pkg.go.dev/context#Context)                                     | :heavy_check_mark:                                                                        | The context to use for the request.                                                       |                                                                                           |
| `id`                                                                                      | `string`                                                                                  | :heavy_check_mark:                                                                        | N/A                                                                                       | prompt_aa87e2b1112a455b8deabed784372198                                                   |
| `limit`                                                                                   | `*int64`                                                                                  | :heavy_minus_sign:                                                                        | N/A                                                                                       |                                                                                           |
| `order`                                                                                   | [*operations.ListPromptVersionsOrder](../../models/operations/listpromptversionsorder.md) | :heavy_minus_sign:                                                                        | Sort order by version number                                                              |                                                                                           |
| `xOnBehalfOf`                                                                             | `*string`                                                                                 | :heavy_minus_sign:                                                                        | Optional external end-user identifier forwarded by the API gateway.                       |                                                                                           |
| `opts`                                                                                    | [][operations.Option](../../models/operations/option.md)                                  | :heavy_minus_sign:                                                                        | The options for this request.                                                             |                                                                                           |

### Response

**[*operations.ListPromptVersionsResponse](../../models/operations/listpromptversionsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetVersion

Retrieves a specific version of a prompt by version number.

### Example Usage

<!-- UsageSnippet language="go" operationID="getPromptVersion" method="get" path="/api/v1/llm/prompts/{id}/versions/{version}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Prompts.GetVersion(ctx, "prompt_aa87e2b1112a455b8deabed784372198", 1, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.CreateVersionResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `id`                                                                | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | prompt_aa87e2b1112a455b8deabed784372198                             |
| `version`                                                           | `int64`                                                             | :heavy_check_mark:                                                  | N/A                                                                 | 1                                                                   |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetPromptVersionResponse](../../models/operations/getpromptversionresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Rollback

Sets the active version of a prompt to a previous version. This does not delete newer versions — it only changes which version is active.

### Example Usage

<!-- UsageSnippet language="go" operationID="rollbackPrompt" method="post" path="/api/v1/llm/prompts/{id}/rollback" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Prompts.Rollback(ctx, "prompt_aa87e2b1112a455b8deabed784372198", operations.RollbackPromptRequestBody{
        Version: 1,
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.UpdatePromptResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  | Example                                                                                      |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `ctx`                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                        | :heavy_check_mark:                                                                           | The context to use for the request.                                                          |                                                                                              |
| `id`                                                                                         | `string`                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          | prompt_aa87e2b1112a455b8deabed784372198                                                      |
| `body`                                                                                       | [operations.RollbackPromptRequestBody](../../models/operations/rollbackpromptrequestbody.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |                                                                                              |
| `xOnBehalfOf`                                                                                | `*string`                                                                                    | :heavy_minus_sign:                                                                           | Optional external end-user identifier forwarded by the API gateway.                          |                                                                                              |
| `opts`                                                                                       | [][operations.Option](../../models/operations/option.md)                                     | :heavy_minus_sign:                                                                           | The options for this request.                                                                |                                                                                              |

### Response

**[*operations.RollbackPromptResponse](../../models/operations/rollbackpromptresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |