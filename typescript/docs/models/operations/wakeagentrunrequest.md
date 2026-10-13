# WakeAgentRunRequest

## Example Usage

```typescript
import { WakeAgentRunRequest } from "@meetkai/mka1/models/operations";

let value: WakeAgentRunRequest = {
  agentId: "<id>",
  runId: "<id>",
  wakeAgentRunRequest: {
    input: "<value>",
  },
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `agentId`                                                                        | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `runId`                                                                          | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `xOnBehalfOf`                                                                    | *string*                                                                         | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |
| `wakeAgentRunRequest`                                                            | [components.WakeAgentRunRequest](../../models/components/wakeagentrunrequest.md) | :heavy_check_mark:                                                               | N/A                                                                              |