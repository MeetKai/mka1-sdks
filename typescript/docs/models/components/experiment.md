# Experiment

## Example Usage

```typescript
import { Experiment } from "@meetkai/mka1/models/components";

let value: Experiment = {
  experimentId: "<id>",
  name: "<value>",
};
```

## Fields

| Field                                              | Type                                               | Required                                           | Description                                        |
| -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- |
| `experimentId`                                     | *string*                                           | :heavy_check_mark:                                 | N/A                                                |
| `name`                                             | *string*                                           | :heavy_check_mark:                                 | N/A                                                |
| `artifactLocation`                                 | *string*                                           | :heavy_minus_sign:                                 | N/A                                                |
| `lifecycleStage`                                   | *string*                                           | :heavy_minus_sign:                                 | N/A                                                |
| `tags`                                             | [components.Tag](../../models/components/tag.md)[] | :heavy_minus_sign:                                 | N/A                                                |
| `creationTime`                                     | *number*                                           | :heavy_minus_sign:                                 | N/A                                                |
| `lastUpdateTime`                                   | *number*                                           | :heavy_minus_sign:                                 | N/A                                                |