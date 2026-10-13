# RunInfo

## Example Usage

```typescript
import { RunInfo } from "@meetkai/mka1/models/components";

let value: RunInfo = {
  runId: "<id>",
  experimentId: "<id>",
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `runId`                                                              | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `runUuid`                                                            | *string*                                                             | :heavy_minus_sign:                                                   | N/A                                                                  |
| `runName`                                                            | *string*                                                             | :heavy_minus_sign:                                                   | N/A                                                                  |
| `experimentId`                                                       | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `userId`                                                             | *string*                                                             | :heavy_minus_sign:                                                   | N/A                                                                  |
| `status`                                                             | [components.RunInfoStatus](../../models/components/runinfostatus.md) | :heavy_minus_sign:                                                   | N/A                                                                  |
| `startTime`                                                          | *number*                                                             | :heavy_minus_sign:                                                   | N/A                                                                  |
| `endTime`                                                            | *number*                                                             | :heavy_minus_sign:                                                   | N/A                                                                  |
| `artifactUri`                                                        | *string*                                                             | :heavy_minus_sign:                                                   | N/A                                                                  |
| `lifecycleStage`                                                     | *string*                                                             | :heavy_minus_sign:                                                   | N/A                                                                  |