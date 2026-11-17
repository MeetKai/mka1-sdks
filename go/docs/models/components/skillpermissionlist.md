# SkillPermissionList

The permissions held on a skill: the owner first, then the team, then individual principals.


## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `Object`                                                                   | `string`                                                                   | :heavy_check_mark:                                                         | The object type, which is always 'list'.                                   |
| `Data`                                                                     | [][components.SkillPermission](../../models/components/skillpermission.md) | :heavy_check_mark:                                                         | Every permission on the skill; the list is complete, not paginated.        |