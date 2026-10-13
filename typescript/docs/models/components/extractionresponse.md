# ExtractionResponse

Response from the extraction endpoint containing the extracted structured data and metadata about the extraction process.

## Example Usage

```typescript
import { ExtractionResponse } from "@meetkai/mka1/models/components";

let value: ExtractionResponse = {
  success: true,
  data: {
    "invoice_number": "INV-2024-001",
    "vendor_name": "Acme Corporation",
    "total_amount": 1250,
    "date": "2024-01-15",
  },
  metadata: {
    model: "meetkai:functionary-urdu-mini-pak",
    filename: "invoice.pdf",
    fileSize: 125000,
    extractedAt: new Date("2024-01-15T10:30:00Z"),
  },
};
```

## Fields

| Field                                                                                                                                                                         | Type                                                                                                                                                                          | Required                                                                                                                                                                      | Description                                                                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `success`                                                                                                                                                                     | *boolean*                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                            | Indicates whether the extraction request was successful                                                                                                                       |
| `data`                                                                                                                                                                        | *any*                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                            | The extracted structured data conforming to the provided JSON Schema. This is the result of analyzing the file and extracting information according to the schema definition. |
| `metadata`                                                                                                                                                                    | [components.ExtractionResponseMetadata](../../models/components/extractionresponsemetadata.md)                                                                                | :heavy_check_mark:                                                                                                                                                            | Metadata about the extraction request and execution                                                                                                                           |