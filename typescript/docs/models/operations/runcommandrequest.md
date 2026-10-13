# RunCommandRequest

## Example Usage

```typescript
import { RunCommandRequest } from "@meetkai/mka1/models/operations";

let value: RunCommandRequest = {
  sessionId: "demo-python-20260316",
  commandRequest: {
    sessionId: "<id>",
    command: "<value>",
  },
};
```

## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            | Example                                                                |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `sessionId`                                                            | *string*                                                               | :heavy_check_mark:                                                     | N/A                                                                    | demo-python-20260316                                                   |
| `xOnBehalfOf`                                                          | *string*                                                               | :heavy_minus_sign:                                                     | Optional external end-user identifier forwarded by the API gateway.    |                                                                        |
| `commandRequest`                                                       | [components.CommandRequest](../../models/components/commandrequest.md) | :heavy_check_mark:                                                     | N/A                                                                    |                                                                        |