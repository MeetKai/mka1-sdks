# UpdateSkillRequest

## Example Usage

```typescript
import { UpdateSkillRequest } from "@meetkai/mka1/models/operations";

let value: UpdateSkillRequest = {
  skillId: "skill_1710000000000_abc123",
  skillUpdateRequest: {
    defaultVersion: "<value>",
  },
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    | Example                                                                        |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `skillId`                                                                      | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            | skill_1710000000000_abc123                                                     |
| `xOnBehalfOf`                                                                  | *string*                                                                       | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |                                                                                |
| `skillUpdateRequest`                                                           | [components.SkillUpdateRequest](../../models/components/skillupdaterequest.md) | :heavy_check_mark:                                                             | N/A                                                                            |                                                                                |