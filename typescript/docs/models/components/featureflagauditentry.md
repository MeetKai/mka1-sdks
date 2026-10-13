# FeatureFlagAuditEntry

## Example Usage

```typescript
import { FeatureFlagAuditEntry } from "@meetkai/mka1/models/components";

let value: FeatureFlagAuditEntry = {
  action: "<value>",
  actor: "<value>",
  actorApiKeyId: "<id>",
  actorOrgId: "<id>",
  actorTeamId: "<id>",
  actorUserId: "<id>",
  actorUserType: "<value>",
  after: "<value>",
  before: "<value>",
  entityKey: "<value>",
  entityType: "<value>",
  id: 881933,
  occurredAt: new Date("2024-07-07T23:46:19.685Z"),
  requestId: "<id>",
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `action`                                                                                      | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `actor`                                                                                       | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `actorApiKeyId`                                                                               | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `actorOrgId`                                                                                  | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `actorTeamId`                                                                                 | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `actorUserId`                                                                                 | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `actorUserType`                                                                               | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `after`                                                                                       | *any*                                                                                         | :heavy_check_mark:                                                                            | Any JSON value; its shape is constrained by the flag's value_type.                            |
| `before`                                                                                      | *any*                                                                                         | :heavy_check_mark:                                                                            | Any JSON value; its shape is constrained by the flag's value_type.                            |
| `entityKey`                                                                                   | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `entityType`                                                                                  | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `id`                                                                                          | *number*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `occurredAt`                                                                                  | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `requestId`                                                                                   | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |