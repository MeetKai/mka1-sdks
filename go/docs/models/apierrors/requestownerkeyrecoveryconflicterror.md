# RequestOwnerKeyRecoveryConflictError

`pending_exists` (with `requestId`): the org already has a pending request. `org_inactive`: the org is suspended or deleted


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `Message`                                                          | `string`                                                           | :heavy_check_mark:                                                 | N/A                                                                |
| `Code`                                                             | `*string`                                                          | :heavy_minus_sign:                                                 | N/A                                                                |
| `RequestID`                                                        | `*string`                                                          | :heavy_minus_sign:                                                 | N/A                                                                |
| `HTTPMeta`                                                         | [components.HTTPMetadata](../../models/components/httpmetadata.md) | :heavy_check_mark:                                                 | N/A                                                                |