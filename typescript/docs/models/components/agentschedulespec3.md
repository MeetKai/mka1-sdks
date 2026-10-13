# AgentScheduleSpec3

## Example Usage

```typescript
import { AgentScheduleSpec3 } from "@meetkai/mka1/models/components";

let value: AgentScheduleSpec3 = {
  type: "cron",
  cronExpression: "<value>",
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `type`             | *"cron"*           | :heavy_check_mark: | N/A                |
| `cronExpression`   | *string*           | :heavy_check_mark: | N/A                |
| `timezone`         | *string*           | :heavy_minus_sign: | N/A                |