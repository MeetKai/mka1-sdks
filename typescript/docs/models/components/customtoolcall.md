# CustomToolCall

Custom tool call item: A call record for a custom tool with input payload and tool name.

## Example Usage

```typescript
import { CustomToolCall } from "@meetkai/mka1/models/components";

let value: CustomToolCall = {
  type: "custom_tool_call",
  callId: "<id>",
  input: "<value>",
  name: "<value>",
};
```

## Fields

| Field                | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `type`               | *"custom_tool_call"* | :heavy_check_mark:   | N/A                  |
| `callId`             | *string*             | :heavy_check_mark:   | N/A                  |
| `input`              | *string*             | :heavy_check_mark:   | N/A                  |
| `name`               | *string*             | :heavy_check_mark:   | N/A                  |
| `id`                 | *string*             | :heavy_minus_sign:   | N/A                  |