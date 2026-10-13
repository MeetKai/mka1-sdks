# FunctionToolDefinition

Function tool definition: Defines a callable function tool. Provide a tool name and parameters schema, with optional description and deferred loading.

## Example Usage

```typescript
import { FunctionToolDefinition } from "@meetkai/mka1/models/components";

let value: FunctionToolDefinition = {
  type: "function",
  name: "<value>",
  parameters: {
    "key": "<value>",
  },
  strict: true,
};
```

## Fields

| Field                 | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `type`                | *"function"*          | :heavy_check_mark:    | N/A                   |
| `name`                | *string*              | :heavy_check_mark:    | N/A                   |
| `parameters`          | Record<string, *any*> | :heavy_check_mark:    | N/A                   |
| `strict`              | *boolean*             | :heavy_check_mark:    | N/A                   |
| `description`         | *string*              | :heavy_minus_sign:    | N/A                   |
| `deferLoading`        | *boolean*             | :heavy_minus_sign:    | N/A                   |