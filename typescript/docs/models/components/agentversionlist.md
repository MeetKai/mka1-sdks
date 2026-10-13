# AgentVersionList

## Example Usage

```typescript
import { AgentVersionList } from "@meetkai/mka1/models/components";

let value: AgentVersionList = {
  object: "list",
  data: [
    {
      object: "agent.version",
      id: "<id>",
      agentId: "<id>",
      version: 991124,
      isCurrent: false,
      restoredFromVersion: 318787,
      name: "<value>",
      description: "blah narrate underachieve jacket overconfidently emphasize",
      model: "functionary-pt",
      instructions: "<value>",
      tools: [
        {
          type: "shell",
        },
      ],
      toolChoice: "<value>",
      parallelToolCalls: true,
      maxToolCalls: null,
      text: {},
      reasoning: {},
      metadata: {
        "key": "<value>",
        "key1": "<value>",
        "key2": "<value>",
      },
      createdAt: new Date("2026-07-24T06:25:08.281Z"),
    },
  ],
  firstId: "<id>",
  lastId: "<id>",
  hasMore: true,
};
```

## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `object`                                                                               | [components.AgentVersionListObject](../../models/components/agentversionlistobject.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `data`                                                                                 | [components.AgentVersion](../../models/components/agentversion.md)[]                   | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `firstId`                                                                              | *string*                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `lastId`                                                                               | *string*                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `hasMore`                                                                              | *boolean*                                                                              | :heavy_check_mark:                                                                     | N/A                                                                                    |