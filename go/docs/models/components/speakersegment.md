# SpeakerSegment


## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `Speaker`                                                              | `string`                                                               | :heavy_check_mark:                                                     | Detected speaker identifier for this segment, for example 'Speaker-1'. |
| `Text`                                                                 | `string`                                                               | :heavy_check_mark:                                                     | The transcribed text for this speaker segment.                         |
| `Confidence`                                                           | `*float64`                                                             | :heavy_minus_sign:                                                     | Confidence score from 0 to 1 for this segment.                         |
| `OffsetMs`                                                             | `*int64`                                                               | :heavy_minus_sign:                                                     | Start offset of the segment in milliseconds.                           |
| `DurationMs`                                                           | `*int64`                                                               | :heavy_minus_sign:                                                     | Duration of the segment in milliseconds.                               |