# ListServiceAccountsResponseBody

OK

## Example Usage

```typescript
import { ListServiceAccountsResponseBody } from "@meetkai/mka1/models/operations";

let value: ListServiceAccountsResponseBody = {
  serviceAccounts: [
    {
      id: "<id>",
      orgId: "<id>",
      name: "<value>",
      createdAt: "1709271065085",
    },
  ],
};
```

## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `serviceAccounts`                                                          | [operations.ServiceAccounts](../../models/operations/serviceaccounts.md)[] | :heavy_check_mark:                                                         | N/A                                                                        |