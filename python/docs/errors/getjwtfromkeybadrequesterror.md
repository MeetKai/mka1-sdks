# GetJwtFromKeyBadRequestError

Invalid request body


## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `message`                                                            | *str*                                                                | :heavy_check_mark:                                                   | Top-level validation error summary for the request body.             |
| `details`                                                            | List[[models.GetJwtFromKeyDetail](../models/getjwtfromkeydetail.md)] | :heavy_check_mark:                                                   | List of field-level validation errors.                               |