# ReverseAccessListResponse

## Example Usage

```typescript
import { ReverseAccessListResponse } from "@meetkai/mka1/models/components";

let value: ReverseAccessListResponse = {
  object: "list",
  modelId: "<id>",
  data: [],
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `object`                                                                         | *"list"*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `modelId`                                                                        | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `data`                                                                           | [components.ReverseAccessEntry](../../models/components/reverseaccessentry.md)[] | :heavy_check_mark:                                                               | N/A                                                                              |