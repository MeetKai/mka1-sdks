# ResponseOutputItemAddedEvent

## Example Usage

```typescript
import { ResponseOutputItemAddedEvent } from "@meetkai/mka1/models/components";

let value: ResponseOutputItemAddedEvent = {
  type: "response.output_item.added",
  sequenceNumber: 502729,
  outputIndex: 453630,
  item: {
    type: "custom_tool_call",
    callId: "<id>",
    input: "<value>",
    name: "<value>",
  },
};
```

## Fields

| Field                          | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `type`                         | *"response.output_item.added"* | :heavy_check_mark:             | N/A                            |
| `sequenceNumber`               | *number*                       | :heavy_check_mark:             | N/A                            |
| `outputIndex`                  | *number*                       | :heavy_check_mark:             | N/A                            |
| `item`                         | *components.Item*              | :heavy_check_mark:             | N/A                            |