# Llm.Feedback

## Overview

### Available Operations

* [create_completion_feedback](#create_completion_feedback) - Submit feedback for chat completion
* [list_completion_feedback](#list_completion_feedback) - List chat completion feedback
* [get_completion_feedback](#get_completion_feedback) - Retrieve feedback by completion ID
* [update_completion_feedback](#update_completion_feedback) - Update existing completion feedback
* [batch_get_completion_feedback](#batch_get_completion_feedback) - Batch retrieve feedback for multiple completions
* [create_response_feedback](#create_response_feedback) - Submit feedback for response
* [list_response_feedback](#list_response_feedback) - List response feedback
* [get_response_feedback](#get_response_feedback) - Retrieve feedback by response ID
* [update_response_feedback](#update_response_feedback) - Update existing response feedback
* [batch_get_response_feedback](#batch_get_response_feedback) - Batch retrieve feedback for multiple responses
* [export_completion_feedback](#export_completion_feedback) - Export completion feedback as CSV
* [export_response_feedback](#export_response_feedback) - Export response feedback as CSV
* [start_export](#start_export) - Start feedback export
* [get_export_status](#get_export_status) - Get feedback export status

## create_completion_feedback

Submit user feedback for a specific chat completion to track satisfaction and model performance. Each completion can only receive feedback once.

### Example Usage

<!-- UsageSnippet language="python" operationID="createCompletionFeedback" method="post" path="/api/v1/llm/feedback/completions" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.feedback.create_completion_feedback(id="chatcmpl-abc123def456", rating="thumbs_up", description="The response was accurate and helpful.")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                | Type                                                                                                                                     | Required                                                                                                                                 | Description                                                                                                                              |
| ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                                     | *str*                                                                                                                                    | :heavy_check_mark:                                                                                                                       | Request ID to associate this feedback with. Use chat completion request ID or response ID.                                               |
| `x_on_behalf_of`                                                                                                                         | *Optional[str]*                                                                                                                          | :heavy_minus_sign:                                                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                                                      |
| `rating`                                                                                                                                 | [Optional[models.CreateFeedbackRequestRating]](../../models/createfeedbackrequestrating.md)                                              | :heavy_minus_sign:                                                                                                                       | Optional feedback rating. Can be 'thumbs_up' for positive feedback or 'thumbs_down' for negative feedback.                               |
| `description`                                                                                                                            | *Optional[str]*                                                                                                                          | :heavy_minus_sign:                                                                                                                       | Optional detailed feedback description. Use this to provide specific comments, suggestions, or explain the rating (max 2000 characters). |
| `retries`                                                                                                                                | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                         | :heavy_minus_sign:                                                                                                                       | Configuration to override the default retry behavior of the client.                                                                      |

### Response

**[models.CreateFeedbackResponse](../../models/createfeedbackresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_completion_feedback

Retrieves a paginated list of feedback entries recorded on the caller's chat completions, ordered by the completion's creation date. Supports filtering by rating. An `after` cursor that no longer resolves to a completion visible to the caller returns 400; restart pagination from the first page.

### Example Usage

<!-- UsageSnippet language="python" operationID="listCompletionFeedback" method="get" path="/api/v1/llm/feedback/completions" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.feedback.list_completion_feedback(after="chatcmpl-abc123def456", limit=25, order="desc", rating="thumbs_up")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                       | Type                                                                                                                                                                            | Required                                                                                                                                                                        | Description                                                                                                                                                                     | Example                                                                                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `after`                                                                                                                                                                         | *Optional[str]*                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                              | N/A                                                                                                                                                                             | chatcmpl-abc123def456                                                                                                                                                           |
| `limit`                                                                                                                                                                         | *Optional[int]*                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                              | N/A                                                                                                                                                                             | 25                                                                                                                                                                              |
| `order`                                                                                                                                                                         | [Optional[models.ListCompletionFeedbackOrder]](../../models/listcompletionfeedbackorder.md)                                                                                     | :heavy_minus_sign:                                                                                                                                                              | The order to return feedback entries in by creation date of the underlying request. 'asc' returns oldest first, 'desc' returns newest first. Defaults to 'desc' (newest first). | desc                                                                                                                                                                            |
| `rating`                                                                                                                                                                        | [Optional[models.ListCompletionFeedbackRating]](../../models/listcompletionfeedbackrating.md)                                                                                   | :heavy_minus_sign:                                                                                                                                                              | Only return feedback entries with this rating. Omit to return entries with any rating.                                                                                          | thumbs_up                                                                                                                                                                       |
| `x_on_behalf_of`                                                                                                                                                                | *Optional[str]*                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                                                                                             |                                                                                                                                                                                 |
| `retries`                                                                                                                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                | :heavy_minus_sign:                                                                                                                                                              | Configuration to override the default retry behavior of the client.                                                                                                             |                                                                                                                                                                                 |

### Response

**[models.ListFeedbackResponse](../../models/listfeedbackresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_completion_feedback

Retrieves the existing feedback rating and description for a specific chat completion.

### Example Usage

<!-- UsageSnippet language="python" operationID="getCompletionFeedback" method="get" path="/api/v1/llm/feedback/completions/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.feedback.get_completion_feedback(id="chatcmpl-abc123def456")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | chatcmpl-abc123def456                                               |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.GetFeedbackResponse](../../models/getfeedbackresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update_completion_feedback

Updates or modifies existing feedback for a specific chat completion. Useful for allowing users to revise their initial submissions.

### Example Usage

<!-- UsageSnippet language="python" operationID="updateCompletionFeedback" method="put" path="/api/v1/llm/feedback/completions/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.feedback.update_completion_feedback(id="chatcmpl-abc123def456", rating="thumbs_down", description="Could be more detailed.")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                     | Type                                                                                                                                          | Required                                                                                                                                      | Description                                                                                                                                   | Example                                                                                                                                       |
| --------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                                          | *str*                                                                                                                                         | :heavy_check_mark:                                                                                                                            | N/A                                                                                                                                           | chatcmpl-abc123def456                                                                                                                         |
| `x_on_behalf_of`                                                                                                                              | *Optional[str]*                                                                                                                               | :heavy_minus_sign:                                                                                                                            | Optional external end-user identifier forwarded by the API gateway.                                                                           |                                                                                                                                               |
| `rating`                                                                                                                                      | [OptionalNullable[models.UpdateCompletionFeedbackRating]](../../models/updatecompletionfeedbackrating.md)                                     | :heavy_minus_sign:                                                                                                                            | Update the feedback rating. Pass null to clear the rating. Can be 'thumbs_up' or 'thumbs_down'.                                               |                                                                                                                                               |
| `description`                                                                                                                                 | *OptionalNullable[str]*                                                                                                                       | :heavy_minus_sign:                                                                                                                            | Update the feedback description. Pass null to clear the description. Provide text to update with new feedback comments (max 2000 characters). |                                                                                                                                               |
| `retries`                                                                                                                                     | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                              | :heavy_minus_sign:                                                                                                                            | Configuration to override the default retry behavior of the client.                                                                           |                                                                                                                                               |

### Response

**[models.UpdateFeedbackResponse](../../models/updatefeedbackresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## batch_get_completion_feedback

Retrieves feedback for multiple chat completions in a single batch request.

### Example Usage

<!-- UsageSnippet language="python" operationID="batchGetCompletionFeedback" method="post" path="/api/v1/llm/feedback/completions/batch" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.feedback.batch_get_completion_feedback(ids=[
        "chatcmpl-abc123def456",
        "chatcmpl-missing123",
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `ids`                                                                    | List[*str*]                                                              | :heavy_check_mark:                                                       | Array of request IDs (chatcmpl-xxx or resp-xxx) to retrieve feedback for |
| `x_on_behalf_of`                                                         | *Optional[str]*                                                          | :heavy_minus_sign:                                                       | Optional external end-user identifier forwarded by the API gateway.      |
| `retries`                                                                | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)         | :heavy_minus_sign:                                                       | Configuration to override the default retry behavior of the client.      |

### Response

**[models.BatchGetFeedbackResponse](../../models/batchgetfeedbackresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_response_feedback

Submit user feedback for a specific agent response to track satisfaction and model performance. Each response can only receive feedback once.

### Example Usage

<!-- UsageSnippet language="python" operationID="createResponseFeedback" method="post" path="/api/v1/llm/feedback/responses" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.feedback.create_response_feedback(id="resp-xyz789", rating="thumbs_down", description="The response missed key details.")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                | Type                                                                                                                                     | Required                                                                                                                                 | Description                                                                                                                              |
| ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                                     | *str*                                                                                                                                    | :heavy_check_mark:                                                                                                                       | Request ID to associate this feedback with. Use chat completion request ID or response ID.                                               |
| `x_on_behalf_of`                                                                                                                         | *Optional[str]*                                                                                                                          | :heavy_minus_sign:                                                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                                                      |
| `rating`                                                                                                                                 | [Optional[models.CreateFeedbackRequestRating]](../../models/createfeedbackrequestrating.md)                                              | :heavy_minus_sign:                                                                                                                       | Optional feedback rating. Can be 'thumbs_up' for positive feedback or 'thumbs_down' for negative feedback.                               |
| `description`                                                                                                                            | *Optional[str]*                                                                                                                          | :heavy_minus_sign:                                                                                                                       | Optional detailed feedback description. Use this to provide specific comments, suggestions, or explain the rating (max 2000 characters). |
| `retries`                                                                                                                                | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                         | :heavy_minus_sign:                                                                                                                       | Configuration to override the default retry behavior of the client.                                                                      |

### Response

**[models.CreateFeedbackResponse](../../models/createfeedbackresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_response_feedback

Retrieves a paginated list of feedback entries recorded on the caller's agent responses, ordered by the response's creation date. Supports filtering by rating. An `after` cursor that no longer resolves to a response visible to the caller — including responses that have since been deleted — returns 400; restart pagination from the first page.

### Example Usage

<!-- UsageSnippet language="python" operationID="listResponseFeedback" method="get" path="/api/v1/llm/feedback/responses" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.feedback.list_response_feedback(after="resp-xyz789", limit=25, order="desc", rating="thumbs_down")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                       | Type                                                                                                                                                                            | Required                                                                                                                                                                        | Description                                                                                                                                                                     | Example                                                                                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `after`                                                                                                                                                                         | *Optional[str]*                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                              | N/A                                                                                                                                                                             | resp-xyz789                                                                                                                                                                     |
| `limit`                                                                                                                                                                         | *Optional[int]*                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                              | N/A                                                                                                                                                                             | 25                                                                                                                                                                              |
| `order`                                                                                                                                                                         | [Optional[models.ListResponseFeedbackOrder]](../../models/listresponsefeedbackorder.md)                                                                                         | :heavy_minus_sign:                                                                                                                                                              | The order to return feedback entries in by creation date of the underlying request. 'asc' returns oldest first, 'desc' returns newest first. Defaults to 'desc' (newest first). | desc                                                                                                                                                                            |
| `rating`                                                                                                                                                                        | [Optional[models.ListResponseFeedbackRating]](../../models/listresponsefeedbackrating.md)                                                                                       | :heavy_minus_sign:                                                                                                                                                              | Only return feedback entries with this rating. Omit to return entries with any rating.                                                                                          | thumbs_down                                                                                                                                                                     |
| `x_on_behalf_of`                                                                                                                                                                | *Optional[str]*                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                                                                                             |                                                                                                                                                                                 |
| `retries`                                                                                                                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                | :heavy_minus_sign:                                                                                                                                                              | Configuration to override the default retry behavior of the client.                                                                                                             |                                                                                                                                                                                 |

### Response

**[models.ListFeedbackResponse](../../models/listfeedbackresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_response_feedback

Retrieves the existing feedback rating and description for a specific agent response.

### Example Usage

<!-- UsageSnippet language="python" operationID="getResponseFeedback" method="get" path="/api/v1/llm/feedback/responses/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.feedback.get_response_feedback(id="resp-xyz789")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | resp-xyz789                                                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.GetFeedbackResponse](../../models/getfeedbackresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update_response_feedback

Updates or modifies existing feedback for a specific agent response. Useful for allowing users to revise their initial submissions.

### Example Usage

<!-- UsageSnippet language="python" operationID="updateResponseFeedback" method="put" path="/api/v1/llm/feedback/responses/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.feedback.update_response_feedback(id="resp-xyz789", rating="thumbs_up", description="Updated after retry, now good.")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                     | Type                                                                                                                                          | Required                                                                                                                                      | Description                                                                                                                                   | Example                                                                                                                                       |
| --------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                                          | *str*                                                                                                                                         | :heavy_check_mark:                                                                                                                            | N/A                                                                                                                                           | resp-xyz789                                                                                                                                   |
| `x_on_behalf_of`                                                                                                                              | *Optional[str]*                                                                                                                               | :heavy_minus_sign:                                                                                                                            | Optional external end-user identifier forwarded by the API gateway.                                                                           |                                                                                                                                               |
| `rating`                                                                                                                                      | [OptionalNullable[models.UpdateResponseFeedbackRating]](../../models/updateresponsefeedbackrating.md)                                         | :heavy_minus_sign:                                                                                                                            | Update the feedback rating. Pass null to clear the rating. Can be 'thumbs_up' or 'thumbs_down'.                                               |                                                                                                                                               |
| `description`                                                                                                                                 | *OptionalNullable[str]*                                                                                                                       | :heavy_minus_sign:                                                                                                                            | Update the feedback description. Pass null to clear the description. Provide text to update with new feedback comments (max 2000 characters). |                                                                                                                                               |
| `retries`                                                                                                                                     | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                              | :heavy_minus_sign:                                                                                                                            | Configuration to override the default retry behavior of the client.                                                                           |                                                                                                                                               |

### Response

**[models.UpdateFeedbackResponse](../../models/updatefeedbackresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## batch_get_response_feedback

Retrieves feedback for multiple agent responses in a single batch request.

### Example Usage

<!-- UsageSnippet language="python" operationID="batchGetResponseFeedback" method="post" path="/api/v1/llm/feedback/responses/batch" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.feedback.batch_get_response_feedback(ids=[
        "resp-xyz789",
        "resp-missing123",
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `ids`                                                                    | List[*str*]                                                              | :heavy_check_mark:                                                       | Array of request IDs (chatcmpl-xxx or resp-xxx) to retrieve feedback for |
| `x_on_behalf_of`                                                         | *Optional[str]*                                                          | :heavy_minus_sign:                                                       | Optional external end-user identifier forwarded by the API gateway.      |
| `retries`                                                                | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)         | :heavy_minus_sign:                                                       | Configuration to override the default retry behavior of the client.      |

### Response

**[models.BatchGetFeedbackResponse](../../models/batchgetfeedbackresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## export_completion_feedback

Synchronously exports the completion feedback entries visible to the caller as a CSV file, ordered by the creation date of the underlying request. Visibility matches the list endpoint: callers see their own feedback; org owners and admins see their whole team. Supports filtering by rating. The export is capped at 50,000 rows; when the cap is hit the response carries an X-Export-Truncated header and older rows (with the default descending order) are omitted.

### Example Usage

<!-- UsageSnippet language="python" operationID="exportCompletionFeedback" method="get" path="/api/v1/llm/feedback/export/completions" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.feedback.export_completion_feedback(order="desc", rating="thumbs_up")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                       | Type                                                                                                                                                                            | Required                                                                                                                                                                        | Description                                                                                                                                                                     | Example                                                                                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `order`                                                                                                                                                                         | [Optional[models.ExportCompletionFeedbackOrder]](../../models/exportcompletionfeedbackorder.md)                                                                                 | :heavy_minus_sign:                                                                                                                                                              | The order to export feedback entries in by creation date of the underlying request. 'asc' exports oldest first, 'desc' exports newest first. Defaults to 'desc' (newest first). | desc                                                                                                                                                                            |
| `rating`                                                                                                                                                                        | [Optional[models.ExportCompletionFeedbackRating]](../../models/exportcompletionfeedbackrating.md)                                                                               | :heavy_minus_sign:                                                                                                                                                              | Only export feedback entries with this rating. Omit to export entries with any rating.                                                                                          | thumbs_up                                                                                                                                                                       |
| `x_on_behalf_of`                                                                                                                                                                | *Optional[str]*                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                                                                                             |                                                                                                                                                                                 |
| `retries`                                                                                                                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                | :heavy_minus_sign:                                                                                                                                                              | Configuration to override the default retry behavior of the client.                                                                                                             |                                                                                                                                                                                 |

### Response

**[models.ExportCompletionFeedbackResponse](../../models/exportcompletionfeedbackresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## export_response_feedback

Synchronously exports the response feedback entries visible to the caller as a CSV file, ordered by the creation date of the underlying request. Visibility matches the list endpoint: callers see their own feedback; org owners and admins see their whole team. Supports filtering by rating. The export is capped at 50,000 rows; when the cap is hit the response carries an X-Export-Truncated header and older rows (with the default descending order) are omitted.

### Example Usage

<!-- UsageSnippet language="python" operationID="exportResponseFeedback" method="get" path="/api/v1/llm/feedback/export/responses" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.feedback.export_response_feedback(order="desc", rating="thumbs_up")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                       | Type                                                                                                                                                                            | Required                                                                                                                                                                        | Description                                                                                                                                                                     | Example                                                                                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `order`                                                                                                                                                                         | [Optional[models.ExportResponseFeedbackOrder]](../../models/exportresponsefeedbackorder.md)                                                                                     | :heavy_minus_sign:                                                                                                                                                              | The order to export feedback entries in by creation date of the underlying request. 'asc' exports oldest first, 'desc' exports newest first. Defaults to 'desc' (newest first). | desc                                                                                                                                                                            |
| `rating`                                                                                                                                                                        | [Optional[models.ExportResponseFeedbackRating]](../../models/exportresponsefeedbackrating.md)                                                                                   | :heavy_minus_sign:                                                                                                                                                              | Only export feedback entries with this rating. Omit to export entries with any rating.                                                                                          | thumbs_up                                                                                                                                                                       |
| `x_on_behalf_of`                                                                                                                                                                | *Optional[str]*                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                                                                                             |                                                                                                                                                                                 |
| `retries`                                                                                                                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                | :heavy_minus_sign:                                                                                                                                                              | Configuration to override the default retry behavior of the client.                                                                                                             |                                                                                                                                                                                 |

### Response

**[models.ExportResponseFeedbackResponse](../../models/exportresponsefeedbackresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## start_export

Starts a background job to export all feedback data across every tenant to parquet files in S3/R2. Only one export can run simultaneously. Restricted to cluster administrators.

### Example Usage

<!-- UsageSnippet language="python" operationID="startExportFeedback" method="post" path="/api/v1/llm/feedback/export" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.feedback.start_export()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.StartExportFeedbackResponse](../../models/startexportfeedbackresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_export_status

Checks the status and progress of the currently running or most recently completed feedback export job. Restricted to cluster administrators.

### Example Usage

<!-- UsageSnippet language="python" operationID="getExportStatus" method="get" path="/api/v1/llm/feedback/export/status" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.feedback.get_export_status()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetExportStatusResponse](../../models/getexportstatusresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |