# SpeechToTextHistoryList

A paginated list of speech-to-text history items.

## Example Usage

```typescript
import { SpeechToTextHistoryList } from "@meetkai/mka1/models/components";

let value: SpeechToTextHistoryList = {
  object: "list",
  data: [],
  hasMore: true,
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `object`                                                                                       | *"list"*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `data`                                                                                         | [components.SpeechToTextHistoryObject](../../models/components/speechtotexthistoryobject.md)[] | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `firstId`                                                                                      | *string*                                                                                       | :heavy_minus_sign:                                                                             | N/A                                                                                            |
| `lastId`                                                                                       | *string*                                                                                       | :heavy_minus_sign:                                                                             | N/A                                                                                            |
| `hasMore`                                                                                      | *boolean*                                                                                      | :heavy_check_mark:                                                                             | N/A                                                                                            |