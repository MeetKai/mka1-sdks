# Datasets

## Overview

### Available Operations

* [list_generators](#list_generators) - List Generators
* [get_generator](#get_generator) - Get Generator
* [quote_generator](#quote_generator) - Quote Generator
* [list_generations](#list_generations) - List Generations
* [create_generation](#create_generation) - Create Generation
* [get_generation](#get_generation) - Get Generation
* [get_generation_logs](#get_generation_logs) - Get Logs
* [get_generation_events](#get_generation_events) - Get Events
* [cancel_generation](#cancel_generation) - Cancel Generation
* [list_formats](#list_formats) - List Formats
* [get_format](#get_format) - Get Format

## list_generators

List Generators

### Example Usage

<!-- UsageSnippet language="python" operationID="list_generators_api_v1_datasets_generators_get" method="get" path="/api/v1/datasets/generators" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.datasets.list_generators()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GeneratorList](../../models/generatorlist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_generator

Get Generator

### Example Usage

<!-- UsageSnippet language="python" operationID="get_generator_api_v1_datasets_generators__generator_id__get" method="get" path="/api/v1/datasets/generators/{generator_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.datasets.get_generator(generator_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `generator_id`                                                      | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GeneratorDetail](../../models/generatordetail.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## quote_generator

Quote Generator

### Example Usage

<!-- UsageSnippet language="python" operationID="quote_generator_api_v1_datasets_generators__generator_id__quote_post" method="post" path="/api/v1/datasets/generators/{generator_id}/quote" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.datasets.quote_generator(generator_id="<id>", params={
        "key": "<value>",
        "key1": "<value>",
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `generator_id`                                                      | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `params`                                                            | Dict[str, *Any*]                                                    | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.QuoteResponse](../../models/quoteresponse.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## list_generations

List Generations

### Example Usage

<!-- UsageSnippet language="python" operationID="list_generations_api_v1_datasets_generations_get" method="get" path="/api/v1/datasets/generations" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.datasets.list_generations(limit=20, order="desc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                           | Type                                                                                                                                | Required                                                                                                                            | Description                                                                                                                         |
| ----------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- |
| `state`                                                                                                                             | [OptionalNullable[models.GenerationState]](../../models/generationstate.md)                                                         | :heavy_minus_sign:                                                                                                                  | N/A                                                                                                                                 |
| `generator_id`                                                                                                                      | *OptionalNullable[str]*                                                                                                             | :heavy_minus_sign:                                                                                                                  | N/A                                                                                                                                 |
| `output_repo`                                                                                                                       | *OptionalNullable[str]*                                                                                                             | :heavy_minus_sign:                                                                                                                  | N/A                                                                                                                                 |
| `created_after`                                                                                                                     | [date](https://docs.python.org/3/library/datetime.html#date-objects)                                                                | :heavy_minus_sign:                                                                                                                  | N/A                                                                                                                                 |
| `created_before`                                                                                                                    | [date](https://docs.python.org/3/library/datetime.html#date-objects)                                                                | :heavy_minus_sign:                                                                                                                  | N/A                                                                                                                                 |
| `limit`                                                                                                                             | *Optional[int]*                                                                                                                     | :heavy_minus_sign:                                                                                                                  | N/A                                                                                                                                 |
| `cursor`                                                                                                                            | *OptionalNullable[str]*                                                                                                             | :heavy_minus_sign:                                                                                                                  | N/A                                                                                                                                 |
| `order`                                                                                                                             | [Optional[models.ListGenerationsAPIV1DatasetsGenerationsGetOrder]](../../models/listgenerationsapiv1datasetsgenerationsgetorder.md) | :heavy_minus_sign:                                                                                                                  | N/A                                                                                                                                 |
| `x_on_behalf_of`                                                                                                                    | *Optional[str]*                                                                                                                     | :heavy_minus_sign:                                                                                                                  | Optional external end-user identifier forwarded by the API gateway.                                                                 |
| `retries`                                                                                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                    | :heavy_minus_sign:                                                                                                                  | Configuration to override the default retry behavior of the client.                                                                 |

### Response

**[models.PageGeneration](../../models/pagegeneration.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## create_generation

The components.md §6 D.1 sequence, in its order: the run credential is minted before
anything is spent, nothing is written before the digest is pinned, and the workflow starts
only after the row is committed.

### Example Usage

<!-- UsageSnippet language="python" operationID="create_generation_api_v1_datasets_generations_post" method="post" path="/api/v1/datasets/generations" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.datasets.create_generation(idempotency_key="<value>", generator_id="<id>", params={
        "key": "<value>",
        "key1": "<value>",
    }, output={
        "repo": "<value>",
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `idempotency_key`                                                       | *str*                                                                   | :heavy_check_mark:                                                      | N/A                                                                     |
| `generator_id`                                                          | *str*                                                                   | :heavy_check_mark:                                                      | N/A                                                                     |
| `params`                                                                | Dict[str, *Any*]                                                        | :heavy_check_mark:                                                      | N/A                                                                     |
| `output`                                                                | [models.OutputSpec](../../models/outputspec.md)                         | :heavy_check_mark:                                                      | N/A                                                                     |
| `x_on_behalf_of`                                                        | *Optional[str]*                                                         | :heavy_minus_sign:                                                      | Optional external end-user identifier forwarded by the API gateway.     |
| `inputs`                                                                | Dict[str, *str*]                                                        | :heavy_minus_sign:                                                      | N/A                                                                     |
| `limits`                                                                | [OptionalNullable[models.LimitsRequest]](../../models/limitsrequest.md) | :heavy_minus_sign:                                                      | N/A                                                                     |
| `name`                                                                  | *OptionalNullable[str]*                                                 | :heavy_minus_sign:                                                      | N/A                                                                     |
| `derived_from`                                                          | List[*str*]                                                             | :heavy_minus_sign:                                                      | N/A                                                                     |
| `retries`                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)        | :heavy_minus_sign:                                                      | Configuration to override the default retry behavior of the client.     |

### Response

**[models.GenerationCreated](../../models/generationcreated.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## get_generation

Get Generation

### Example Usage

<!-- UsageSnippet language="python" operationID="get_generation_api_v1_datasets_generations__generation_id__get" method="get" path="/api/v1/datasets/generations/{generation_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.datasets.get_generation(generation_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `generation_id`                                                     | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.Generation](../../models/generation.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## get_generation_logs

Get Logs

### Example Usage

<!-- UsageSnippet language="python" operationID="get_logs_api_v1_datasets_generations__generation_id__logs_get" method="get" path="/api/v1/datasets/generations/{generation_id}/logs" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.datasets.get_generation_logs(generation_id="<id>", limit=100, order="asc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                     | Type                                                                                                                                                          | Required                                                                                                                                                      | Description                                                                                                                                                   |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `generation_id`                                                                                                                                               | *str*                                                                                                                                                         | :heavy_check_mark:                                                                                                                                            | N/A                                                                                                                                                           |
| `stream`                                                                                                                                                      | [OptionalNullable[models.GetLogsAPIV1DatasetsGenerationsGenerationIDLogsGetStream]](../../models/getlogsapiv1datasetsgenerationsgenerationidlogsgetstream.md) | :heavy_minus_sign:                                                                                                                                            | N/A                                                                                                                                                           |
| `limit`                                                                                                                                                       | *Optional[int]*                                                                                                                                               | :heavy_minus_sign:                                                                                                                                            | N/A                                                                                                                                                           |
| `cursor`                                                                                                                                                      | *OptionalNullable[str]*                                                                                                                                       | :heavy_minus_sign:                                                                                                                                            | N/A                                                                                                                                                           |
| `order`                                                                                                                                                       | [Optional[models.GetLogsAPIV1DatasetsGenerationsGenerationIDLogsGetOrder]](../../models/getlogsapiv1datasetsgenerationsgenerationidlogsgetorder.md)           | :heavy_minus_sign:                                                                                                                                            | N/A                                                                                                                                                           |
| `x_on_behalf_of`                                                                                                                                              | *Optional[str]*                                                                                                                                               | :heavy_minus_sign:                                                                                                                                            | Optional external end-user identifier forwarded by the API gateway.                                                                                           |
| `retries`                                                                                                                                                     | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                              | :heavy_minus_sign:                                                                                                                                            | Configuration to override the default retry behavior of the client.                                                                                           |

### Response

**[models.PageLogLine](../../models/pagelogline.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## get_generation_events

Get Events

### Example Usage

<!-- UsageSnippet language="python" operationID="get_events_api_v1_datasets_generations__generation_id__events_get" method="get" path="/api/v1/datasets/generations/{generation_id}/events" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.datasets.get_generation_events(generation_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `generation_id`                                                     | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.EventList](../../models/eventlist.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## cancel_generation

api.md §3: `cancelling` is written here, then the signal; a `cancelling` row whose
signal was lost (the retry case) is signalled again.

### Example Usage

<!-- UsageSnippet language="python" operationID="cancel_generation_api_v1_datasets_generations__generation_id__cancel_post" method="post" path="/api/v1/datasets/generations/{generation_id}/cancel" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.datasets.cancel_generation(generation_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `generation_id`                                                     | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.Generation](../../models/generation.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## list_formats

List Formats

### Example Usage

<!-- UsageSnippet language="python" operationID="list_formats_api_v1_datasets_formats_get" method="get" path="/api/v1/datasets/formats" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.datasets.list_formats()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.FormatList](../../models/formatlist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_format

Get Format

### Example Usage

<!-- UsageSnippet language="python" operationID="get_format_api_v1_datasets_formats__format_id__get" method="get" path="/api/v1/datasets/formats/{format_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.datasets.get_format(format_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `format_id`                                                         | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.FormatDetail](../../models/formatdetail.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |