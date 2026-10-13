# CompactionContextManagement

## Example Usage

```typescript
import { CompactionContextManagement } from "@meetkai/mka1/models/components";

let value: CompactionContextManagement = {
  type: "compaction",
  compactThreshold: 129057,
};
```

## Fields

| Field                                                                                            | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `type`                                                                                           | *"compaction"*                                                                                   | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `compactThreshold`                                                                               | *number*                                                                                         | :heavy_check_mark:                                                                               | The token threshold above which conversation context should be compacted. Must be at least 1000. |