# BatchGetFeedbackRequest

Request parameters for batch retrieving feedback by multiple request IDs.


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `ids`                                                                    | List[*str*]                                                              | :heavy_check_mark:                                                       | Array of request IDs (chatcmpl-xxx or resp-xxx) to retrieve feedback for |