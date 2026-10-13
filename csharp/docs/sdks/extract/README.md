# Llm.Extract

## Overview

### Available Operations

* [Extract](#extract) - Extract structured data with inline JSON Schema
* [CreateSchema](#createschema) - Create reusable extraction schema template
* [GetSchema](#getschema) - Get extraction schema by ID
* [UpdateSchema](#updateschema) - Update extraction schema by ID
* [DeleteSchema](#deleteschema) - Delete extraction schema by ID
* [ExtractWithSchema](#extractwithschema) - Extract data using saved schema template

## Extract

Extracts structured data from files using a custom inline JSON schema.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="extract" method="post" path="/api/v1/llm/extract" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Extract.ExtractAsync(body: new ExtractRequestBody() {
    Model = "meetkai:functionary-urdu-mini-pak",
    Schema = "[object Object]",
    File = new ExtractFile() {
        FileName = "example.file",
        Content = System.IO.File.ReadAllBytes("example.file"),
    },
    Prompt = "Extract invoice number, vendor, total, and date from this invoice.",
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Body`                                                              | [ExtractRequestBody](../../Types/Requests/ExtractRequestBody.md)    | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ExtractResponse](../../Types/Requests/ExtractResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateSchema

Creates and stores a reusable JSON Schema template for structured data extraction.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createExtractSchema" method="post" path="/api/v1/llm/extract/schema" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Extract.CreateSchemaAsync(body: new ExtractionSchema() {
    Name = "Invoice Extraction",
    Description = "Schema for extracting invoice data from PDF documents",
    Schema = new Dictionary<string, object>() {
        { "type", "object" },
        { "properties", new Dictionary<string, object>() {
            { "invoice_number", new Dictionary<string, object>() {
                { "type", "string" },
            } },
            { "vendor_name", new Dictionary<string, object>() {
                { "type", "string" },
            } },
            { "total_amount", new Dictionary<string, object>() {
                { "type", "number" },
            } },
            { "date", new Dictionary<string, object>() {
                { "type", "string" },
                { "format", "date" },
            } },
        } },
        { "required", new List<object>() {
            "invoice_number",
            "total_amount",
        } },
    },
    Metadata = new Dictionary<string, object>() {
        { "document_type", "invoice" },
    },
});

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                       | Type                                                                                                                                                                                                                                                                                                                                                                            | Required                                                                                                                                                                                                                                                                                                                                                                        | Description                                                                                                                                                                                                                                                                                                                                                                     | Example                                                                                                                                                                                                                                                                                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Body`                                                                                                                                                                                                                                                                                                                                                                          | [ExtractionSchema](../../Types/Components/ExtractionSchema.md)                                                                                                                                                                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                              | N/A                                                                                                                                                                                                                                                                                                                                                                             | {<br/>"name": "Invoice Extraction",<br/>"description": "Schema for extracting invoice data from PDF documents",<br/>"schema": {<br/>"type": "object",<br/>"properties": {<br/>"invoice_number": {<br/>"type": "string"<br/>},<br/>"vendor_name": {<br/>"type": "string"<br/>},<br/>"total_amount": {<br/>"type": "number"<br/>},<br/>"date": {<br/>"type": "string",<br/>"format": "date"<br/>}<br/>},<br/>"required": [<br/>"invoice_number",<br/>"total_amount"<br/>]<br/>}<br/>} |
| `XOnBehalfOf`                                                                                                                                                                                                                                                                                                                                                                   | *string*                                                                                                                                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                                                                                                                                                                             |                                                                                                                                                                                                                                                                                                                                                                                 |

### Response

**[CreateExtractSchemaResponse](../../Types/Requests/CreateExtractSchemaResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetSchema

Retrieve a stored extraction schema and its metadata.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getExtractSchema" method="get" path="/api/v1/llm/extract/schema/{schema_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Extract.GetSchemaAsync(schemaId: "schema_invoice_123");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SchemaId`                                                          | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | schema_invoice_123                                                  |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetExtractSchemaResponse](../../Types/Requests/GetExtractSchemaResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## UpdateSchema

Update an existing extraction schema and its metadata.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateExtractSchema" method="put" path="/api/v1/llm/extract/schema/{schema_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Extract.UpdateSchemaAsync(
    schemaId: "schema_invoice_123",
    body: new UpdateExtractSchemaRequestBody() {
        Name = "Invoice Extraction v2",
        Metadata = new Dictionary<string, object>() {
            { "document_type", "invoice" },
            { "version", "2" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              | Example                                                                                  |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `SchemaId`                                                                               | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      | schema_invoice_123                                                                       |
| `Body`                                                                                   | [UpdateExtractSchemaRequestBody](../../Types/Requests/UpdateExtractSchemaRequestBody.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |                                                                                          |
| `XOnBehalfOf`                                                                            | *string*                                                                                 | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |                                                                                          |

### Response

**[UpdateExtractSchemaResponse](../../Types/Requests/UpdateExtractSchemaResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteSchema

Remove a stored extraction schema.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteExtractSchema" method="delete" path="/api/v1/llm/extract/schema/{schema_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Extract.DeleteSchemaAsync(schemaId: "schema_invoice_123");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SchemaId`                                                          | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | schema_invoice_123                                                  |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[DeleteExtractSchemaResponse](../../Types/Requests/DeleteExtractSchemaResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ExtractWithSchema

Extracts structured data from files using a previously saved extraction schema template.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="extractWithSchema" method="post" path="/api/v1/llm/extract/schema/{schema_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Extract.ExtractWithSchemaAsync(
    schemaId: "schema_invoice_123",
    body: new ExtractWithSchemaRequestBody() {
        Model = "meetkai:functionary-urdu-mini-pak",
        File = new ExtractWithSchemaFile() {
            FileName = "example.file",
            Content = System.IO.File.ReadAllBytes("example.file"),
        },
        Prompt = "Extract the structured invoice fields.",
    }
);

// handle response
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          | Example                                                                              |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `SchemaId`                                                                           | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  | schema_invoice_123                                                                   |
| `Body`                                                                               | [ExtractWithSchemaRequestBody](../../Types/Requests/ExtractWithSchemaRequestBody.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |                                                                                      |
| `XOnBehalfOf`                                                                        | *string*                                                                             | :heavy_minus_sign:                                                                   | Optional external end-user identifier forwarded by the API gateway.                  |                                                                                      |

### Response

**[ExtractWithSchemaResponse](../../Types/Requests/ExtractWithSchemaResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |