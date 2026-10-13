# ClusterInviteSeedCompute

Compute policy to apply when the invitation is accepted. All fields are required when seedCompute is supplied. A null limit is unlimited and zero blocks new resources.

## Example Usage

```typescript
import { ClusterInviteSeedCompute } from "@meetkai/mka1/models/components";

let value: ClusterInviteSeedCompute = {
  enabled: false,
  maxLiveJobs: 453403,
  maxLiveServices: 87971,
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `enabled`          | *boolean*          | :heavy_check_mark: | N/A                |
| `maxLiveJobs`      | *number*           | :heavy_check_mark: | N/A                |
| `maxLiveServices`  | *number*           | :heavy_check_mark: | N/A                |