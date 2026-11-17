# ResponsePermissionList

The permissions held on a response: the owner first, then the team, then individual principals.


## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `Object`                                                                         | `string`                                                                         | :heavy_check_mark:                                                               | The object type, which is always 'list'.                                         |
| `Data`                                                                           | [][components.ResponsePermission](../../models/components/responsepermission.md) | :heavy_check_mark:                                                               | Every permission on the response; the list is complete, not paginated.           |