# ShellCallOutputWithIdOutcome

## Example Usage

```typescript
import { ShellCallOutputWithIdOutcome } from "@meetkai/mka1/models/components";

let value: ShellCallOutputWithIdOutcome = {
  type: "exit",
  exitCode: 590697,
};
```

## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `type`                                                                                       | [components.ShellCallOutputWithIdType](../../models/components/shellcalloutputwithidtype.md) | :heavy_check_mark:                                                                           | Whether the command exited normally or timed out.                                            |
| `exitCode`                                                                                   | *number*                                                                                     | :heavy_check_mark:                                                                           | Exit code of the command, or null if timed out.                                              |