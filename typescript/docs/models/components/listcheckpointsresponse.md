# ListCheckpointsResponse

## Example Usage

```typescript
import { ListCheckpointsResponse } from "@meetkai/mka1/models/components";

let value: ListCheckpointsResponse = {
  object: "list",
  data: [],
  hasMore: false,
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `object`                                                                             | *"list"*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `data`                                                                               | [components.FineTuningCheckpoint](../../models/components/finetuningcheckpoint.md)[] | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `hasMore`                                                                            | *boolean*                                                                            | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `firstId`                                                                            | *string*                                                                             | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `lastId`                                                                             | *string*                                                                             | :heavy_minus_sign:                                                                   | N/A                                                                                  |