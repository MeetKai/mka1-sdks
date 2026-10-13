# CreateAgentRunRequest

## Example Usage

```typescript
import { CreateAgentRunRequest } from "@meetkai/mka1/models/operations";

let value: CreateAgentRunRequest = {
  agentId: "<id>",
  createAgentRunRequest: {
    input: "<value>",
  },
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `agentId`                                                                            | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `xOnBehalfOf`                                                                        | *string*                                                                             | :heavy_minus_sign:                                                                   | Optional external end-user identifier forwarded by the API gateway.                  |
| `createAgentRunRequest`                                                              | [components.CreateAgentRunRequest](../../models/components/createagentrunrequest.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |