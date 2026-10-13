# Agent

## Example Usage

```typescript
import { Agent } from "@meetkai/mka1/models/components";

let value: Agent = {
  object: "agent",
  id: "<id>",
  name: "<value>",
  description: "unlike beside moist unto league with till per rear license",
  model: "functionary-pt",
  instructions: "<value>",
  tools: [
    {
      type: "file_search",
    },
  ],
  toolChoice: "<value>",
  parallelToolCalls: false,
  maxToolCalls: 182471,
  text: {},
  reasoning: {},
  metadata: {
    "key": "<value>",
    "key1": "<value>",
    "key2": "<value>",
  },
  version: 197260,
  createdAt: new Date("2025-03-25T10:59:00.090Z"),
  updatedAt: new Date("2025-12-21T08:31:13.203Z"),
  deletedAt: new Date("2025-01-23T12:18:08.641Z"),
};
```

## Fields

| Field                                                                                            | Type                                                                                             | Required                                                                                         | Description                                                                                      | Example                                                                                          |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `object`                                                                                         | [components.AgentObject](../../models/components/agentobject.md)                                 | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `id`                                                                                             | *string*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
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
| `version`                                                                                        | *number*                                                                                         | :heavy_check_mark:                                                                               | Current configuration version. Incremented on every update or rollback.                          |                                                                                                  |
| `createdAt`                                                                                      | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)    | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `updatedAt`                                                                                      | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)    | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `deletedAt`                                                                                      | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)    | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |