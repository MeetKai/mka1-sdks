# GetJwtFromKeyBadRequestException

Invalid request body


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `Message`                                                                | *string*                                                                 | :heavy_check_mark:                                                       | Top-level validation error summary for the request body.                 |
| `Details`                                                                | List<[GetJwtFromKeyDetail](../../Types/Requests/GetJwtFromKeyDetail.md)> | :heavy_check_mark:                                                       | List of field-level validation errors.                                   |
| `HttpMeta`                                                               | [HTTPMetadata](../../Types/Components/HTTPMetadata.md)                   | :heavy_check_mark:                                                       | N/A                                                                      |