# TextToSpeechHistoryList

A paginated list of text-to-speech history items.

## Example Usage

```typescript
import { TextToSpeechHistoryList } from "@meetkai/mka1/models/components";

let value: TextToSpeechHistoryList = {
  object: "list",
  data: [],
  hasMore: false,
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `object`                                                                                       | *"list"*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `data`                                                                                         | [components.TextToSpeechHistoryObject](../../models/components/texttospeechhistoryobject.md)[] | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `firstId`                                                                                      | *string*                                                                                       | :heavy_minus_sign:                                                                             | N/A                                                                                            |
| `lastId`                                                                                       | *string*                                                                                       | :heavy_minus_sign:                                                                             | N/A                                                                                            |
| `hasMore`                                                                                      | *boolean*                                                                                      | :heavy_check_mark:                                                                             | N/A                                                                                            |