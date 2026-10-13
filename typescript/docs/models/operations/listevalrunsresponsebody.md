# ListEvalRunsResponseBody

OK

## Example Usage

```typescript
import { ListEvalRunsResponseBody } from "@meetkai/mka1/models/operations";

let value: ListEvalRunsResponseBody = {
  object: "list",
  data: [
    {
      id: "<id>",
      object: "eval.run",
      suiteId: "<id>",
      suiteVersion: 24853,
      suiteVersionId: "<id>",
      orgId: "<id>",
      teamId: "<id>",
      status: "finalizing",
      models: [
        "<value 1>",
      ],
      taskIds: [
        "<value 1>",
        "<value 2>",
        "<value 3>",
      ],
      judgeModel: "<value>",
      embeddingModel: "<value>",
      generation: {},
      requestCounts: {
        total: 471746,
        completed: 981313,
        failed: 772953,
      },
      metrics: {
        "key": "<value>",
        "key1": "<value>",
      },
      error: {
        "key": "<value>",
        "key1": "<value>",
        "key2": "<value>",
      },
      artifactFileIds: [],
      metadata: {
        "key": "<value>",
      },
      agentName: "<value>",
      agentVersion: "<value>",
      agentEffort: "<value>",
      costUsd: 4070.35,
      tokens: {
        input: 260270,
        output: 622952,
        cached: 118006,
        reasoning: 610939,
      },
      createdAt: 152034,
      startedAt: 321619,
      completedAt: 494697,
      cancelledAt: 348701,
      failedAt: 325869,
    },
  ],
  hasMore: true,
};
```

## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `object`                                                                     | *"list"*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `data`                                                                       | [operations.ListEvalRunsData](../../models/operations/listevalrunsdata.md)[] | :heavy_check_mark:                                                           | N/A                                                                          |
| `firstId`                                                                    | *string*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |
| `lastId`                                                                     | *string*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |
| `hasMore`                                                                    | *boolean*                                                                    | :heavy_check_mark:                                                           | N/A                                                                          |