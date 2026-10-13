# ListPromptsResponse


## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `object`                                                               | *Literal["list"]*                                                      | :heavy_check_mark:                                                     | Object type                                                            |
| `data`                                                                 | List[[models.UpdatePromptResponse](../models/updatepromptresponse.md)] | :heavy_check_mark:                                                     | Array of prompt objects                                                |
| `has_more`                                                             | *bool*                                                                 | :heavy_check_mark:                                                     | Whether there are more results available                               |
| `first_id`                                                             | *Optional[str]*                                                        | :heavy_minus_sign:                                                     | ID of the first item in the list                                       |
| `last_id`                                                              | *Optional[str]*                                                        | :heavy_minus_sign:                                                     | ID of the last item in the list                                        |