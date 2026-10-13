# WebSearchToolCall

Web search call item: A web-search tool-call record containing the executed action and status.


## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `type`                                                 | *Literal["web_search_call"]*                           | :heavy_check_mark:                                     | N/A                                                    |
| `id`                                                   | *str*                                                  | :heavy_check_mark:                                     | N/A                                                    |
| `action`                                               | [models.WebSearchAction](../models/websearchaction.md) | :heavy_check_mark:                                     | N/A                                                    |
| `status`                                               | *str*                                                  | :heavy_check_mark:                                     | N/A                                                    |