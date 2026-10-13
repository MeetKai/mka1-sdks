# UpdateVectorStoreFileAttributesRequest

Request body for updating vector store file attributes.

## Example Usage

```typescript
import { UpdateVectorStoreFileAttributesRequest } from "@meetkai/mka1/models/components";

let value: UpdateVectorStoreFileAttributesRequest = {
  attributes: {},
};
```

## Fields

| Field                                                                                                                                                                                                   | Type                                                                                                                                                                                                    | Required                                                                                                                                                                                                | Description                                                                                                                                                                                             |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `attributes`                                                                                                                                                                                            | Record<string, *components.UpdateVectorStoreFileAttributesRequestAttributes*>                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                      | Set of 16 key-value pairs that can be attached to an object. Keys are strings with a maximum length of 64 characters. Values are strings with a maximum length of 512 characters, booleans, or numbers. |