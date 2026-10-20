# FunctionToolDefinition

Function tool definition: Defines a callable function tool. Provide a tool name and parameters schema, with optional description and deferred loading.


## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Type`             | `string`           | :heavy_check_mark: | N/A                |
| `Name`             | `string`           | :heavy_check_mark: | N/A                |
| `Parameters`       | map[string]`any`   | :heavy_check_mark: | N/A                |
| `Strict`           | `bool`             | :heavy_check_mark: | N/A                |
| `Description`      | `*string`          | :heavy_minus_sign: | N/A                |
| `DeferLoading`     | `*bool`            | :heavy_minus_sign: | N/A                |