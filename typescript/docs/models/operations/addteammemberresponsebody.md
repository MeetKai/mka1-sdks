# AddTeamMemberResponseBody

Member added

## Example Usage

```typescript
import { AddTeamMemberResponseBody } from "@meetkai/mka1/models/operations";

let value: AddTeamMemberResponseBody = {
  member: {
    id: "<id>",
    teamId: "<id>",
    userId: "<id>",
    createdAt: "1734871892137",
  },
};
```

## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `member`                                               | [operations.Member](../../models/operations/member.md) | :heavy_check_mark:                                     | N/A                                                    |