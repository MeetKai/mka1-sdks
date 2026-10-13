# EvalSuiteLeaderboard

## Example Usage

```typescript
import { EvalSuiteLeaderboard } from "@meetkai/mka1/models/components";

let value: EvalSuiteLeaderboard = {
  object: "eval.leaderboard",
  suiteId: "<id>",
  suiteVersion: null,
  metric: "<value>",
  data: [],
};
```

## Fields

| Field                                                                                                               | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `object`                                                                                                            | *"eval.leaderboard"*                                                                                                | :heavy_check_mark:                                                                                                  | N/A                                                                                                                 |
| `suiteId`                                                                                                           | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | N/A                                                                                                                 |
| `suiteVersion`                                                                                                      | *number*                                                                                                            | :heavy_check_mark:                                                                                                  | The version this board was restricted to, or null when it spans every version.                                      |
| `metric`                                                                                                            | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | The `scores` key `accuracy` averages. Echoed back so a board rendered from a non-default metric is self-describing. |
| `data`                                                                                                              | [components.EvalLeaderboardRow](../../models/components/evalleaderboardrow.md)[]                                    | :heavy_check_mark:                                                                                                  | Rows ordered by `accuracy` descending, nulls last, then by agent, model, and effort.                                |