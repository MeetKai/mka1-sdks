# FilePermissionList

The permissions held on a file: the owner first, then the team, then individual principals.


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `Object`                                                                 | `string`                                                                 | :heavy_check_mark:                                                       | The object type, which is always 'list'.                                 |
| `Data`                                                                   | [][components.FilePermission](../../models/components/filepermission.md) | :heavy_check_mark:                                                       | Every permission on the file; the list is complete, not paginated.       |