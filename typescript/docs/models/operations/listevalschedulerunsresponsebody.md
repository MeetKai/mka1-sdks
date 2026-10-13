# ListEvalScheduleRunsResponseBody

OK

## Example Usage

```typescript
import { ListEvalScheduleRunsResponseBody } from "@meetkai/mka1/models/operations";

let value: ListEvalScheduleRunsResponseBody = {
  object: "list",
  data: [],
  hasMore: true,
};
```

## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `object`                                                                                     | *"list"*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `data`                                                                                       | [operations.ListEvalScheduleRunsData](../../models/operations/listevalschedulerunsdata.md)[] | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `firstId`                                                                                    | *string*                                                                                     | :heavy_minus_sign:                                                                           | N/A                                                                                          |
| `lastId`                                                                                     | *string*                                                                                     | :heavy_minus_sign:                                                                           | N/A                                                                                          |
| `hasMore`                                                                                    | *boolean*                                                                                    | :heavy_check_mark:                                                                           | N/A                                                                                          |