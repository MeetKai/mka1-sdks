# SpeakerSegment

## Example Usage

```typescript
import { SpeakerSegment } from "@meetkai/mka1/models/components";

let value: SpeakerSegment = {
  speaker: "<value>",
  text: "<value>",
};
```

## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `speaker`                                                              | *string*                                                               | :heavy_check_mark:                                                     | Detected speaker identifier for this segment, for example 'Speaker-1'. |
| `text`                                                                 | *string*                                                               | :heavy_check_mark:                                                     | The transcribed text for this speaker segment.                         |
| `confidence`                                                           | *number*                                                               | :heavy_minus_sign:                                                     | Confidence score from 0 to 1 for this segment.                         |
| `offsetMs`                                                             | *number*                                                               | :heavy_minus_sign:                                                     | Start offset of the segment in milliseconds.                           |
| `durationMs`                                                           | *number*                                                               | :heavy_minus_sign:                                                     | Duration of the segment in milliseconds.                               |