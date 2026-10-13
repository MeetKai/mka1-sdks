# Organizations

## Example Usage

```typescript
import { Organizations } from "@meetkai/mka1/models/operations";

let value: Organizations = {
  id: "<id>",
  slug: "<value>",
  name: "<value>",
  logo: "<value>",
  status: "deleted",
  createdAt: "1724648214043",
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `id`                                                                                 | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `slug`                                                                               | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `name`                                                                               | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `logo`                                                                               | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `status`                                                                             | [operations.ListClusterOrgsStatus](../../models/operations/listclusterorgsstatus.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `createdAt`                                                                          | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `memberCount`                                                                        | *number*                                                                             | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `apiKeyCount`                                                                        | *number*                                                                             | :heavy_minus_sign:                                                                   | N/A                                                                                  |