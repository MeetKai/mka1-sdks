# EvalLeaderboardRunGroup

## Example Usage

```typescript
import { EvalLeaderboardRunGroup } from "@meetkai/mka1/models/components";

let value: EvalLeaderboardRunGroup = {
  model: "ATS",
  taskId: "<id>",
  rank: 17583,
  runId: "<id>",
};
```

## Fields

| Field                                                                                                                                                                     | Type                                                                                                                                                                      | Required                                                                                                                                                                  | Description                                                                                                                                                               |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `model`                                                                                                                                                                   | *string*                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                        | The group's model.                                                                                                                                                        |
| `taskId`                                                                                                                                                                  | *string*                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                        | The group's targeted task, or null for the per-model covers-everything group that unrestricted runs (no task_ids) rank in — those runs cover every task of their version. |
| `rank`                                                                                                                                                                    | *number*                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                        | 1 is the group's newest completed run. Ranks order runs within a group but are not slot indexes: under truncation a group's surviving ranks may be non-contiguous.        |
| `runId`                                                                                                                                                                   | *string*                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                        | The run holding this rank; the full run object is in `data`.                                                                                                              |