# TerminateSessionRequest

## Example Usage

```typescript
import { TerminateSessionRequest } from "@meetkai/mka1/models/operations";

let value: TerminateSessionRequest = {
  sessionId: "demo-python-20260316",
  terminateSessionRequest: {
    sessionId: "<id>",
  },
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              | Example                                                                                  |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `sessionId`                                                                              | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      | demo-python-20260316                                                                     |
| `xOnBehalfOf`                                                                            | *string*                                                                                 | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |                                                                                          |
| `terminateSessionRequest`                                                                | [components.TerminateSessionRequest](../../models/components/terminatesessionrequest.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |                                                                                          |