# ListFineTuningJobsResponse

## Example Usage

```typescript
import { ListFineTuningJobsResponse } from "@meetkai/mka1/models/components";

let value: ListFineTuningJobsResponse = {
  object: "list",
  data: [
    {
      id: "<id>",
      object: "fine_tuning.job",
      createdAt: 564947,
      model: "Model 3",
      trainingFile: "<value>",
      organizationId: "<id>",
      status: "running",
      resultFiles: [
        "<value 1>",
        "<value 2>",
      ],
      seed: 486475,
      hyperparameters: {},
    },
  ],
  hasMore: false,
};
```

## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `object`                                                               | *"list"*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `data`                                                                 | [components.FineTuningJob](../../models/components/finetuningjob.md)[] | :heavy_check_mark:                                                     | N/A                                                                    |
| `hasMore`                                                              | *boolean*                                                              | :heavy_check_mark:                                                     | N/A                                                                    |