# CustomToolCallOutput

Custom tool call output item: The output payload returned by a custom tool call.

## Example Usage

```typescript
import { CustomToolCallOutput } from "@meetkai/mka1/models/components";

let value: CustomToolCallOutput = {
  type: "custom_tool_call_output",
  callId: "<id>",
  output: "<value>",
};
```

## Fields

| Field                       | Type                        | Required                    | Description                 |
| --------------------------- | --------------------------- | --------------------------- | --------------------------- |
| `type`                      | *"custom_tool_call_output"* | :heavy_check_mark:          | N/A                         |
| `callId`                    | *string*                    | :heavy_check_mark:          | N/A                         |
| `output`                    | *string*                    | :heavy_check_mark:          | N/A                         |
| `id`                        | *string*                    | :heavy_minus_sign:          | N/A                         |