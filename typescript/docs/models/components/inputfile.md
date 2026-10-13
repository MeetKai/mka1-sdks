# InputFile

Input file content item: File input for document processing. Provide one of file_data, file_id, or file_url.

## Example Usage

```typescript
import { InputFile } from "@meetkai/mka1/models/components";

let value: InputFile = {
  type: "input_file",
};
```

## Fields

| Field                                                                                           | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `type`                                                                                          | *"input_file"*                                                                                  | :heavy_check_mark:                                                                              | The content type identifier for file input.                                                     |
| `fileData`                                                                                      | *string*                                                                                        | :heavy_minus_sign:                                                                              | Base64-encoded file data for inline file uploads. Mutually exclusive with file_id and file_url. |
| `fileId`                                                                                        | *string*                                                                                        | :heavy_minus_sign:                                                                              | The ID of a previously uploaded file. Mutually exclusive with file_data and file_url.           |
| `fileUrl`                                                                                       | *string*                                                                                        | :heavy_minus_sign:                                                                              | A URL pointing to the file to process. Mutually exclusive with file_data and file_id.           |
| `filename`                                                                                      | *string*                                                                                        | :heavy_minus_sign:                                                                              | The original filename for display and reference purposes.                                       |