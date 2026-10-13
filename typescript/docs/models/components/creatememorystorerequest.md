# CreateMemoryStoreRequest

## Example Usage

```typescript
import { CreateMemoryStoreRequest } from "@meetkai/mka1/models/components";

let value: CreateMemoryStoreRequest = {
  name: "<value>",
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `name`                                                                               | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `description`                                                                        | *string*                                                                             | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `instructions`                                                                       | *string*                                                                             | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `visibility`                                                                         | [components.MemoryStoreVisibility](../../models/components/memorystorevisibility.md) | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `metadata`                                                                           | Record<string, *string*>                                                             | :heavy_minus_sign:                                                                   | N/A                                                                                  |