# CreateMemoryEntryRequest

## Example Usage

```typescript
import { CreateMemoryEntryRequest } from "@meetkai/mka1/models/components";

let value: CreateMemoryEntryRequest = {
  path: "/usr/ports",
  content: "<value>",
};
```

## Fields

| Field                    | Type                     | Required                 | Description              |
| ------------------------ | ------------------------ | ------------------------ | ------------------------ |
| `path`                   | *string*                 | :heavy_check_mark:       | N/A                      |
| `content`                | *string*                 | :heavy_check_mark:       | N/A                      |
| `metadata`               | Record<string, *string*> | :heavy_minus_sign:       | N/A                      |