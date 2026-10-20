# AcceptClusterInviteBadRequestError

Bad request. `code: "reserved_org_slug"` distinguishes a slug that nobody may hold from the 409 returned when another org already holds it.


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `Message`                                                          | `string`                                                           | :heavy_check_mark:                                                 | N/A                                                                |
| `Code`                                                             | `*string`                                                          | :heavy_minus_sign:                                                 | N/A                                                                |
| `HTTPMeta`                                                         | [components.HTTPMetadata](../../models/components/httpmetadata.md) | :heavy_check_mark:                                                 | N/A                                                                |