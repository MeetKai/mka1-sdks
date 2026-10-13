# AgentVersion

## Example Usage

```typescript
import { AgentVersion } from "@meetkai/mka1/models/components";

let value: AgentVersion = {
  object: "agent.version",
  id: "<id>",
  agentId: "<id>",
  version: 616293,
  isCurrent: true,
  restoredFromVersion: 732509,
  name: "<value>",
  description: null,
  model: "functionary-pt",
  instructions: null,
  tools: [
    {
      type: "function",
      name: "<value>",
      parameters: {
        "key": "<value>",
        "key1": "<value>",
      },
    },
  ],
  toolChoice: "<value>",
  parallelToolCalls: false,
  maxToolCalls: 882407,
  text: {},
  reasoning: {},
  metadata: {
    "key": "<value>",
    "key1": "<value>",
    "key2": "<value>",
  },
  createdAt: new Date("2025-10-21T22:00:02.055Z"),
};
```

## Fields

| Field                                                                                            | Type                                                                                             | Required                                                                                         | Description                                                                                      | Example                                                                                          |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `object`                                                                                         | [components.AgentVersionObject](../../models/components/agentversionobject.md)                   | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `id`                                                                                             | *string*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `agentId`                                                                                        | *string*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `version`                                                                                        | *number*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `isCurrent`                                                                                      | *boolean*                                                                                        | :heavy_check_mark:                                                                               | True when this version matches the agent's current configuration.                                |                                                                                                  |
| `restoredFromVersion`                                                                            | *number*                                                                                         | :heavy_check_mark:                                                                               | When this version was produced by a rollback, the version it was restored from.                  |                                                                                                  |
| `name`                                                                                           | *string*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `description`                                                                                    | *string*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `model`                                                                                          | *string*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              | functionary-pt                                                                                   |
| `instructions`                                                                                   | *string*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `tools`                                                                                          | *components.ToolDefinition*[]                                                                    | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `toolChoice`                                                                                     | *any*                                                                                            | :heavy_check_mark:                                                                               | Arbitrary JSON value.                                                                            |                                                                                                  |
| `parallelToolCalls`                                                                              | *boolean*                                                                                        | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `maxToolCalls`                                                                                   | *number*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `text`                                                                                           | [components.AgentTextConfiguration](../../models/components/agenttextconfiguration.md)           | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `reasoning`                                                                                      | [components.AgentReasoningConfiguration](../../models/components/agentreasoningconfiguration.md) | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `metadata`                                                                                       | Record<string, *string*>                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `createdAt`                                                                                      | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)    | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |