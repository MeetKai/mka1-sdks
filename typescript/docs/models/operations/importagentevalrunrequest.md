# ImportAgentEvalRunRequest

## Example Usage

```typescript
import { ImportAgentEvalRunRequest } from "@meetkai/mka1/models/operations";

let value: ImportAgentEvalRunRequest = {
  importAgentRunRequest: {
    suiteId: "<id>",
    agentName: "<value>",
    model: "CX-9",
  },
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `xOnBehalfOf`                                                                        | *string*                                                                             | :heavy_minus_sign:                                                                   | Optional external end-user identifier forwarded by the API gateway.                  |
| `importAgentRunRequest`                                                              | [components.ImportAgentRunRequest](../../models/components/importagentrunrequest.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |