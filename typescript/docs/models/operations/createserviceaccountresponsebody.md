# CreateServiceAccountResponseBody

Service account created

## Example Usage

```typescript
import { CreateServiceAccountResponseBody } from "@meetkai/mka1/models/operations";

let value: CreateServiceAccountResponseBody = {
  serviceAccount: {
    id: "<id>",
    orgId: "<id>",
    name: "<value>",
    createdAt: "1720179124074",
  },
};
```

## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `serviceAccount`                                                       | [operations.ServiceAccount](../../models/operations/serviceaccount.md) | :heavy_check_mark:                                                     | N/A                                                                    |