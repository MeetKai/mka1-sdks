# ListTeamMembersResponseBody

OK

## Example Usage

```typescript
import { ListTeamMembersResponseBody } from "@meetkai/mka1/models/operations";

let value: ListTeamMembersResponseBody = {
  members: [
    {
      id: "<id>",
      teamId: "<id>",
      userId: "<id>",
      createdAt: "1721539611221",
    },
  ],
};
```

## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `members`                                                  | [operations.Members](../../models/operations/members.md)[] | :heavy_check_mark:                                         | N/A                                                        |