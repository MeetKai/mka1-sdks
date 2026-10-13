# EvalRunOverview

## Example Usage

```typescript
import { EvalRunOverview } from "@meetkai/mka1/models/components";

let value: EvalRunOverview = {
  object: "eval.run.overview",
  runId: "<id>",
  suiteId: "<id>",
  status: "finalizing",
  agentName: "<value>",
  agentVersion: "<value>",
  agentEffort: "<value>",
  models: [
    "<value 1>",
    "<value 2>",
  ],
  metric: "<value>",
  avgReward: 2157.19,
  trials: {
    total: 949893,
    completed: 517125,
    failed: 131776,
    errored: 443018,
    retried: 942841,
  },
  costUsd: 930.17,
  tokens: {
    input: 648256,
    output: 352717,
    cached: 312224,
    reasoning: 676346,
  },
};
```

## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `object`                                                                    | *"eval.run.overview"*                                                       | :heavy_check_mark:                                                          | N/A                                                                         |
| `runId`                                                                     | *string*                                                                    | :heavy_check_mark:                                                          | N/A                                                                         |
| `suiteId`                                                                   | *string*                                                                    | :heavy_check_mark:                                                          | N/A                                                                         |
| `status`                                                                    | [components.EvalRunStatus](../../models/components/evalrunstatus.md)        | :heavy_check_mark:                                                          | N/A                                                                         |
| `agentName`                                                                 | *string*                                                                    | :heavy_check_mark:                                                          | N/A                                                                         |
| `agentVersion`                                                              | *string*                                                                    | :heavy_check_mark:                                                          | N/A                                                                         |
| `agentEffort`                                                               | *string*                                                                    | :heavy_check_mark:                                                          | N/A                                                                         |
| `models`                                                                    | *string*[]                                                                  | :heavy_check_mark:                                                          | N/A                                                                         |
| `metric`                                                                    | *string*                                                                    | :heavy_check_mark:                                                          | N/A                                                                         |
| `avgReward`                                                                 | *number*                                                                    | :heavy_check_mark:                                                          | Mean of `metric` over trials that carry it numerically. Null when none do.  |
| `trials`                                                                    | [components.Trials](../../models/components/trials.md)                      | :heavy_check_mark:                                                          | N/A                                                                         |
| `costUsd`                                                                   | *number*                                                                    | :heavy_check_mark:                                                          | N/A                                                                         |
| `tokens`                                                                    | [components.Tokens](../../models/components/tokens.md)                      | :heavy_check_mark:                                                          | Summed over the run's trials. Each field is null when no trial reported it. |