# ResponseWebSearchCallInProgressEvent

## Example Usage

```typescript
import { ResponseWebSearchCallInProgressEvent } from "@meetkai/mka1/models/components";

let value: ResponseWebSearchCallInProgressEvent = {
  type: "response.web_search_call.in_progress",
  sequenceNumber: 231856,
  itemId: "<id>",
  outputIndex: 449079,
};
```

## Fields

| Field                                              | Type                                               | Required                                           | Description                                        |
| -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- |
| `type`                                             | *"response.web_search_call.in_progress"*           | :heavy_check_mark:                                 | N/A                                                |
| `sequenceNumber`                                   | *number*                                           | :heavy_check_mark:                                 | N/A                                                |
| `itemId`                                           | *string*                                           | :heavy_check_mark:                                 | N/A                                                |
| `outputIndex`                                      | *number*                                           | :heavy_check_mark:                                 | N/A                                                |
| `args`                                             | [components.Args](../../models/components/args.md) | :heavy_minus_sign:                                 | N/A                                                |