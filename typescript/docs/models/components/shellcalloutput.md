# ShellCallOutput

Shell call output item: The captured output from a hosted-container shell tool call.

## Example Usage

```typescript
import { ShellCallOutput } from "@meetkai/mka1/models/components";

let value: ShellCallOutput = {
  type: "shell_call_output",
  id: "<id>",
  callId: "<id>",
  output: {
    stdout: "<value>",
    stderr: "<value>",
    outcome: {
      type: "timeout",
      exitCode: 589719,
    },
  },
};
```

## Fields

| Field                                                                                                                                                                                    | Type                                                                                                                                                                                     | Required                                                                                                                                                                                 | Description                                                                                                                                                                              |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `type`                                                                                                                                                                                   | *"shell_call_output"*                                                                                                                                                                    | :heavy_check_mark:                                                                                                                                                                       | N/A                                                                                                                                                                                      |
| `id`                                                                                                                                                                                     | *string*                                                                                                                                                                                 | :heavy_check_mark:                                                                                                                                                                       | N/A                                                                                                                                                                                      |
| `callId`                                                                                                                                                                                 | *string*                                                                                                                                                                                 | :heavy_check_mark:                                                                                                                                                                       | N/A                                                                                                                                                                                      |
| `output`                                                                                                                                                                                 | [components.Output](../../models/components/output.md)                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                       | Result of the executed command.                                                                                                                                                          |
| `status`                                                                                                                                                                                 | [components.Status](../../models/components/status.md)                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                       | The processing status of an individual item. 'in_progress' means currently processing, 'completed' means finished successfully, 'incomplete' means processing stopped before completion. |