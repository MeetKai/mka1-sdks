# CodeInterpreterToolDefinition

Code interpreter tool definition: Enables code execution. Provide an explicit container ID or auto container configuration with optional file IDs. Non-null caller memory_limit is unsupported and rejected.

## Example Usage

```typescript
import { CodeInterpreterToolDefinition } from "@meetkai/mka1/models/components";

let value: CodeInterpreterToolDefinition = {
  type: "code_interpreter",
  container: "<value>",
};
```

## Fields

| Field                  | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `type`                 | *"code_interpreter"*   | :heavy_check_mark:     | N/A                    |
| `container`            | *components.Container* | :heavy_check_mark:     | N/A                    |