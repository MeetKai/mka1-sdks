# Trials

## Example Usage

```typescript
import { Trials } from "@meetkai/mka1/models/components";

let value: Trials = {
  total: 726440,
  completed: 842927,
  failed: 787262,
  errored: 803977,
  retried: 348803,
};
```

## Fields

| Field                                                                                                                                                        | Type                                                                                                                                                         | Required                                                                                                                                                     | Description                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `total`                                                                                                                                                      | *number*                                                                                                                                                     | :heavy_check_mark:                                                                                                                                           | N/A                                                                                                                                                          |
| `completed`                                                                                                                                                  | *number*                                                                                                                                                     | :heavy_check_mark:                                                                                                                                           | N/A                                                                                                                                                          |
| `failed`                                                                                                                                                     | *number*                                                                                                                                                     | :heavy_check_mark:                                                                                                                                           | Trials in the `failed` status — no score produced.                                                                                                           |
| `errored`                                                                                                                                                    | *number*                                                                                                                                                     | :heavy_check_mark:                                                                                                                                           | Trials with a non-null `error`. Overlaps `failed` rather than partitioning it: a harness trial can carry an agent timeout and still be completed and scored. |
| `retried`                                                                                                                                                    | *number*                                                                                                                                                     | :heavy_check_mark:                                                                                                                                           | Trials that were rerun through rerun-failed, counted from the pre-rerun snapshot. 0 when the run was never rerun.                                            |