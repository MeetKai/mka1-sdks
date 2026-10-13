# SemanticRule

One per-row check beyond the row schema: what `_semantics` yields and what
`GET /formats/{id}` serves (api.md §4).


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `code`                                                                                | *str*                                                                                 | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `severity`                                                                            | [models.Severity](../models/severity.md)                                              | :heavy_check_mark:                                                                    | Whether an issue stops a consumer (`ERROR`) or is for a human to look at (`WARNING`). |
| `description`                                                                         | *str*                                                                                 | :heavy_check_mark:                                                                    | N/A                                                                                   |