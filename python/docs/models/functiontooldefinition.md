# FunctionToolDefinition

Function tool definition: Defines a callable function tool. Provide a tool name and parameters schema, with optional description and deferred loading.


## Fields

| Field                 | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `type`                | *Literal["function"]* | :heavy_check_mark:    | N/A                   |
| `name`                | *str*                 | :heavy_check_mark:    | N/A                   |
| `parameters`          | Dict[str, *Any*]      | :heavy_check_mark:    | N/A                   |
| `strict`              | *bool*                | :heavy_check_mark:    | N/A                   |
| `description`         | *Optional[str]*       | :heavy_minus_sign:    | N/A                   |
| `defer_loading`       | *Optional[bool]*      | :heavy_minus_sign:    | N/A                   |