# EvalSampleList

## Example Usage

```typescript
import { EvalSampleList } from "@meetkai/mka1/models/components";

let value: EvalSampleList = {
  object: "list",
  data: [],
  hasMore: false,
};
```

## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `object`                                                                     | *"list"*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `data`                                                                       | [components.EvalSampleObject](../../models/components/evalsampleobject.md)[] | :heavy_check_mark:                                                           | N/A                                                                          |
| `firstId`                                                                    | *string*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |
| `lastId`                                                                     | *string*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |
| `hasMore`                                                                    | *boolean*                                                                    | :heavy_check_mark:                                                           | N/A                                                                          |