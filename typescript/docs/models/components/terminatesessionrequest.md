# TerminateSessionRequest

## Example Usage

```typescript
import { TerminateSessionRequest } from "@meetkai/mka1/models/components";

let value: TerminateSessionRequest = {
  sessionId: "<id>",
};
```

## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `sessionId`                                                      | *string*                                                         | :heavy_check_mark:                                               | N/A                                                              |
| `sessionToken`                                                   | *string*                                                         | :heavy_minus_sign:                                               | N/A                                                              |
| `expectedSessionKind`                                            | [components.SessionKind](../../models/components/sessionkind.md) | :heavy_minus_sign:                                               | N/A                                                              |