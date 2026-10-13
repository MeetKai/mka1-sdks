# CustomToolDefinition

Custom tool definition: Defines a custom tool by name, with optional description and optional output format constraints.

## Example Usage

```typescript
import { CustomToolDefinition } from "@meetkai/mka1/models/components";

let value: CustomToolDefinition = {
  type: "custom",
  name: "<value>",
};
```

## Fields

| Field                         | Type                          | Required                      | Description                   |
| ----------------------------- | ----------------------------- | ----------------------------- | ----------------------------- |
| `type`                        | *"custom"*                    | :heavy_check_mark:            | N/A                           |
| `name`                        | *string*                      | :heavy_check_mark:            | N/A                           |
| `description`                 | *string*                      | :heavy_minus_sign:            | N/A                           |
| `format`                      | *components.CustomToolFormat* | :heavy_minus_sign:            | N/A                           |