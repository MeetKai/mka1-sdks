# GetClusterOrgResponseBody

OK

## Example Usage

```typescript
import { GetClusterOrgResponseBody } from "@meetkai/mka1/models/operations";

let value: GetClusterOrgResponseBody = {
  id: "<id>",
  slug: "<value>",
  name: "<value>",
  logo: "<value>",
  status: "deleted",
  createdAt: "1725422349531",
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `id`                                                                             | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `slug`                                                                           | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `name`                                                                           | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `logo`                                                                           | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `status`                                                                         | [operations.GetClusterOrgStatus](../../models/operations/getclusterorgstatus.md) | :heavy_check_mark:                                                               | N/A                                                                              |
| `createdAt`                                                                      | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `memberCount`                                                                    | *number*                                                                         | :heavy_minus_sign:                                                               | N/A                                                                              |
| `apiKeyCount`                                                                    | *number*                                                                         | :heavy_minus_sign:                                                               | N/A                                                                              |