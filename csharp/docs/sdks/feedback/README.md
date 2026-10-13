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

<!-- UsageSnippet language="csharp" operationID="createCompletionFeedback" method="post" path="/api/v1/llm/feedback/completions" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Feedback.CreateCompletionFeedbackAsync(body: new CreateFeedbackRequest() {
    Id = "chatcmpl-abc123def456",
    Rating = CreateFeedbackRequestRating.ThumbsUp,
    Description = "The response was accurate and helpful.",
});

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       | Example                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `Body`                                                                                                            | [CreateFeedbackRequest](../../Types/Components/CreateFeedbackRequest.md)                                          | :heavy_check_mark:                                                                                                | N/A                                                                                                               | {<br/>"id": "chatcmpl-abc123def456",<br/>"rating": "thumbs_up",<br/>"description": "The response was accurate and helpful."<br/>} |
| `XOnBehalfOf`                                                                                                     | *string*                                                                                                          | :heavy_minus_sign:                                                                                                | Optional external end-user identifier forwarded by the API gateway.                                               |                                                                                                                   |

### Response

**[CreateCompletionFeedbackResponse](../../Types/Requests/CreateCompletionFeedbackResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListCompletionFeedback

Retrieves a paginated list of feedback entries recorded on the caller's chat completions, ordered by the completion's creation date. Supports filtering by rating. An `after` cursor that no longer resolves to a completion visible to the caller returns 400; restart pagination from the first page.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCompletionFeedback" method="get" path="/api/v1/llm/feedback/completions" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListCompletionFeedbackRequest req = new ListCompletionFeedbackRequest() {
    After = "chatcmpl-abc123def456",
    Limit = 25,
    Rating = ListCompletionFeedbackRating.ThumbsUp,
};

var res = await sdk.Llm.Feedback.ListCompletionFeedbackAsync(req);

// handle response
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `request`                                                                              | [ListCompletionFeedbackRequest](../../Types/Requests/ListCompletionFeedbackRequest.md) | :heavy_check_mark:                                                                     | The request object to use for the request.                                             |

### Response

**[ListCompletionFeedbackResponse](../../Types/Requests/ListCompletionFeedbackResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetCompletionFeedback

Retrieves the existing feedback rating and description for a specific chat completion.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCompletionFeedback" method="get" path="/api/v1/llm/feedback/completions/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Feedback.GetCompletionFeedbackAsync(id: "chatcmpl-abc123def456");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | chatcmpl-abc123def456                                               |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetCompletionFeedbackResponse](../../Types/Requests/GetCompletionFeedbackResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## UpdateCompletionFeedback

Updates or modifies existing feedback for a specific chat completion. Useful for allowing users to revise their initial submissions.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCompletionFeedback" method="put" path="/api/v1/llm/feedback/completions/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Feedback.UpdateCompletionFeedbackAsync(
    id: "chatcmpl-abc123def456",
    body: new UpdateCompletionFeedbackRequestBody() {
        Rating = UpdateCompletionFeedbackRating.ThumbsDown,
        Description = "Could be more detailed.",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        | Example                                                                                            |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `Id`                                                                                               | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                | chatcmpl-abc123def456                                                                              |
| `Body`                                                                                             | [UpdateCompletionFeedbackRequestBody](../../Types/Requests/UpdateCompletionFeedbackRequestBody.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |                                                                                                    |
| `XOnBehalfOf`                                                                                      | *string*                                                                                           | :heavy_minus_sign:                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                |                                                                                                    |

### Response

**[UpdateCompletionFeedbackResponse](../../Types/Requests/UpdateCompletionFeedbackResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## BatchGetCompletionFeedback

Retrieves feedback for multiple chat completions in a single batch request.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="batchGetCompletionFeedback" method="post" path="/api/v1/llm/feedback/completions/batch" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Feedback.BatchGetCompletionFeedbackAsync(body: new BatchGetFeedbackRequest() {
    Ids = new List<string>() {
        "chatcmpl-abc123def456",
        "chatcmpl-missing123",
    },
});

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  | Example                                                                      |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `Body`                                                                       | [BatchGetFeedbackRequest](../../Types/Components/BatchGetFeedbackRequest.md) | :heavy_check_mark:                                                           | N/A                                                                          | {<br/>"ids": [<br/>"chatcmpl-abc123",<br/>"chatcmpl-def456",<br/>"resp-xyz789"<br/>]<br/>} |
| `XOnBehalfOf`                                                                | *string*                                                                     | :heavy_minus_sign:                                                           | Optional external end-user identifier forwarded by the API gateway.          |                                                                              |

### Response

**[BatchGetCompletionFeedbackResponse](../../Types/Requests/BatchGetCompletionFeedbackResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateResponseFeedback

Submit user feedback for a specific agent response to track satisfaction and model performance. Each response can only receive feedback once.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createResponseFeedback" method="post" path="/api/v1/llm/feedback/responses" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Feedback.CreateResponseFeedbackAsync(body: new CreateFeedbackRequest() {
    Id = "resp-xyz789",
    Rating = CreateFeedbackRequestRating.ThumbsDown,
    Description = "The response missed key details.",
});

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       | Example                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `Body`                                                                                                            | [CreateFeedbackRequest](../../Types/Components/CreateFeedbackRequest.md)                                          | :heavy_check_mark:                                                                                                | N/A                                                                                                               | {<br/>"id": "chatcmpl-abc123def456",<br/>"rating": "thumbs_up",<br/>"description": "The response was accurate and helpful."<br/>} |
| `XOnBehalfOf`                                                                                                     | *string*                                                                                                          | :heavy_minus_sign:                                                                                                | Optional external end-user identifier forwarded by the API gateway.                                               |                                                                                                                   |

### Response

**[CreateResponseFeedbackResponse](../../Types/Requests/CreateResponseFeedbackResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListResponseFeedback

Retrieves a paginated list of feedback entries recorded on the caller's agent responses, ordered by the response's creation date. Supports filtering by rating. An `after` cursor that no longer resolves to a response visible to the caller — including responses that have since been deleted — returns 400; restart pagination from the first page.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listResponseFeedback" method="get" path="/api/v1/llm/feedback/responses" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListResponseFeedbackRequest req = new ListResponseFeedbackRequest() {
    After = "resp-xyz789",
    Limit = 25,
    Rating = ListResponseFeedbackRating.ThumbsDown,
};

var res = await sdk.Llm.Feedback.ListResponseFeedbackAsync(req);

// handle response
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `request`                                                                          | [ListResponseFeedbackRequest](../../Types/Requests/ListResponseFeedbackRequest.md) | :heavy_check_mark:                                                                 | The request object to use for the request.                                         |

### Response

**[ListResponseFeedbackResponse](../../Types/Requests/ListResponseFeedbackResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetResponseFeedback

Retrieves the existing feedback rating and description for a specific agent response.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getResponseFeedback" method="get" path="/api/v1/llm/feedback/responses/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Feedback.GetResponseFeedbackAsync(id: "resp-xyz789");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | resp-xyz789                                                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetResponseFeedbackResponse](../../Types/Requests/GetResponseFeedbackResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## UpdateResponseFeedback

Updates or modifies existing feedback for a specific agent response. Useful for allowing users to revise their initial submissions.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateResponseFeedback" method="put" path="/api/v1/llm/feedback/responses/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Feedback.UpdateResponseFeedbackAsync(
    id: "resp-xyz789",
    body: new UpdateResponseFeedbackRequestBody() {
        Rating = UpdateResponseFeedbackRating.ThumbsUp,
        Description = "Updated after retry, now good.",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    | Example                                                                                        |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `Id`                                                                                           | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            | resp-xyz789                                                                                    |
| `Body`                                                                                         | [UpdateResponseFeedbackRequestBody](../../Types/Requests/UpdateResponseFeedbackRequestBody.md) | :heavy_check_mark:                                                                             | N/A                                                                                            |                                                                                                |
| `XOnBehalfOf`                                                                                  | *string*                                                                                       | :heavy_minus_sign:                                                                             | Optional external end-user identifier forwarded by the API gateway.                            |                                                                                                |

### Response

**[UpdateResponseFeedbackResponse](../../Types/Requests/UpdateResponseFeedbackResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## BatchGetResponseFeedback

Retrieves feedback for multiple agent responses in a single batch request.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="batchGetResponseFeedback" method="post" path="/api/v1/llm/feedback/responses/batch" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Feedback.BatchGetResponseFeedbackAsync(body: new BatchGetFeedbackRequest() {
    Ids = new List<string>() {
        "resp-xyz789",
        "resp-missing123",
    },
});

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  | Example                                                                      |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `Body`                                                                       | [BatchGetFeedbackRequest](../../Types/Components/BatchGetFeedbackRequest.md) | :heavy_check_mark:                                                           | N/A                                                                          | {<br/>"ids": [<br/>"chatcmpl-abc123",<br/>"chatcmpl-def456",<br/>"resp-xyz789"<br/>]<br/>} |
| `XOnBehalfOf`                                                                | *string*                                                                     | :heavy_minus_sign:                                                           | Optional external end-user identifier forwarded by the API gateway.          |                                                                              |

### Response

**[BatchGetResponseFeedbackResponse](../../Types/Requests/BatchGetResponseFeedbackResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ExportCompletionFeedback

Synchronously exports the completion feedback entries visible to the caller as a CSV file, ordered by the creation date of the underlying request. Visibility matches the list endpoint: callers see their own feedback; org owners and admins see their whole team. Supports filtering by rating. The export is capped at 50,000 rows; when the cap is hit the response carries an X-Export-Truncated header and older rows (with the default descending order) are omitted.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="exportCompletionFeedback" method="get" path="/api/v1/llm/feedback/export/completions" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Feedback.ExportCompletionFeedbackAsync(
    order: ExportCompletionFeedbackOrder.Desc,
    rating: ExportCompletionFeedbackRating.ThumbsUp
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                       | Type                                                                                                                                                                            | Required                                                                                                                                                                        | Description                                                                                                                                                                     | Example                                                                                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Order`                                                                                                                                                                         | [ExportCompletionFeedbackOrder](../../Types/Requests/ExportCompletionFeedbackOrder.md)                                                                                          | :heavy_minus_sign:                                                                                                                                                              | The order to export feedback entries in by creation date of the underlying request. 'asc' exports oldest first, 'desc' exports newest first. Defaults to 'desc' (newest first). | desc                                                                                                                                                                            |
| `Rating`                                                                                                                                                                        | [ExportCompletionFeedbackRating](../../Types/Requests/ExportCompletionFeedbackRating.md)                                                                                        | :heavy_minus_sign:                                                                                                                                                              | Only export feedback entries with this rating. Omit to export entries with any rating.                                                                                          | thumbs_up                                                                                                                                                                       |
| `XOnBehalfOf`                                                                                                                                                                   | *string*                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                                                                                             |                                                                                                                                                                                 |

### Response

**[ExportCompletionFeedbackResponse](../../Types/Requests/ExportCompletionFeedbackResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ExportResponseFeedback

Synchronously exports the response feedback entries visible to the caller as a CSV file, ordered by the creation date of the underlying request. Visibility matches the list endpoint: callers see their own feedback; org owners and admins see their whole team. Supports filtering by rating. The export is capped at 50,000 rows; when the cap is hit the response carries an X-Export-Truncated header and older rows (with the default descending order) are omitted.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="exportResponseFeedback" method="get" path="/api/v1/llm/feedback/export/responses" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Feedback.ExportResponseFeedbackAsync(
    order: ExportResponseFeedbackOrder.Desc,
    rating: ExportResponseFeedbackRating.ThumbsUp
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                       | Type                                                                                                                                                                            | Required                                                                                                                                                                        | Description                                                                                                                                                                     | Example                                                                                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Order`                                                                                                                                                                         | [ExportResponseFeedbackOrder](../../Types/Requests/ExportResponseFeedbackOrder.md)                                                                                              | :heavy_minus_sign:                                                                                                                                                              | The order to export feedback entries in by creation date of the underlying request. 'asc' exports oldest first, 'desc' exports newest first. Defaults to 'desc' (newest first). | desc                                                                                                                                                                            |
| `Rating`                                                                                                                                                                        | [ExportResponseFeedbackRating](../../Types/Requests/ExportResponseFeedbackRating.md)                                                                                            | :heavy_minus_sign:                                                                                                                                                              | Only export feedback entries with this rating. Omit to export entries with any rating.                                                                                          | thumbs_up                                                                                                                                                                       |
| `XOnBehalfOf`                                                                                                                                                                   | *string*                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                                                                                             |                                                                                                                                                                                 |

### Response

**[ExportResponseFeedbackResponse](../../Types/Requests/ExportResponseFeedbackResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## StartExport

Starts a background job to export all feedback data across every tenant to parquet files in S3/R2. Only one export can run simultaneously. Restricted to cluster administrators.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="startExportFeedback" method="post" path="/api/v1/llm/feedback/export" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Feedback.StartExportAsync();

// handle response
```

### Response

**[Types.Requests.StartExportFeedbackResponse](../../Types/Requests/StartExportFeedbackResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetExportStatus

Checks the status and progress of the currently running or most recently completed feedback export job. Restricted to cluster administrators.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getExportStatus" method="get" path="/api/v1/llm/feedback/export/status" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Feedback.GetExportStatusAsync();

// handle response
```

### Response

**[Types.Requests.GetExportStatusResponse](../../Types/Requests/GetExportStatusResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |