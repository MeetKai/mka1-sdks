# ClusterInviteSeedQuota

API request quota to apply when the invitation is accepted. All fields are required when seedQuota is supplied. Enabling requires non-null period and max; when disabled, period and max must either both be null or both be valid.

## Example Usage

```typescript
import { ClusterInviteSeedQuota } from "@meetkai/mka1/models/components";

let value: ClusterInviteSeedQuota = {
  enabled: false,
  period: "day",
  max: null,
};
```

## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `enabled`                                              | *boolean*                                              | :heavy_check_mark:                                     | N/A                                                    |
| `period`                                               | [components.Period](../../models/components/period.md) | :heavy_check_mark:                                     | N/A                                                    |
| `max`                                                  | *number*                                               | :heavy_check_mark:                                     | N/A                                                    |