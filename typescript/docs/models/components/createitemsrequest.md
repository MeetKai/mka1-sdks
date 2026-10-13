# CreateItemsRequest

## Example Usage

```typescript
import { CreateItemsRequest } from "@meetkai/mka1/models/components";

let value: CreateItemsRequest = {
  items: [
    {
      role: "user",
      content: "What is the weather today?",
    },
  ],
};
```

## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `items`                                                          | *components.Item*[]                                              | :heavy_check_mark:                                               | Items to add to the conversation. Min 1, max 20 items at a time. |
| `include`                                                        | *string*[]                                                       | :heavy_minus_sign:                                               | Additional fields to include (TODO: not implemented yet)         |