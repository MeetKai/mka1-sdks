# AgentList

## Example Usage

```typescript
import { AgentList } from "@meetkai/mka1/models/components";

let value: AgentList = {
  object: "list",
  data: [],
  firstId: "<id>",
  lastId: "<id>",
  hasMore: true,
};
```

## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `object`                                                                 | [components.AgentListObject](../../models/components/agentlistobject.md) | :heavy_check_mark:                                                       | N/A                                                                      |
| `data`                                                                   | [components.Agent](../../models/components/agent.md)[]                   | :heavy_check_mark:                                                       | N/A                                                                      |
| `firstId`                                                                | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `lastId`                                                                 | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `hasMore`                                                                | *boolean*                                                                | :heavy_check_mark:                                                       | N/A                                                                      |