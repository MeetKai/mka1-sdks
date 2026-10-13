# UpdateCatalogModelRequestAuth4

## Example Usage

```typescript
import { UpdateCatalogModelRequestAuth4 } from "@meetkai/mka1/models/components";

let value: UpdateCatalogModelRequestAuth4 = {
  type: "composite",
  strategies: [
    {
      type: "composite",
      strategies: [],
    },
  ],
};
```

## Fields

| Field                         | Type                          | Required                      | Description                   |
| ----------------------------- | ----------------------------- | ----------------------------- | ----------------------------- |
| `type`                        | *"composite"*                 | :heavy_check_mark:            | N/A                           |
| `strategies`                  | *components.AuthStrategies*[] | :heavy_check_mark:            | N/A                           |