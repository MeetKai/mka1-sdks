# GetSkillVersionRequest

## Example Usage

```typescript
import { GetSkillVersionRequest } from "@meetkai/mka1/models/operations";

let value: GetSkillVersionRequest = {
  skillId: "skill_1710000000000_abc123",
  version: "1",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `skillId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `version`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | 1                                                                   |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |