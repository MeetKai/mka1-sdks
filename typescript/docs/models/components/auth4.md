# Auth4

## Example Usage

```typescript
import { Auth4 } from "@meetkai/mka1/models/components";

let value: Auth4 = {
  type: "composite",
  strategies: [
    {
      type: "custom-headers",
      headers: {
        "key": "<value>",
        "key1": "<value>",
      },
    },
  ],
};
```

## Fields

| Field                     | Type                      | Required                  | Description               |
| ------------------------- | ------------------------- | ------------------------- | ------------------------- |
| `type`                    | *"composite"*             | :heavy_check_mark:        | N/A                       |
| `strategies`              | *components.Strategies*[] | :heavy_check_mark:        | N/A                       |