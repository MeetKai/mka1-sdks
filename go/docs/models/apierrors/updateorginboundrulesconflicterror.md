# UpdateOrgInboundRulesConflictError

Conflict. `code: "inbound_rules_unavailable"` means enabling was refused because inbound rules are not enabled on this cluster; a disabled policy can still be saved.


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `Message`                                                          | `string`                                                           | :heavy_check_mark:                                                 | N/A                                                                |
| `Code`                                                             | `*string`                                                          | :heavy_minus_sign:                                                 | N/A                                                                |
| `HTTPMeta`                                                         | [components.HTTPMetadata](../../models/components/httpmetadata.md) | :heavy_check_mark:                                                 | N/A                                                                |