# BatchGetFeedbackResponseResult1

Error result when the completion/response ID doesn't exist


## Fields

| Field                                       | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `id`                                        | *str*                                       | :heavy_check_mark:                          | The request ID that was queried             |
| `error`                                     | *Literal["not_found"]*                      | :heavy_check_mark:                          | Error indicating the resource doesn't exist |