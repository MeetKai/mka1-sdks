# Llm.Extract

## Overview

### Available Operations

* [extract](#extract) - Extract structured data with inline JSON Schema
* [create_schema](#create_schema) - Create reusable extraction schema template
* [get_schema](#get_schema) - Get extraction schema by ID
* [update_schema](#update_schema) - Update extraction schema by ID
* [delete_schema](#delete_schema) - Delete extraction schema by ID
* [extract_with_schema](#extract_with_schema) - Extract data using saved schema template

## extract

Extracts structured data from files using a custom inline JSON schema.

### Example Usage

<!-- UsageSnippet language="python" operationID="extract" method="post" path="/api/v1/llm/extract" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.extract.extract(model="meetkai:functionary-urdu-mini-pak", schema="[object Object]", file={
        "file_name": "example.file",
        "content": open("example.file", "rb"),
    }, prompt="Extract invoice number, vendor, total, and date from this invoice.")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `model`                                                                     | *str*                                                                       | :heavy_check_mark:                                                          | ID of the model to use for extraction                                       |
| `schema_`                                                                   | *str*                                                                       | :heavy_check_mark:                                                          | JSON Schema object or JSON string defining the structure of data to extract |
| `file`                                                                      | [models.ExtractFile](../../models/extractfile.md)                           | :heavy_check_mark:                                                          | The file to extract structured data from                                    |
| `x_on_behalf_of`                                                            | *Optional[str]*                                                             | :heavy_minus_sign:                                                          | Optional external end-user identifier forwarded by the API gateway.         |
| `metadata`                                                                  | *Optional[str]*                                                             | :heavy_minus_sign:                                                          | Optional metadata as JSON object or JSON string                             |
| `prompt`                                                                    | *Optional[str]*                                                             | :heavy_minus_sign:                                                          | Optional custom system prompt to guide extraction                           |
| `retries`                                                                   | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)            | :heavy_minus_sign:                                                          | Configuration to override the default retry behavior of the client.         |

### Response

**[models.ExtractionResponse](../../models/extractionresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_schema

Creates and stores a reusable JSON Schema template for structured data extraction.

### Example Usage

<!-- UsageSnippet language="python" operationID="createExtractSchema" method="post" path="/api/v1/llm/extract/schema" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.extract.create_schema(name="Invoice Extraction", schema={
        "type": "object",
        "properties": {
            "invoice_number": {
                "type": "string",
            },
            "vendor_name": {
                "type": "string",
            },
            "total_amount": {
                "type": "number",
            },
            "date": {
                "type": "string",
                "format": "date",
            },
        },
        "required": [
            "invoice_number",
            "total_amount",
        ],
    }, description="Schema for extracting invoice data from PDF documents", metadata={
        "document_type": "invoice",
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                               | Type                                                                                                                                    | Required                                                                                                                                | Description                                                                                                                             |
| --------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- |
| `name`                                                                                                                                  | *str*                                                                                                                                   | :heavy_check_mark:                                                                                                                      | Name of the extraction schema. Must be between 1 and 100 characters. Used to identify and reference the schema.                         |
| `schema_`                                                                                                                               | Dict[str, *Any*]                                                                                                                        | :heavy_check_mark:                                                                                                                      | JSON Schema object defining the structure of data to extract. Specifies the fields, types, and validation rules for the extracted data. |
| `x_on_behalf_of`                                                                                                                        | *Optional[str]*                                                                                                                         | :heavy_minus_sign:                                                                                                                      | Optional external end-user identifier forwarded by the API gateway.                                                                     |
| `description`                                                                                                                           | *Optional[str]*                                                                                                                         | :heavy_minus_sign:                                                                                                                      | Optional description of the schema. Maximum 500 characters. Helps document the purpose and usage of the schema.                         |
| `metadata`                                                                                                                              | Dict[str, *Any*]                                                                                                                        | :heavy_minus_sign:                                                                                                                      | Optional metadata for the schema. Can store additional information like version, author, or custom properties.                          |
| `retries`                                                                                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                        | :heavy_minus_sign:                                                                                                                      | Configuration to override the default retry behavior of the client.                                                                     |

### Response

**[models.SchemaCreateResponse](../../models/schemacreateresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_schema

Retrieve a stored extraction schema and its metadata.

### Example Usage

<!-- UsageSnippet language="python" operationID="getExtractSchema" method="get" path="/api/v1/llm/extract/schema/{schema_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.extract.get_schema(schema_id="schema_invoice_123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `schema_id`                                                         | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | schema_invoice_123                                                  |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.SchemaGetResponse](../../models/schemagetresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update_schema

Update an existing extraction schema and its metadata.

### Example Usage

<!-- UsageSnippet language="python" operationID="updateExtractSchema" method="put" path="/api/v1/llm/extract/schema/{schema_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.extract.update_schema(schema_id="schema_invoice_123", name="Invoice Extraction v2", metadata={
        "document_type": "invoice",
        "version": "2",
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `schema_id`                                                         | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | schema_invoice_123                                                  |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `name`                                                              | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional new name for the extraction schema                         |                                                                     |
| `description`                                                       | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional new description for the schema                             |                                                                     |
| `schema_`                                                           | Dict[str, *Any*]                                                    | :heavy_minus_sign:                                                  | Optional updated JSON Schema definition                             |                                                                     |
| `metadata`                                                          | Dict[str, *Any*]                                                    | :heavy_minus_sign:                                                  | Optional updated metadata                                           |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.SchemaUpdateResponse](../../models/schemaupdateresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_schema

Remove a stored extraction schema.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteExtractSchema" method="delete" path="/api/v1/llm/extract/schema/{schema_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.extract.delete_schema(schema_id="schema_invoice_123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `schema_id`                                                         | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | schema_invoice_123                                                  |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.SchemaDeleteResponse](../../models/schemadeleteresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## extract_with_schema

Extracts structured data from files using a previously saved extraction schema template.

### Example Usage

<!-- UsageSnippet language="python" operationID="extractWithSchema" method="post" path="/api/v1/llm/extract/schema/{schema_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.extract.extract_with_schema(schema_id="schema_invoice_123", model="meetkai:functionary-urdu-mini-pak", file={
        "file_name": "example.file",
        "content": open("example.file", "rb"),
    }, prompt="Extract the structured invoice fields.")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           | Example                                                               |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `schema_id`                                                           | *str*                                                                 | :heavy_check_mark:                                                    | N/A                                                                   | schema_invoice_123                                                    |
| `model`                                                               | *str*                                                                 | :heavy_check_mark:                                                    | ID of the model to use for extraction                                 |                                                                       |
| `file`                                                                | [models.ExtractWithSchemaFile](../../models/extractwithschemafile.md) | :heavy_check_mark:                                                    | The file to extract structured data from                              |                                                                       |
| `x_on_behalf_of`                                                      | *Optional[str]*                                                       | :heavy_minus_sign:                                                    | Optional external end-user identifier forwarded by the API gateway.   |                                                                       |
| `prompt`                                                              | *Optional[str]*                                                       | :heavy_minus_sign:                                                    | Optional custom system prompt to guide extraction                     |                                                                       |
| `retries`                                                             | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)      | :heavy_minus_sign:                                                    | Configuration to override the default retry behavior of the client.   |                                                                       |

### Response

**[models.ExtractionResponse](../../models/extractionresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |