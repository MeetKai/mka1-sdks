# UpdateResponseRequest

Request schema for updating a response's metadata.

## Example Usage

```typescript
import { UpdateResponseRequest } from "@meetkai/mka1/models/components";

let value: UpdateResponseRequest = {
  metadata: {
    "status": "reviewed",
    "reviewer": "john_doe",
  },
};
```

## Fields

| Field                                                                                                                       | Type                                                                                                                        | Required                                                                                                                    | Description                                                                                                                 |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| `metadata`                                                                                                                  | Record<string, *string*>                                                                                                    | :heavy_check_mark:                                                                                                          | Set of 16 key-value pairs to update. Keys must be strings up to 64 characters, values must be strings up to 512 characters. |