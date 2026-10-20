# GetJwtFromKeyBadRequestError

Invalid request body


## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `Message`                                                                          | `string`                                                                           | :heavy_check_mark:                                                                 | Top-level validation error summary for the request body.                           |
| `Details`                                                                          | [][operations.GetJwtFromKeyDetail](../../models/operations/getjwtfromkeydetail.md) | :heavy_check_mark:                                                                 | List of field-level validation errors.                                             |
| `HTTPMeta`                                                                         | [components.HTTPMetadata](../../models/components/httpmetadata.md)                 | :heavy_check_mark:                                                                 | N/A                                                                                |