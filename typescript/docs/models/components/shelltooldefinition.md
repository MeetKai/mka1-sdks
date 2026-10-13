# ShellToolDefinition

Shell tool definition: Enables shell command execution in a managed container environment.

## Example Usage

```typescript
import { ShellToolDefinition } from "@meetkai/mka1/models/components";

let value: ShellToolDefinition = {
  type: "shell",
};
```

## Fields

| Field                         | Type                          | Required                      | Description                   |
| ----------------------------- | ----------------------------- | ----------------------------- | ----------------------------- |
| `type`                        | *"shell"*                     | :heavy_check_mark:            | N/A                           |
| `environment`                 | *components.ShellEnvironment* | :heavy_minus_sign:            | N/A                           |