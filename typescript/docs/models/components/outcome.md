# Outcome

## Example Usage

```typescript
import { Outcome } from "@meetkai/mka1/models/components";

let value: Outcome = {
  type: "exit",
  exitCode: 112837,
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `type`                                                                           | [components.ShellCallOutputType](../../models/components/shellcalloutputtype.md) | :heavy_check_mark:                                                               | Whether the command exited normally or timed out.                                |
| `exitCode`                                                                       | *number*                                                                         | :heavy_check_mark:                                                               | Exit code of the command, or null if timed out.                                  |