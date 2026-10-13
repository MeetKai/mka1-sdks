# Update

## Example Usage

```typescript
import { Update } from "@meetkai/mka1/models/components";

let value: Update = {
  metadata: {
    "key": "<value>",
    "key1": "<value>",
  },
};
```

## Fields

| Field                                | Type                                 | Required                             | Description                          |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `metadata`                           | Record<string, *string*>             | :heavy_check_mark:                   | Set of 16 key-value pairs to update. |