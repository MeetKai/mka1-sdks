# ClusterInviteSeedBudget

Cluster-owned organization spend limit applied before invitation acceptance commits. Uses the cluster pricing currency and blocks new requests at 100% of the limit. All fields are required when supplied. Enabling requires a positive finite limit and non-null period; when disabled, period and limit must both be null or both be valid. Existing budgeting outage and in-flight-request behavior still applies.

## Example Usage

```typescript
import { ClusterInviteSeedBudget } from "@meetkai/mka1/models/components";

let value: ClusterInviteSeedBudget = {
  enabled: true,
  period: "weekly",
  limit: 4559.88,
};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `enabled`                                                                                            | *boolean*                                                                                            | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `period`                                                                                             | [components.ClusterInviteSeedBudgetPeriod](../../models/components/clusterinviteseedbudgetperiod.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `limit`                                                                                              | *number*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |