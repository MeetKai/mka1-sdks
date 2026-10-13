# DeletePromptResponse


## Fields

| Field                       | Type                        | Required                    | Description                 |
| --------------------------- | --------------------------- | --------------------------- | --------------------------- |
| `id`                        | *str*                       | :heavy_check_mark:          | The deleted prompt ID       |
| `object`                    | *Literal["prompt.deleted"]* | :heavy_check_mark:          | Object type                 |
| `deleted`                   | *Literal[True]*             | :heavy_check_mark:          | Deletion confirmation       |