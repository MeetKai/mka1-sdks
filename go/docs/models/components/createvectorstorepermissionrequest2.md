# CreateVectorStorePermissionRequest2

A team grant names no principal.


## Fields

| Field                                                                                                          | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `GranteeType`                                                                                                  | `string`                                                                                                       | :heavy_check_mark:                                                                                             | Grants to every member of the store's team.                                                                    |
| `Role`                                                                                                         | [components.GrantableVectorStorePermissionRole](../../models/components/grantablevectorstorepermissionrole.md) | :heavy_check_mark:                                                                                             | The role to grant. `writer` includes `reader`.                                                                 |