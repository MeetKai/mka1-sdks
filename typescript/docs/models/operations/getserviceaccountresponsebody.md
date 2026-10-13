# GetServiceAccountResponseBody

OK

## Example Usage

```typescript
import { GetServiceAccountResponseBody } from "@meetkai/mka1/models/operations";

let value: GetServiceAccountResponseBody = {
  serviceAccount: {
    id: "<id>",
    orgId: "<id>",
    name: "<value>",
    createdAt: "1714225385758",
  },
  teams: [],
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `serviceAccount`                                                                                         | [operations.GetServiceAccountServiceAccount](../../models/operations/getserviceaccountserviceaccount.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `teams`                                                                                                  | [operations.GetServiceAccountTeams](../../models/operations/getserviceaccountteams.md)[]                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |