# VectorStoreFileError

The last error associated with this vector store file. Will be null if there are no errors.

## Example Usage

```typescript
import { VectorStoreFileError } from "@meetkai/mka1/models/components";

let value: VectorStoreFileError = {
  code: "server_error",
  message: "<value>",
};
```

## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `code`                                                  | [components.Code](../../models/components/code.md)      | :heavy_check_mark:                                      | One of server_error, unsupported_file, or invalid_file. |
| `message`                                               | *string*                                                | :heavy_check_mark:                                      | A human-readable description of the error.              |