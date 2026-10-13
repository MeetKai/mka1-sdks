# ShellCallOutputWithIdOutput

Result of the executed command.

## Example Usage

```typescript
import { ShellCallOutputWithIdOutput } from "@meetkai/mka1/models/components";

let value: ShellCallOutputWithIdOutput = {
  stdout: "<value>",
  stderr: "<value>",
  outcome: {
    type: "timeout",
    exitCode: 631345,
  },
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `stdout`                                                                                           | *string*                                                                                           | :heavy_check_mark:                                                                                 | Standard output from the command.                                                                  |
| `stderr`                                                                                           | *string*                                                                                           | :heavy_check_mark:                                                                                 | Standard error from the command.                                                                   |
| `outcome`                                                                                          | [components.ShellCallOutputWithIdOutcome](../../models/components/shellcalloutputwithidoutcome.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |