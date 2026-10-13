# GetSandboxUsageRequest

## Example Usage

```typescript
import { GetSandboxUsageRequest } from "@meetkai/mka1/models/operations";

let value: GetSandboxUsageRequest = {
  startTime: 747526,
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `startTime`                                                                              | *number*                                                                                 | :heavy_check_mark:                                                                       | Start time as Unix seconds, inclusive                                                    |
| `endTime`                                                                                | *number*                                                                                 | :heavy_minus_sign:                                                                       | End time as Unix seconds, exclusive. Defaults to now.                                    |
| `bucketWidth`                                                                            | [components.SandboxUsageBucketWidth](../../models/components/sandboxusagebucketwidth.md) | :heavy_minus_sign:                                                                       | Time bucket width.                                                                       |
| `groupBy`                                                                                | *string*[]                                                                               | :heavy_minus_sign:                                                                       | Repeat or comma-separate grouping dimensions.                                            |
| `allOrgs`                                                                                | *boolean*                                                                                | :heavy_minus_sign:                                                                       | Aggregate usage across all organizations (cluster admins only).                          |
| `orgIds`                                                                                 | *string*[]                                                                               | :heavy_minus_sign:                                                                       | Filter by organization IDs (cluster admins only, implies cluster scope).                 |
| `xOnBehalfOf`                                                                            | *string*                                                                                 | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |