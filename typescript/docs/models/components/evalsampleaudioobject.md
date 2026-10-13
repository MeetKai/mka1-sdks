# EvalSampleAudioObject

## Example Usage

```typescript
import { EvalSampleAudioObject } from "@meetkai/mka1/models/components";

let value: EvalSampleAudioObject = {
  object: "eval.sample.audio",
  audio: "<value>",
  sampleIndex: 256441,
  taskId: "<id>",
  model: "F-150",
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `object`                                                                                      | *"eval.sample.audio"*                                                                         | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `audio`                                                                                       | *string*                                                                                      | :heavy_check_mark:                                                                            | Playable clip reference: a base64 `data:` URI or an http(s) URL.                              |
| `sampleIndex`                                                                                 | *number*                                                                                      | :heavy_check_mark:                                                                            | Echoes the requested sample index so the client has a complete cache key without tracking it. |
| `taskId`                                                                                      | *string*                                                                                      | :heavy_check_mark:                                                                            | The task the clip was resolved from (the clip differs across tasks).                          |
| `model`                                                                                       | *string*                                                                                      | :heavy_check_mark:                                                                            | The model row the clip was read from. The clip is identical across models within a task.      |