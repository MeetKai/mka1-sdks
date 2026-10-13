# VectorStoreFileError

The last error associated with this vector store file. Will be null if there are no errors.


## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `Code`                                                  | [Code](../../Types/Components/Code.md)                  | :heavy_check_mark:                                      | One of server_error, unsupported_file, or invalid_file. |
| `Message`                                               | *string*                                                | :heavy_check_mark:                                      | A human-readable description of the error.              |