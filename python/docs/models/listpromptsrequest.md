# ListPromptsRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `after`                                                             | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `order`                                                             | [Optional[models.ListPromptsOrder]](../models/listpromptsorder.md)  | :heavy_minus_sign:                                                  | Sort order by creation date                                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |