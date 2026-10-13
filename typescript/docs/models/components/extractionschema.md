# ExtractionSchema

Schema definition for creating a reusable extraction template. Extraction schemas define the structure and validation rules for data extraction from files.

## Example Usage

```typescript
import { ExtractionSchema } from "@meetkai/mka1/models/components";

let value: ExtractionSchema = {
  name: "Invoice Extraction",
  description: "Schema for extracting invoice data from PDF documents",
  schema: {
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
  },
};
```

## Fields

| Field                                                                                                                                   | Type                                                                                                                                    | Required                                                                                                                                | Description                                                                                                                             |
| --------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- |
| `name`                                                                                                                                  | *string*                                                                                                                                | :heavy_check_mark:                                                                                                                      | Name of the extraction schema. Must be between 1 and 100 characters. Used to identify and reference the schema.                         |
| `description`                                                                                                                           | *string*                                                                                                                                | :heavy_minus_sign:                                                                                                                      | Optional description of the schema. Maximum 500 characters. Helps document the purpose and usage of the schema.                         |
| `schema`                                                                                                                                | Record<string, *any*>                                                                                                                   | :heavy_check_mark:                                                                                                                      | JSON Schema object defining the structure of data to extract. Specifies the fields, types, and validation rules for the extracted data. |
| `metadata`                                                                                                                              | Record<string, *any*>                                                                                                                   | :heavy_minus_sign:                                                                                                                      | Optional metadata for the schema. Can store additional information like version, author, or custom properties.                          |