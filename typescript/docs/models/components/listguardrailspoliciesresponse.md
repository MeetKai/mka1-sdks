# ListGuardrailsPoliciesResponse

## Example Usage

```typescript
import { ListGuardrailsPoliciesResponse } from "@meetkai/mka1/models/components";

let value: ListGuardrailsPoliciesResponse = {
  object: "list",
  data: [
    {
      teamId: "<id>",
      guardrails: [],
      updatedAt: 7378.27,
    },
  ],
};
```

## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `object`                                                                     | *"list"*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `data`                                                                       | [components.GuardrailsPolicy](../../models/components/guardrailspolicy.md)[] | :heavy_check_mark:                                                           | N/A                                                                          |