# ExtractionResponseMetadata

Metadata about the extraction request and execution

## Example Usage

```typescript
import { ExtractionResponseMetadata } from "@meetkai/mka1/models/components";

let value: ExtractionResponseMetadata = {
  model: "Roadster",
  filename: "example.file",
  fileSize: 7865.99,
  extractedAt: new Date("2024-04-22T19:32:15.217Z"),
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `model`                                                                                       | *string*                                                                                      | :heavy_check_mark:                                                                            | The model that was used to perform the extraction                                             |
| `filename`                                                                                    | *string*                                                                                      | :heavy_check_mark:                                                                            | The name of the file that was processed                                                       |
| `fileSize`                                                                                    | *number*                                                                                      | :heavy_check_mark:                                                                            | The size of the processed file in bytes                                                       |
| `extractedAt`                                                                                 | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | ISO 8601 timestamp indicating when the extraction was performed                               |
| `schemaId`                                                                                    | *string*                                                                                      | :heavy_minus_sign:                                                                            | The ID of the extraction schema that was used (only present when using a saved schema)        |
| `schemaName`                                                                                  | *string*                                                                                      | :heavy_minus_sign:                                                                            | The name of the extraction schema that was used (only present when using a saved schema)      |