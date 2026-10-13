# SpeakerSegment


## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `speaker`                                                              | *str*                                                                  | :heavy_check_mark:                                                     | Detected speaker identifier for this segment, for example 'Speaker-1'. |
| `text`                                                                 | *str*                                                                  | :heavy_check_mark:                                                     | The transcribed text for this speaker segment.                         |
| `confidence`                                                           | *Optional[float]*                                                      | :heavy_minus_sign:                                                     | Confidence score from 0 to 1 for this segment.                         |
| `offset_ms`                                                            | *Optional[int]*                                                        | :heavy_minus_sign:                                                     | Start offset of the segment in milliseconds.                           |
| `duration_ms`                                                          | *Optional[int]*                                                        | :heavy_minus_sign:                                                     | Duration of the segment in milliseconds.                               |