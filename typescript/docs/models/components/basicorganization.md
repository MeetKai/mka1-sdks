# BasicOrganization

## Example Usage

```typescript
import { BasicOrganization } from "@meetkai/mka1/models/components";

let value: BasicOrganization = {
  id: "<id>",
  name: "<value>",
  slug: "<value>",
  logo: "<value>",
  createdAt: "1706533499013",
  status: "active",
  metadata: {},
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `id`                                                                                           | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `name`                                                                                         | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `slug`                                                                                         | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `logo`                                                                                         | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `createdAt`                                                                                    | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `status`                                                                                       | [components.BasicOrganizationStatus](../../models/components/basicorganizationstatus.md)       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `metadata`                                                                                     | [components.OrganizationMetadataOutput](../../models/components/organizationmetadataoutput.md) | :heavy_check_mark:                                                                             | N/A                                                                                            |