# RunCodeRequest

## Example Usage

```typescript
import { RunCodeRequest } from "@meetkai/mka1/models/operations";

let value: RunCodeRequest = {
  sessionId: "demo-python-20260316",
  codeRequest: {
    sessionId: "<id>",
    code: "<value>",
  },
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `sessionId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `codeRequest`                                                       | [components.CodeRequest](../../models/components/coderequest.md)    | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |