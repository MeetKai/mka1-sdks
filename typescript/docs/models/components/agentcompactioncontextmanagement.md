# AgentCompactionContextManagement

## Example Usage

```typescript
import { AgentCompactionContextManagement } from "@meetkai/mka1/models/components";

let value: AgentCompactionContextManagement = {
  type: "compaction",
  compactThreshold: 609597,
};
```

## Fields

| Field                                                                                                              | Type                                                                                                               | Required                                                                                                           | Description                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ |
| `type`                                                                                                             | [components.AgentCompactionContextManagementType](../../models/components/agentcompactioncontextmanagementtype.md) | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `compactThreshold`                                                                                                 | *number*                                                                                                           | :heavy_check_mark:                                                                                                 | The token threshold above which conversation context should be compacted. Must be at least 1000.                   |