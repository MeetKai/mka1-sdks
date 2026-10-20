# Llm.Feedback

## Overview

### Available Operations

* [CreateCompletionFeedback](#createcompletionfeedback) - Submit feedback for chat completion
* [ListCompletionFeedback](#listcompletionfeedback) - List chat completion feedback
* [GetCompletionFeedback](#getcompletionfeedback) - Retrieve feedback by completion ID
* [UpdateCompletionFeedback](#updatecompletionfeedback) - Update existing completion feedback
* [BatchGetCompletionFeedback](#batchgetcompletionfeedback) - Batch retrieve feedback for multiple completions
* [CreateResponseFeedback](#createresponsefeedback) - Submit feedback for response
* [ListResponseFeedback](#listresponsefeedback) - List response feedback
* [GetResponseFeedback](#getresponsefeedback) - Retrieve feedback by response ID
* [UpdateResponseFeedback](#updateresponsefeedback) - Update existing response feedback
* [BatchGetResponseFeedback](#batchgetresponsefeedback) - Batch retrieve feedback for multiple responses
* [ExportCompletionFeedback](#exportcompletionfeedback) - Export completion feedback as CSV
* [ExportResponseFeedback](#exportresponsefeedback) - Export response feedback as CSV
* [StartExport](#startexport) - Start feedback export
* [GetExportStatus](#getexportstatus) - Get feedback export status

## CreateCompletionFeedback

Submit user feedback for a specific chat completion to track satisfaction and model performance. Each completion can only receive feedback once.

### Example Usage

<!-- UsageSnippet language="go" operationID="createCompletionFeedback" method="post" path="/api/v1/llm/feedback/completions" -->
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

    res, err := s.Llm.Feedback.CreateCompletionFeedback(ctx, components.CreateFeedbackRequest{
        ID: "chatcmpl-abc123def456",
        Rating: components.CreateFeedbackRequestRatingThumbsUp.ToPointer(),
        Description: mka1.Pointer("The response was accurate and helpful."),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.CreateFeedbackResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       | Example                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                             | [context.Context](https://pkg.go.dev/context#Context)                                                             | :heavy_check_mark:                                                                                                | The context to use for the request.                                                                               |                                                                                                                   |
| `body`                                                                                                            | [components.CreateFeedbackRequest](../../models/components/createfeedbackrequest.md)                              | :heavy_check_mark:                                                                                                | N/A                                                                                                               | {<br/>"id": "chatcmpl-abc123def456",<br/>"rating": "thumbs_up",<br/>"description": "The response was accurate and helpful."<br/>} |
| `xOnBehalfOf`                                                                                                     | `*string`                                                                                                         | :heavy_minus_sign:                                                                                                | Optional external end-user identifier forwarded by the API gateway.                                               |                                                                                                                   |
| `opts`                                                                                                            | [][operations.Option](../../models/operations/option.md)                                                          | :heavy_minus_sign:                                                                                                | The options for this request.                                                                                     |                                                                                                                   |

### Response

**[*operations.CreateCompletionFeedbackResponse](../../models/operations/createcompletionfeedbackresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListCompletionFeedback

Retrieves a paginated list of feedback entries recorded on the caller's chat completions, ordered by the completion's creation date. Supports filtering by rating. An `after` cursor that no longer resolves to a completion visible to the caller returns 400; restart pagination from the first page.

### Example Usage

<!-- UsageSnippet language="go" operationID="listCompletionFeedback" method="get" path="/api/v1/llm/feedback/completions" -->
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

    res, err := s.Llm.Feedback.ListCompletionFeedback(ctx, operations.ListCompletionFeedbackRequest{
        After: mka1.Pointer("chatcmpl-abc123def456"),
        Limit: mka1.Pointer[int64](25),
        Rating: operations.ListCompletionFeedbackRatingThumbsUp.ToPointer(),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ListFeedbackResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                                | :heavy_check_mark:                                                                                   | The context to use for the request.                                                                  |
| `request`                                                                                            | [operations.ListCompletionFeedbackRequest](../../models/operations/listcompletionfeedbackrequest.md) | :heavy_check_mark:                                                                                   | The request object to use for the request.                                                           |
| `opts`                                                                                               | [][operations.Option](../../models/operations/option.md)                                             | :heavy_minus_sign:                                                                                   | The options for this request.                                                                        |

### Response

**[*operations.ListCompletionFeedbackResponse](../../models/operations/listcompletionfeedbackresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetCompletionFeedback

Retrieves the existing feedback rating and description for a specific chat completion.

### Example Usage

<!-- UsageSnippet language="go" operationID="getCompletionFeedback" method="get" path="/api/v1/llm/feedback/completions/{id}" -->
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

    res, err := s.Llm.Feedback.GetCompletionFeedback(ctx, "chatcmpl-abc123def456", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.GetFeedbackResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `id`                                                                | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | chatcmpl-abc123def456                                               |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetCompletionFeedbackResponse](../../models/operations/getcompletionfeedbackresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## UpdateCompletionFeedback

Updates or modifies existing feedback for a specific chat completion. Useful for allowing users to revise their initial submissions.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateCompletionFeedback" method="put" path="/api/v1/llm/feedback/completions/{id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Feedback.UpdateCompletionFeedback(ctx, "chatcmpl-abc123def456", operations.UpdateCompletionFeedbackRequestBody{
        Rating: optionalnullable.From(mka1.Pointer(operations.UpdateCompletionFeedbackRatingThumbsDown)),
        Description: optionalnullable.From(mka1.Pointer("Could be more detailed.")),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.UpdateFeedbackResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                        | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      | Example                                                                                                          |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                                            | :heavy_check_mark:                                                                                               | The context to use for the request.                                                                              |                                                                                                                  |
| `id`                                                                                                             | `string`                                                                                                         | :heavy_check_mark:                                                                                               | N/A                                                                                                              | chatcmpl-abc123def456                                                                                            |
| `body`                                                                                                           | [operations.UpdateCompletionFeedbackRequestBody](../../models/operations/updatecompletionfeedbackrequestbody.md) | :heavy_check_mark:                                                                                               | N/A                                                                                                              |                                                                                                                  |
| `xOnBehalfOf`                                                                                                    | `*string`                                                                                                        | :heavy_minus_sign:                                                                                               | Optional external end-user identifier forwarded by the API gateway.                                              |                                                                                                                  |
| `opts`                                                                                                           | [][operations.Option](../../models/operations/option.md)                                                         | :heavy_minus_sign:                                                                                               | The options for this request.                                                                                    |                                                                                                                  |

### Response

**[*operations.UpdateCompletionFeedbackResponse](../../models/operations/updatecompletionfeedbackresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## BatchGetCompletionFeedback

Retrieves feedback for multiple chat completions in a single batch request.

### Example Usage

<!-- UsageSnippet language="go" operationID="batchGetCompletionFeedback" method="post" path="/api/v1/llm/feedback/completions/batch" -->
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

    res, err := s.Llm.Feedback.BatchGetCompletionFeedback(ctx, components.BatchGetFeedbackRequest{
        Ids: []string{
            "chatcmpl-abc123def456",
            "chatcmpl-missing123",
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.BatchGetFeedbackResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              | Example                                                                                  |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |                                                                                          |
| `body`                                                                                   | [components.BatchGetFeedbackRequest](../../models/components/batchgetfeedbackrequest.md) | :heavy_check_mark:                                                                       | N/A                                                                                      | {<br/>"ids": [<br/>"chatcmpl-abc123",<br/>"chatcmpl-def456",<br/>"resp-xyz789"<br/>]<br/>} |
| `xOnBehalfOf`                                                                            | `*string`                                                                                | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |                                                                                          |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |                                                                                          |

### Response

**[*operations.BatchGetCompletionFeedbackResponse](../../models/operations/batchgetcompletionfeedbackresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateResponseFeedback

Submit user feedback for a specific agent response to track satisfaction and model performance. Each response can only receive feedback once.

### Example Usage

<!-- UsageSnippet language="go" operationID="createResponseFeedback" method="post" path="/api/v1/llm/feedback/responses" -->
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

    res, err := s.Llm.Feedback.CreateResponseFeedback(ctx, components.CreateFeedbackRequest{
        ID: "resp-xyz789",
        Rating: components.CreateFeedbackRequestRatingThumbsDown.ToPointer(),
        Description: mka1.Pointer("The response missed key details."),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.CreateFeedbackResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       | Example                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                             | [context.Context](https://pkg.go.dev/context#Context)                                                             | :heavy_check_mark:                                                                                                | The context to use for the request.                                                                               |                                                                                                                   |
| `body`                                                                                                            | [components.CreateFeedbackRequest](../../models/components/createfeedbackrequest.md)                              | :heavy_check_mark:                                                                                                | N/A                                                                                                               | {<br/>"id": "chatcmpl-abc123def456",<br/>"rating": "thumbs_up",<br/>"description": "The response was accurate and helpful."<br/>} |
| `xOnBehalfOf`                                                                                                     | `*string`                                                                                                         | :heavy_minus_sign:                                                                                                | Optional external end-user identifier forwarded by the API gateway.                                               |                                                                                                                   |
| `opts`                                                                                                            | [][operations.Option](../../models/operations/option.md)                                                          | :heavy_minus_sign:                                                                                                | The options for this request.                                                                                     |                                                                                                                   |

### Response

**[*operations.CreateResponseFeedbackResponse](../../models/operations/createresponsefeedbackresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListResponseFeedback

Retrieves a paginated list of feedback entries recorded on the caller's agent responses, ordered by the response's creation date. Supports filtering by rating. An `after` cursor that no longer resolves to a response visible to the caller — including responses that have since been deleted — returns 400; restart pagination from the first page.

### Example Usage

<!-- UsageSnippet language="go" operationID="listResponseFeedback" method="get" path="/api/v1/llm/feedback/responses" -->
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

    res, err := s.Llm.Feedback.ListResponseFeedback(ctx, operations.ListResponseFeedbackRequest{
        After: mka1.Pointer("resp-xyz789"),
        Limit: mka1.Pointer[int64](25),
        Rating: operations.ListResponseFeedbackRatingThumbsDown.ToPointer(),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ListFeedbackResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                            | :heavy_check_mark:                                                                               | The context to use for the request.                                                              |
| `request`                                                                                        | [operations.ListResponseFeedbackRequest](../../models/operations/listresponsefeedbackrequest.md) | :heavy_check_mark:                                                                               | The request object to use for the request.                                                       |
| `opts`                                                                                           | [][operations.Option](../../models/operations/option.md)                                         | :heavy_minus_sign:                                                                               | The options for this request.                                                                    |

### Response

**[*operations.ListResponseFeedbackResponse](../../models/operations/listresponsefeedbackresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetResponseFeedback

Retrieves the existing feedback rating and description for a specific agent response.

### Example Usage

<!-- UsageSnippet language="go" operationID="getResponseFeedback" method="get" path="/api/v1/llm/feedback/responses/{id}" -->
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

    res, err := s.Llm.Feedback.GetResponseFeedback(ctx, "resp-xyz789", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.GetFeedbackResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `id`                                                                | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | resp-xyz789                                                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetResponseFeedbackResponse](../../models/operations/getresponsefeedbackresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## UpdateResponseFeedback

Updates or modifies existing feedback for a specific agent response. Useful for allowing users to revise their initial submissions.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateResponseFeedback" method="put" path="/api/v1/llm/feedback/responses/{id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Feedback.UpdateResponseFeedback(ctx, "resp-xyz789", operations.UpdateResponseFeedbackRequestBody{
        Rating: optionalnullable.From(mka1.Pointer(operations.UpdateResponseFeedbackRatingThumbsUp)),
        Description: optionalnullable.From(mka1.Pointer("Updated after retry, now good.")),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.UpdateFeedbackResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                    | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  | Example                                                                                                      |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                                        | :heavy_check_mark:                                                                                           | The context to use for the request.                                                                          |                                                                                                              |
| `id`                                                                                                         | `string`                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          | resp-xyz789                                                                                                  |
| `body`                                                                                                       | [operations.UpdateResponseFeedbackRequestBody](../../models/operations/updateresponsefeedbackrequestbody.md) | :heavy_check_mark:                                                                                           | N/A                                                                                                          |                                                                                                              |
| `xOnBehalfOf`                                                                                                | `*string`                                                                                                    | :heavy_minus_sign:                                                                                           | Optional external end-user identifier forwarded by the API gateway.                                          |                                                                                                              |
| `opts`                                                                                                       | [][operations.Option](../../models/operations/option.md)                                                     | :heavy_minus_sign:                                                                                           | The options for this request.                                                                                |                                                                                                              |

### Response

**[*operations.UpdateResponseFeedbackResponse](../../models/operations/updateresponsefeedbackresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## BatchGetResponseFeedback

Retrieves feedback for multiple agent responses in a single batch request.

### Example Usage

<!-- UsageSnippet language="go" operationID="batchGetResponseFeedback" method="post" path="/api/v1/llm/feedback/responses/batch" -->
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

    res, err := s.Llm.Feedback.BatchGetResponseFeedback(ctx, components.BatchGetFeedbackRequest{
        Ids: []string{
            "resp-xyz789",
            "resp-missing123",
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.BatchGetFeedbackResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              | Example                                                                                  |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |                                                                                          |
| `body`                                                                                   | [components.BatchGetFeedbackRequest](../../models/components/batchgetfeedbackrequest.md) | :heavy_check_mark:                                                                       | N/A                                                                                      | {<br/>"ids": [<br/>"chatcmpl-abc123",<br/>"chatcmpl-def456",<br/>"resp-xyz789"<br/>]<br/>} |
| `xOnBehalfOf`                                                                            | `*string`                                                                                | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |                                                                                          |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |                                                                                          |

### Response

**[*operations.BatchGetResponseFeedbackResponse](../../models/operations/batchgetresponsefeedbackresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ExportCompletionFeedback

Synchronously exports the completion feedback entries visible to the caller as a CSV file, ordered by the creation date of the underlying request. Visibility matches the list endpoint: callers see their own feedback; org owners and admins see their whole team. Supports filtering by rating. The export is capped at 50,000 rows; when the cap is hit the response carries an X-Export-Truncated header and older rows (with the default descending order) are omitted.

### Example Usage

<!-- UsageSnippet language="go" operationID="exportCompletionFeedback" method="get" path="/api/v1/llm/feedback/export/completions" -->
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

    res, err := s.Llm.Feedback.ExportCompletionFeedback(ctx, operations.ExportCompletionFeedbackOrderDesc.ToPointer(), operations.ExportCompletionFeedbackRatingThumbsUp.ToPointer(), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ResponseStream != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                                                                       | Type                                                                                                                                                                            | Required                                                                                                                                                                        | Description                                                                                                                                                                     | Example                                                                                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                                                                           | [context.Context](https://pkg.go.dev/context#Context)                                                                                                                           | :heavy_check_mark:                                                                                                                                                              | The context to use for the request.                                                                                                                                             |                                                                                                                                                                                 |
| `order`                                                                                                                                                                         | [*operations.ExportCompletionFeedbackOrder](../../models/operations/exportcompletionfeedbackorder.md)                                                                           | :heavy_minus_sign:                                                                                                                                                              | The order to export feedback entries in by creation date of the underlying request. 'asc' exports oldest first, 'desc' exports newest first. Defaults to 'desc' (newest first). | desc                                                                                                                                                                            |
| `rating`                                                                                                                                                                        | [*operations.ExportCompletionFeedbackRating](../../models/operations/exportcompletionfeedbackrating.md)                                                                         | :heavy_minus_sign:                                                                                                                                                              | Only export feedback entries with this rating. Omit to export entries with any rating.                                                                                          | thumbs_up                                                                                                                                                                       |
| `xOnBehalfOf`                                                                                                                                                                   | `*string`                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                                                                                             |                                                                                                                                                                                 |
| `opts`                                                                                                                                                                          | [][operations.Option](../../models/operations/option.md)                                                                                                                        | :heavy_minus_sign:                                                                                                                                                              | The options for this request.                                                                                                                                                   |                                                                                                                                                                                 |

### Response

**[*operations.ExportCompletionFeedbackResponse](../../models/operations/exportcompletionfeedbackresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ExportResponseFeedback

Synchronously exports the response feedback entries visible to the caller as a CSV file, ordered by the creation date of the underlying request. Visibility matches the list endpoint: callers see their own feedback; org owners and admins see their whole team. Supports filtering by rating. The export is capped at 50,000 rows; when the cap is hit the response carries an X-Export-Truncated header and older rows (with the default descending order) are omitted.

### Example Usage

<!-- UsageSnippet language="go" operationID="exportResponseFeedback" method="get" path="/api/v1/llm/feedback/export/responses" -->
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

    res, err := s.Llm.Feedback.ExportResponseFeedback(ctx, operations.ExportResponseFeedbackOrderDesc.ToPointer(), operations.ExportResponseFeedbackRatingThumbsUp.ToPointer(), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ResponseStream != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                                                                       | Type                                                                                                                                                                            | Required                                                                                                                                                                        | Description                                                                                                                                                                     | Example                                                                                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                                                                           | [context.Context](https://pkg.go.dev/context#Context)                                                                                                                           | :heavy_check_mark:                                                                                                                                                              | The context to use for the request.                                                                                                                                             |                                                                                                                                                                                 |
| `order`                                                                                                                                                                         | [*operations.ExportResponseFeedbackOrder](../../models/operations/exportresponsefeedbackorder.md)                                                                               | :heavy_minus_sign:                                                                                                                                                              | The order to export feedback entries in by creation date of the underlying request. 'asc' exports oldest first, 'desc' exports newest first. Defaults to 'desc' (newest first). | desc                                                                                                                                                                            |
| `rating`                                                                                                                                                                        | [*operations.ExportResponseFeedbackRating](../../models/operations/exportresponsefeedbackrating.md)                                                                             | :heavy_minus_sign:                                                                                                                                                              | Only export feedback entries with this rating. Omit to export entries with any rating.                                                                                          | thumbs_up                                                                                                                                                                       |
| `xOnBehalfOf`                                                                                                                                                                   | `*string`                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                                                                                             |                                                                                                                                                                                 |
| `opts`                                                                                                                                                                          | [][operations.Option](../../models/operations/option.md)                                                                                                                        | :heavy_minus_sign:                                                                                                                                                              | The options for this request.                                                                                                                                                   |                                                                                                                                                                                 |

### Response

**[*operations.ExportResponseFeedbackResponse](../../models/operations/exportresponsefeedbackresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## StartExport

Starts a background job to export all feedback data across every tenant to parquet files in S3/R2. Only one export can run simultaneously. Restricted to cluster administrators.

### Example Usage

<!-- UsageSnippet language="go" operationID="startExportFeedback" method="post" path="/api/v1/llm/feedback/export" -->
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

    res, err := s.Llm.Feedback.StartExport(ctx)
    if err != nil {
        log.Fatal(err)
    }
    if res.StartExportFeedbackResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.StartExportFeedbackResponse](../../models/operations/startexportfeedbackresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetExportStatus

Checks the status and progress of the currently running or most recently completed feedback export job. Restricted to cluster administrators.

### Example Usage

<!-- UsageSnippet language="go" operationID="getExportStatus" method="get" path="/api/v1/llm/feedback/export/status" -->
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

    res, err := s.Llm.Feedback.GetExportStatus(ctx)
    if err != nil {
        log.Fatal(err)
    }
    if res.GetExportStatusResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.GetExportStatusResponse](../../models/operations/getexportstatusresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |