# DeleteAgentResponseBody

Deletion result.

## Example Usage

```typescript
import { DeleteAgentResponseBody } from "@meetkai/mka1/models/operations";

let value: DeleteAgentResponseBody = {
  object: "agent.deleted",
  id: "<id>",
  deleted: false,
};
```

## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `object`                                                                     | [operations.DeleteAgentObject](../../models/operations/deleteagentobject.md) | :heavy_check_mark:                                                           | N/A                                                                          |
| `id`                                                                         | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `deleted`                                                                    | *boolean*                                                                    | :heavy_check_mark:                                                           | N/A                                                                          |