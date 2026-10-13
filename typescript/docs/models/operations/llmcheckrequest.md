# LlmCheckRequest

## Example Usage

```typescript
import { LlmCheckRequest } from "@meetkai/mka1/models/operations";

let value: LlmCheckRequest = {
  resourceType: "vector_store",
  resourceId: "<id>",
  role: "writer",
};
```

## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `resourceType`                                                           | [components.LlmResourceType](../../models/components/llmresourcetype.md) | :heavy_check_mark:                                                       | Type of LLM resource                                                     |
| `resourceId`                                                             | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `role`                                                                   | [components.ResourceRole](../../models/components/resourcerole.md)       | :heavy_check_mark:                                                       | Permission role for the resource (owner > writer > reader)               |
| `xOnBehalfOf`                                                            | *string*                                                                 | :heavy_minus_sign:                                                       | Optional external end-user identifier forwarded by the API gateway.      |