# ResponseOutputTextAnnotationAddedEvent

## Example Usage

```typescript
import { ResponseOutputTextAnnotationAddedEvent } from "@meetkai/mka1/models/components";

let value: ResponseOutputTextAnnotationAddedEvent = {
  type: "response.output_text.annotation.added",
  sequenceNumber: 1555,
  itemId: "<id>",
  outputIndex: 251392,
  contentIndex: 417194,
  annotationIndex: 1564,
  annotation: {
    type: "<value>",
    text: "<value>",
    start: 981955,
    end: 728911,
  },
};
```

## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `type`                                                         | *"response.output_text.annotation.added"*                      | :heavy_check_mark:                                             | N/A                                                            |
| `sequenceNumber`                                               | *number*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `itemId`                                                       | *string*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `outputIndex`                                                  | *number*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `contentIndex`                                                 | *number*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `annotationIndex`                                              | *number*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `annotation`                                                   | [components.Annotation](../../models/components/annotation.md) | :heavy_check_mark:                                             | N/A                                                            |