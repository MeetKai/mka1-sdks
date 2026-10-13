# AgentRunWake

## Example Usage

```typescript
import { AgentRunWake } from "@meetkai/mka1/models/components";

let value: AgentRunWake = {
  object: "agent.run.wake",
  runId: "<id>",
  gatewayResponseId: "<id>",
  gatewayWake: {
    "key": "<value>",
    "key1": "<value>",
    "key2": "<value>",
  },
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `object`                                                                       | [components.AgentRunWakeObject](../../models/components/agentrunwakeobject.md) | :heavy_check_mark:                                                             | N/A                                                                            |
| `runId`                                                                        | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `gatewayResponseId`                                                            | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `gatewayWake`                                                                  | Record<string, *any*>                                                          | :heavy_check_mark:                                                             | N/A                                                                            |