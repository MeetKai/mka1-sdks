# ConversationPermissionList

The permissions held on a conversation: the owner first, then the team, then individual principals.


## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `Object`                                                                                 | `string`                                                                                 | :heavy_check_mark:                                                                       | The object type, which is always 'list'.                                                 |
| `Data`                                                                                   | [][components.ConversationPermission](../../models/components/conversationpermission.md) | :heavy_check_mark:                                                                       | Every permission on the conversation; the list is complete, not paginated.               |