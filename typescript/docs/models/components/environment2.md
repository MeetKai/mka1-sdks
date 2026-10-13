# Environment2

## Example Usage

```typescript
import { Environment2 } from "@meetkai/mka1/models/components";

let value: Environment2 = {
  type: "container_reference",
  containerId: "<id>",
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `type`                                                                                     | *"container_reference"*                                                                    | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `containerId`                                                                              | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `networkPolicy`                                                                            | *any*                                                                                      | :heavy_minus_sign:                                                                         | Arbitrary JSON value.                                                                      |
| `skills`                                                                                   | *any*[]                                                                                    | :heavy_minus_sign:                                                                         | N/A                                                                                        |
| `memoryStores`                                                                             | [components.EnvironmentMemoryStores](../../models/components/environmentmemorystores.md)[] | :heavy_minus_sign:                                                                         | N/A                                                                                        |