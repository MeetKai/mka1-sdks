# ListPromptsResponse

## Example Usage

```typescript
import { ListPromptsResponse } from "@meetkai/mka1/models/components";

let value: ListPromptsResponse = {
  object: "list",
  data: [],
  hasMore: false,
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `object`                                                                             | *"list"*                                                                             | :heavy_check_mark:                                                                   | Object type                                                                          |
| `data`                                                                               | [components.UpdatePromptResponse](../../models/components/updatepromptresponse.md)[] | :heavy_check_mark:                                                                   | Array of prompt objects                                                              |
| `hasMore`                                                                            | *boolean*                                                                            | :heavy_check_mark:                                                                   | Whether there are more results available                                             |
| `firstId`                                                                            | *string*                                                                             | :heavy_minus_sign:                                                                   | ID of the first item in the list                                                     |
| `lastId`                                                                             | *string*                                                                             | :heavy_minus_sign:                                                                   | ID of the last item in the list                                                      |