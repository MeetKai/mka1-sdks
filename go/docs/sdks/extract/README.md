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

<!-- UsageSnippet language="go" operationID="extract" method="post" path="/api/v1/llm/extract" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"os"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    example, fileErr := os.Open("example.file")
    if fileErr != nil {
        panic(fileErr)
    }

    res, err := s.Llm.Extract.Extract(ctx, operations.ExtractRequestBody{
        Model: "meetkai:functionary-urdu-mini-pak",
        Schema: "[object Object]",
        File: operations.ExtractFile{
            FileName: "example.file",
            Content: example,
        },
        Prompt: mka1.Pointer("Extract invoice number, vendor, total, and date from this invoice."),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ExtractionResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `ctx`                                                                          | [context.Context](https://pkg.go.dev/context#Context)                          | :heavy_check_mark:                                                             | The context to use for the request.                                            |
| `body`                                                                         | [operations.ExtractRequestBody](../../models/operations/extractrequestbody.md) | :heavy_check_mark:                                                             | N/A                                                                            |
| `xOnBehalfOf`                                                                  | `*string`                                                                      | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |
| `opts`                                                                         | [][operations.Option](../../models/operations/option.md)                       | :heavy_minus_sign:                                                             | The options for this request.                                                  |

### Response

**[*operations.ExtractResponse](../../models/operations/extractresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateSchema

Creates and stores a reusable JSON Schema template for structured data extraction.

### Example Usage

<!-- UsageSnippet language="go" operationID="createExtractSchema" method="post" path="/api/v1/llm/extract/schema" -->
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

    res, err := s.Llm.Extract.CreateSchema(ctx, components.ExtractionSchema{
        Name: "Invoice Extraction",
        Description: mka1.Pointer("Schema for extracting invoice data from PDF documents"),
        Schema: map[string]any{
            "type": "object",
            "properties": map[string]any{
                "invoice_number": map[string]any{
                    "type": "string",
                },
                "vendor_name": map[string]any{
                    "type": "string",
                },
                "total_amount": map[string]any{
                    "type": "number",
                },
                "date": map[string]any{
                    "type": "string",
                    "format": "date",
                },
            },
            "required": []any{
                "invoice_number",
                "total_amount",
            },
        },
        Metadata: map[string]any{
            "document_type": "invoice",
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SchemaCreateResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                       | Type                                                                                                                                                                                                                                                                                                                                                                            | Required                                                                                                                                                                                                                                                                                                                                                                        | Description                                                                                                                                                                                                                                                                                                                                                                     | Example                                                                                                                                                                                                                                                                                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                                                                                                                                                                                                                                                                           | [context.Context](https://pkg.go.dev/context#Context)                                                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                              | The context to use for the request.                                                                                                                                                                                                                                                                                                                                             |                                                                                                                                                                                                                                                                                                                                                                                 |
| `body`                                                                                                                                                                                                                                                                                                                                                                          | [components.ExtractionSchema](../../models/components/extractionschema.md)                                                                                                                                                                                                                                                                                                      | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                              | N/A                                                                                                                                                                                                                                                                                                                                                                             | {<br/>"name": "Invoice Extraction",<br/>"description": "Schema for extracting invoice data from PDF documents",<br/>"schema": {<br/>"type": "object",<br/>"properties": {<br/>"invoice_number": {<br/>"type": "string"<br/>},<br/>"vendor_name": {<br/>"type": "string"<br/>},<br/>"total_amount": {<br/>"type": "number"<br/>},<br/>"date": {<br/>"type": "string",<br/>"format": "date"<br/>}<br/>},<br/>"required": [<br/>"invoice_number",<br/>"total_amount"<br/>]<br/>}<br/>} |
| `xOnBehalfOf`                                                                                                                                                                                                                                                                                                                                                                   | `*string`                                                                                                                                                                                                                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                                                                                                                                                                             |                                                                                                                                                                                                                                                                                                                                                                                 |
| `opts`                                                                                                                                                                                                                                                                                                                                                                          | [][operations.Option](../../models/operations/option.md)                                                                                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                              | The options for this request.                                                                                                                                                                                                                                                                                                                                                   |                                                                                                                                                                                                                                                                                                                                                                                 |

### Response

**[*operations.CreateExtractSchemaResponse](../../models/operations/createextractschemaresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetSchema

Retrieve a stored extraction schema and its metadata.

### Example Usage

<!-- UsageSnippet language="go" operationID="getExtractSchema" method="get" path="/api/v1/llm/extract/schema/{schema_id}" -->
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

    res, err := s.Llm.Extract.GetSchema(ctx, "schema_invoice_123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SchemaGetResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `schemaID`                                                          | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | schema_invoice_123                                                  |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetExtractSchemaResponse](../../models/operations/getextractschemaresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## UpdateSchema

Update an existing extraction schema and its metadata.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateExtractSchema" method="put" path="/api/v1/llm/extract/schema/{schema_id}" -->
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

    res, err := s.Llm.Extract.UpdateSchema(ctx, "schema_invoice_123", operations.UpdateExtractSchemaRequestBody{
        Name: mka1.Pointer("Invoice Extraction v2"),
        Metadata: map[string]any{
            "document_type": "invoice",
            "version": "2",
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SchemaUpdateResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                              | Type                                                                                                   | Required                                                                                               | Description                                                                                            | Example                                                                                                |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                  | :heavy_check_mark:                                                                                     | The context to use for the request.                                                                    |                                                                                                        |
| `schemaID`                                                                                             | `string`                                                                                               | :heavy_check_mark:                                                                                     | N/A                                                                                                    | schema_invoice_123                                                                                     |
| `body`                                                                                                 | [operations.UpdateExtractSchemaRequestBody](../../models/operations/updateextractschemarequestbody.md) | :heavy_check_mark:                                                                                     | N/A                                                                                                    |                                                                                                        |
| `xOnBehalfOf`                                                                                          | `*string`                                                                                              | :heavy_minus_sign:                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                    |                                                                                                        |
| `opts`                                                                                                 | [][operations.Option](../../models/operations/option.md)                                               | :heavy_minus_sign:                                                                                     | The options for this request.                                                                          |                                                                                                        |

### Response

**[*operations.UpdateExtractSchemaResponse](../../models/operations/updateextractschemaresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteSchema

Remove a stored extraction schema.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteExtractSchema" method="delete" path="/api/v1/llm/extract/schema/{schema_id}" -->
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

    res, err := s.Llm.Extract.DeleteSchema(ctx, "schema_invoice_123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SchemaDeleteResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `schemaID`                                                          | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | schema_invoice_123                                                  |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteExtractSchemaResponse](../../models/operations/deleteextractschemaresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ExtractWithSchema

Extracts structured data from files using a previously saved extraction schema template.

### Example Usage

<!-- UsageSnippet language="go" operationID="extractWithSchema" method="post" path="/api/v1/llm/extract/schema/{schema_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"os"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    example, fileErr := os.Open("example.file")
    if fileErr != nil {
        panic(fileErr)
    }

    res, err := s.Llm.Extract.ExtractWithSchema(ctx, "schema_invoice_123", operations.ExtractWithSchemaRequestBody{
        Model: "meetkai:functionary-urdu-mini-pak",
        File: operations.ExtractWithSchemaFile{
            FileName: "example.file",
            Content: example,
        },
        Prompt: mka1.Pointer("Extract the structured invoice fields."),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ExtractionResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        | Example                                                                                            |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                              | :heavy_check_mark:                                                                                 | The context to use for the request.                                                                |                                                                                                    |
| `schemaID`                                                                                         | `string`                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                | schema_invoice_123                                                                                 |
| `body`                                                                                             | [operations.ExtractWithSchemaRequestBody](../../models/operations/extractwithschemarequestbody.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |                                                                                                    |
| `xOnBehalfOf`                                                                                      | `*string`                                                                                          | :heavy_minus_sign:                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                |                                                                                                    |
| `opts`                                                                                             | [][operations.Option](../../models/operations/option.md)                                           | :heavy_minus_sign:                                                                                 | The options for this request.                                                                      |                                                                                                    |

### Response

**[*operations.ExtractWithSchemaResponse](../../models/operations/extractwithschemaresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |