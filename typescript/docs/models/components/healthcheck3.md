# HealthCheck3

## Example Usage

```typescript
import { HealthCheck3 } from "@meetkai/mka1/models/components";

let value: HealthCheck3 = {
  mode: "periodic",
  intervalSeconds: 286406,
  path: "/etc/ppp",
};
```

## Fields

| Field                                                                                                                    | Type                                                                                                                     | Required                                                                                                                 | Description                                                                                                              |
| ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ |
| `mode`                                                                                                                   | *"periodic"*                                                                                                             | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `intervalSeconds`                                                                                                        | *number*                                                                                                                 | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `path`                                                                                                                   | *string*                                                                                                                 | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `method`                                                                                                                 | [components.AddCatalogModelRequestHealthCheckMethod](../../models/components/addcatalogmodelrequesthealthcheckmethod.md) | :heavy_minus_sign:                                                                                                       | N/A                                                                                                                      |
| `timeoutMs`                                                                                                              | *number*                                                                                                                 | :heavy_minus_sign:                                                                                                       | N/A                                                                                                                      |
| `cacheTtlSeconds`                                                                                                        | *number*                                                                                                                 | :heavy_minus_sign:                                                                                                       | N/A                                                                                                                      |