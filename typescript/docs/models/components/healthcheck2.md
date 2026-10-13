# HealthCheck2

## Example Usage

```typescript
import { HealthCheck2 } from "@meetkai/mka1/models/components";

let value: HealthCheck2 = {
  mode: "preflight",
  path: "/usr/sbin",
};
```

## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `mode`                                                                       | *"preflight"*                                                                | :heavy_check_mark:                                                           | N/A                                                                          |
| `path`                                                                       | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `method`                                                                     | [components.HealthCheckMethod](../../models/components/healthcheckmethod.md) | :heavy_minus_sign:                                                           | N/A                                                                          |
| `timeoutMs`                                                                  | *number*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |
| `cacheTtlSeconds`                                                            | *number*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |