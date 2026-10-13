# SleepToolDefinition

Sleep tool definition: Allows an agent to pause the current response briefly and resume later or when woken.

## Example Usage

```typescript
import { SleepToolDefinition } from "@meetkai/mka1/models/components";

let value: SleepToolDefinition = {
  type: "sleep",
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `type`             | *"sleep"*          | :heavy_check_mark: | N/A                |