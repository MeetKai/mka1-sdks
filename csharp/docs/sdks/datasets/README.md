# Datasets

## Overview

### Available Operations

* [ListGenerators](#listgenerators) - List Generators
* [GetGenerator](#getgenerator) - Get Generator
* [QuoteGenerator](#quotegenerator) - Quote Generator
* [ListGenerations](#listgenerations) - List Generations
* [CreateGeneration](#creategeneration) - Create Generation
* [GetGeneration](#getgeneration) - Get Generation
* [GetGenerationLogs](#getgenerationlogs) - Get Logs
* [GetGenerationEvents](#getgenerationevents) - Get Events
* [CancelGeneration](#cancelgeneration) - Cancel Generation
* [ListFormats](#listformats) - List Formats
* [GetFormat](#getformat) - Get Format

## ListGenerators

List Generators

### Example Usage

<!-- UsageSnippet language="csharp" operationID="list_generators_api_v1_datasets_generators_get" method="get" path="/api/v1/datasets/generators" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Datasets.ListGeneratorsAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListGeneratorsApiV1DatasetsGeneratorsGetResponse](../../Types/Requests/ListGeneratorsApiV1DatasetsGeneratorsGetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetGenerator

Get Generator

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get_generator_api_v1_datasets_generators__generator_id__get" method="get" path="/api/v1/datasets/generators/{generator_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Datasets.GetGeneratorAsync(generatorId: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `GeneratorId`                                                       | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetGeneratorApiV1DatasetsGeneratorsGeneratorIdGetResponse](../../Types/Requests/GetGeneratorApiV1DatasetsGeneratorsGeneratorIdGetResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## QuoteGenerator

Quote Generator

### Example Usage

<!-- UsageSnippet language="csharp" operationID="quote_generator_api_v1_datasets_generators__generator_id__quote_post" method="post" path="/api/v1/datasets/generators/{generator_id}/quote" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Datasets.QuoteGeneratorAsync(
    generatorId: "<id>",
    body: new QuoteRequest() {
        Params = new Dictionary<string, object>() {
            { "key", "<value>" },
            { "key1", "<value>" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `GeneratorId`                                                       | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `Body`                                                              | [QuoteRequest](../../Types/Components/QuoteRequest.md)              | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[QuoteGeneratorApiV1DatasetsGeneratorsGeneratorIdQuotePostResponse](../../Types/Requests/QuoteGeneratorApiV1DatasetsGeneratorsGeneratorIdQuotePostResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## ListGenerations

List Generations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="list_generations_api_v1_datasets_generations_get" method="get" path="/api/v1/datasets/generations" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListGenerationsApiV1DatasetsGenerationsGetRequest req = new ListGenerationsApiV1DatasetsGenerationsGetRequest() {};

var res = await sdk.Datasets.ListGenerationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                      | Type                                                                                                                           | Required                                                                                                                       | Description                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                      | [ListGenerationsApiV1DatasetsGenerationsGetRequest](../../Types/Requests/ListGenerationsApiV1DatasetsGenerationsGetRequest.md) | :heavy_check_mark:                                                                                                             | The request object to use for the request.                                                                                     |

### Response

**[ListGenerationsApiV1DatasetsGenerationsGetResponse](../../Types/Requests/ListGenerationsApiV1DatasetsGenerationsGetResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## CreateGeneration

The components.md §6 D.1 sequence, in its order: the run credential is minted before
anything is spent, nothing is written before the digest is pinned, and the workflow starts
only after the row is committed.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="create_generation_api_v1_datasets_generations_post" method="post" path="/api/v1/datasets/generations" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Datasets.CreateGenerationAsync(
    idempotencyKey: "<value>",
    body: new CreateGeneration() {
        GeneratorId = "<id>",
        Params = new Dictionary<string, object>() {
            { "key", "<value>" },
            { "key1", "<value>" },
        },
        Output = new OutputSpec() {
            Repo = "<value>",
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `IdempotencyKey`                                                    | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `Body`                                                              | [CreateGeneration](../../Types/Components/CreateGeneration.md)      | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[CreateGenerationApiV1DatasetsGenerationsPostResponse](../../Types/Requests/CreateGenerationApiV1DatasetsGenerationsPostResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## GetGeneration

Get Generation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get_generation_api_v1_datasets_generations__generation_id__get" method="get" path="/api/v1/datasets/generations/{generation_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Datasets.GetGenerationAsync(generationId: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `GenerationId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetGenerationApiV1DatasetsGenerationsGenerationIdGetResponse](../../Types/Requests/GetGenerationApiV1DatasetsGenerationsGenerationIdGetResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## GetGenerationLogs

Get Logs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get_logs_api_v1_datasets_generations__generation_id__logs_get" method="get" path="/api/v1/datasets/generations/{generation_id}/logs" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetLogsApiV1DatasetsGenerationsGenerationIdLogsGetRequest req = new GetLogsApiV1DatasetsGenerationsGenerationIdLogsGetRequest() {
    GenerationId = "<id>",
};

var res = await sdk.Datasets.GetGenerationLogsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                                      | Type                                                                                                                                           | Required                                                                                                                                       | Description                                                                                                                                    |
| ---------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                                      | [GetLogsApiV1DatasetsGenerationsGenerationIdLogsGetRequest](../../Types/Requests/GetLogsApiV1DatasetsGenerationsGenerationIdLogsGetRequest.md) | :heavy_check_mark:                                                                                                                             | The request object to use for the request.                                                                                                     |

### Response

**[GetLogsApiV1DatasetsGenerationsGenerationIdLogsGetResponse](../../Types/Requests/GetLogsApiV1DatasetsGenerationsGenerationIdLogsGetResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## GetGenerationEvents

Get Events

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get_events_api_v1_datasets_generations__generation_id__events_get" method="get" path="/api/v1/datasets/generations/{generation_id}/events" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Datasets.GetGenerationEventsAsync(generationId: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `GenerationId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetEventsApiV1DatasetsGenerationsGenerationIdEventsGetResponse](../../Types/Requests/GetEventsApiV1DatasetsGenerationsGenerationIdEventsGetResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## CancelGeneration

api.md §3: `cancelling` is written here, then the signal; a `cancelling` row whose
signal was lost (the retry case) is signalled again.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="cancel_generation_api_v1_datasets_generations__generation_id__cancel_post" method="post" path="/api/v1/datasets/generations/{generation_id}/cancel" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Datasets.CancelGenerationAsync(generationId: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `GenerationId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[CancelGenerationApiV1DatasetsGenerationsGenerationIdCancelPostResponse](../../Types/Requests/CancelGenerationApiV1DatasetsGenerationsGenerationIdCancelPostResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## ListFormats

List Formats

### Example Usage

<!-- UsageSnippet language="csharp" operationID="list_formats_api_v1_datasets_formats_get" method="get" path="/api/v1/datasets/formats" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Datasets.ListFormatsAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListFormatsApiV1DatasetsFormatsGetResponse](../../Types/Requests/ListFormatsApiV1DatasetsFormatsGetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetFormat

Get Format

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get_format_api_v1_datasets_formats__format_id__get" method="get" path="/api/v1/datasets/formats/{format_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Datasets.GetFormatAsync(formatId: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `FormatId`                                                          | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetFormatApiV1DatasetsFormatsFormatIdGetResponse](../../Types/Requests/GetFormatApiV1DatasetsFormatsFormatIdGetResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |