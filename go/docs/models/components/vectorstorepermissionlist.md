# VectorStorePermissionList

The permissions held on a vector store: the owner first, then the team, then individual principals.


## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `Object`                                                                               | `string`                                                                               | :heavy_check_mark:                                                                     | The object type, which is always 'list'.                                               |
| `Data`                                                                                 | [][components.VectorStorePermission](../../models/components/vectorstorepermission.md) | :heavy_check_mark:                                                                     | Every permission on the store; the list is complete, not paginated.                    |