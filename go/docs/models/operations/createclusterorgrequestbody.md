# CreateClusterOrgRequestBody


## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `OrgName`                                                                                     | `string`                                                                                      | :heavy_check_mark:                                                                            | Required organization name. No owner or user is created.                                      |
| `OrgSlug`                                                                                     | `string`                                                                                      | :heavy_check_mark:                                                                            | Required unique slug: 1–64 lowercase letters, digits or hyphens. Reserved slugs are rejected. |