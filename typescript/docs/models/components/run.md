# Run

## Example Usage

```typescript
import { Run } from "@meetkai/mka1/models/components";

let value: Run = {
  info: {
    runId: "<id>",
    experimentId: "<id>",
  },
};
```

## Fields

| Field                                                        | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `info`                                                       | [components.RunInfo](../../models/components/runinfo.md)     | :heavy_check_mark:                                           | N/A                                                          |
| `data`                                                       | [components.RunData](../../models/components/rundata.md)     | :heavy_minus_sign:                                           | N/A                                                          |
| `inputs`                                                     | [components.RunInputs](../../models/components/runinputs.md) | :heavy_minus_sign:                                           | N/A                                                          |