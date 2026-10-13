# CompactResponseRequest

Request schema for compacting a response's conversation history into a condensed summary.

## Example Usage

```typescript
import { CompactResponseRequest } from "@meetkai/mka1/models/components";

let value: CompactResponseRequest = {
  model: "Volt",
  input: [
    {
      type: "mcp_list_tools",
      id: "<id>",
      serverLabel: "<value>",
      tools: [],
    },
  ],
};
```

## Fields

| Field                                                                                                                           | Type                                                                                                                            | Required                                                                                                                        | Description                                                                                                                     |
| ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- |
| `model`                                                                                                                         | *string*                                                                                                                        | :heavy_check_mark:                                                                                                              | The model to use for generating the compaction summary.                                                                         |
| `input`                                                                                                                         | *components.CompactResponseRequestInput*                                                                                        | :heavy_minus_sign:                                                                                                              | Text, image, or file inputs to the model, used to generate a response.                                                          |
| `previousResponseId`                                                                                                            | *string*                                                                                                                        | :heavy_minus_sign:                                                                                                              | The ID of a previous response whose conversation history should be compacted. If omitted, only the provided input is compacted. |