# ListTeamsResponseBody

OK

## Example Usage

```typescript
import { ListTeamsResponseBody } from "@meetkai/mka1/models/operations";

let value: ListTeamsResponseBody = {
  teams: [
    {
      id: "<id>",
      name: "<value>",
      organizationId: "<id>",
      createdAt: "1713643293895",
      updatedAt: "1735641679198",
    },
  ],
};
```

## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `teams`                                                | [operations.Teams](../../models/operations/teams.md)[] | :heavy_check_mark:                                     | N/A                                                    |