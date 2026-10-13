# UpdateCatalogModelRequestAuth2

## Example Usage

```typescript
import { UpdateCatalogModelRequestAuth2 } from "@meetkai/mka1/models/components";

let value: UpdateCatalogModelRequestAuth2 = {
  type: "custom-headers",
  headers: {
    "key": "<value>",
    "key1": "<value>",
    "key2": "<value>",
  },
};
```

## Fields

| Field                    | Type                     | Required                 | Description              |
| ------------------------ | ------------------------ | ------------------------ | ------------------------ |
| `type`                   | *"custom-headers"*       | :heavy_check_mark:       | N/A                      |
| `headers`                | Record<string, *string*> | :heavy_check_mark:       | N/A                      |
| `envVars`                | Record<string, *string*> | :heavy_minus_sign:       | N/A                      |