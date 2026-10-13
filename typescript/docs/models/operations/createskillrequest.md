# CreateSkillRequest

## Example Usage

```typescript
import { CreateSkillRequest } from "@meetkai/mka1/models/operations";

let value: CreateSkillRequest = {
  requestBody: {},
};
```

## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `requestBody`                                                                          | [operations.CreateSkillRequestBody](../../models/operations/createskillrequestbody.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |