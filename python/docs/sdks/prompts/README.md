# Llm.Prompts

## Overview

### Available Operations

* [create](#create) - Create a prompt
* [list](#list) - List prompts
* [get](#get) - Get a prompt
* [update](#update) - Update a prompt
* [delete](#delete) - Delete a prompt
* [create_version](#create_version) - Create a new version
* [list_versions](#list_versions) - List versions
* [get_version](#get_version) - Get a specific version
* [rollback](#rollback) - Rollback to a version

## create

Creates a new prompt with its first version. The template supports {{variable}} placeholders.

### Example Usage

<!-- UsageSnippet language="python" operationID="createPrompt" method="post" path="/api/v1/llm/prompts" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.prompts.create(name="Customer Support Classifier", template="Classify the following customer message into one of these categories: {{categories}}\n\nMessage: {{message}}", description="Classifies incoming customer messages by intent")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `name`                                                              | *str*                                                               | :heavy_check_mark:                                                  | Human-readable prompt name                                          |
| `template`                                                          | *str*                                                               | :heavy_check_mark:                                                  | The prompt template text with {{variable}} placeholders             |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `description`                                                       | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Detailed description of the prompt                                  |
| `metadata`                                                          | Dict[str, *Any*]                                                    | :heavy_minus_sign:                                                  | Custom metadata key-value pairs                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.CreatePromptResponse](../../models/createpromptresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list

Returns a paginated list of prompts owned by the authenticated user.

### Example Usage

<!-- UsageSnippet language="python" operationID="listPrompts" method="get" path="/api/v1/llm/prompts" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.prompts.list(limit=20, order="desc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `limit`                                                               | *Optional[int]*                                                       | :heavy_minus_sign:                                                    | N/A                                                                   |
| `after`                                                               | *Optional[str]*                                                       | :heavy_minus_sign:                                                    | N/A                                                                   |
| `order`                                                               | [Optional[models.ListPromptsOrder]](../../models/listpromptsorder.md) | :heavy_minus_sign:                                                    | Sort order by creation date                                           |
| `x_on_behalf_of`                                                      | *Optional[str]*                                                       | :heavy_minus_sign:                                                    | Optional external end-user identifier forwarded by the API gateway.   |
| `retries`                                                             | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)      | :heavy_minus_sign:                                                    | Configuration to override the default retry behavior of the client.   |

### Response

**[models.ListPromptsResponse](../../models/listpromptsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get

Retrieves a prompt by its ID, including the active template. Pass `version` to get a specific version's template. Pass `variables` as a JSON-encoded map to render the template with substitutions.

### Example Usage

<!-- UsageSnippet language="python" operationID="getPrompt" method="get" path="/api/v1/llm/prompts/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.prompts.get(id="prompt_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | prompt_aa87e2b1112a455b8deabed784372198                             |
| `version`                                                           | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `variables`                                                         | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.GetPromptResponse](../../models/getpromptresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update

Updates prompt metadata. To update the template content, create a new version instead.

### Example Usage

<!-- UsageSnippet language="python" operationID="updatePrompt" method="put" path="/api/v1/llm/prompts/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.prompts.update(id="prompt_aa87e2b1112a455b8deabed784372198", name="Customer Support Classifier v2")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | prompt_aa87e2b1112a455b8deabed784372198                             |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `name`                                                              | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Updated prompt name                                                 |                                                                     |
| `description`                                                       | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | Updated description — pass null to clear                            |                                                                     |
| `metadata`                                                          | Dict[str, *Any*]                                                    | :heavy_minus_sign:                                                  | Updated metadata — replaces existing                                |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.UpdatePromptResponse](../../models/updatepromptresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete

Deletes a prompt and all its versions.

### Example Usage

<!-- UsageSnippet language="python" operationID="deletePrompt" method="delete" path="/api/v1/llm/prompts/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.prompts.delete(id="prompt_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | prompt_aa87e2b1112a455b8deabed784372198                             |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.DeletePromptResponse](../../models/deletepromptresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_version

Creates a new version of a prompt. The new version automatically becomes the active version. Fields not provided are carried forward from the previous version.

### Example Usage

<!-- UsageSnippet language="python" operationID="createPromptVersion" method="post" path="/api/v1/llm/prompts/{id}/versions" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.prompts.create_version(id="prompt_aa87e2b1112a455b8deabed784372198", template="You are a customer support classifier. Classify the message into: {{categories}}\n\nRespond with only the category name.\n\nMessage: {{message}}")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | prompt_aa87e2b1112a455b8deabed784372198                             |
| `template`                                                          | *str*                                                               | :heavy_check_mark:                                                  | The prompt template text                                            |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.CreateVersionResponse](../../models/createversionresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_versions

Returns the version history of a prompt, ordered by version number.

### Example Usage

<!-- UsageSnippet language="python" operationID="listPromptVersions" method="get" path="/api/v1/llm/prompts/{id}/versions" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.prompts.list_versions(id="prompt_aa87e2b1112a455b8deabed784372198", limit=20, order="desc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         | Example                                                                             |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `id`                                                                                | *str*                                                                               | :heavy_check_mark:                                                                  | N/A                                                                                 | prompt_aa87e2b1112a455b8deabed784372198                                             |
| `limit`                                                                             | *Optional[int]*                                                                     | :heavy_minus_sign:                                                                  | N/A                                                                                 |                                                                                     |
| `order`                                                                             | [Optional[models.ListPromptVersionsOrder]](../../models/listpromptversionsorder.md) | :heavy_minus_sign:                                                                  | Sort order by version number                                                        |                                                                                     |
| `x_on_behalf_of`                                                                    | *Optional[str]*                                                                     | :heavy_minus_sign:                                                                  | Optional external end-user identifier forwarded by the API gateway.                 |                                                                                     |
| `retries`                                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                    | :heavy_minus_sign:                                                                  | Configuration to override the default retry behavior of the client.                 |                                                                                     |

### Response

**[models.ListVersionsResponse](../../models/listversionsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_version

Retrieves a specific version of a prompt by version number.

### Example Usage

<!-- UsageSnippet language="python" operationID="getPromptVersion" method="get" path="/api/v1/llm/prompts/{id}/versions/{version}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.prompts.get_version(id="prompt_aa87e2b1112a455b8deabed784372198", version=1)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | prompt_aa87e2b1112a455b8deabed784372198                             |
| `version`                                                           | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | 1                                                                   |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.CreateVersionResponse](../../models/createversionresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## rollback

Sets the active version of a prompt to a previous version. This does not delete newer versions — it only changes which version is active.

### Example Usage

<!-- UsageSnippet language="python" operationID="rollbackPrompt" method="post" path="/api/v1/llm/prompts/{id}/rollback" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.prompts.rollback(id="prompt_aa87e2b1112a455b8deabed784372198", version=1)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | prompt_aa87e2b1112a455b8deabed784372198                             |
| `version`                                                           | *int*                                                               | :heavy_check_mark:                                                  | Version number to rollback to                                       |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.UpdatePromptResponse](../../models/updatepromptresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |