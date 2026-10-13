# OutputMessage

Output message item: An assistant message containing generated text content or refusal content.

## Example Usage

```typescript
import { OutputMessage } from "@meetkai/mka1/models/components";

let value: OutputMessage = {
  type: "message",
  id: "<id>",
  role: "assistant",
  content: [
    {
      type: "output_text",
      text: "<value>",
    },
  ],
  status: "in_progress",
};
```

## Fields

| Field                                                                                             | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `type`                                                                                            | *"message"*                                                                                       | :heavy_check_mark:                                                                                | The item type identifier for message outputs.                                                     |
| `id`                                                                                              | *string*                                                                                          | :heavy_check_mark:                                                                                | The unique identifier for this output message.                                                    |
| `role`                                                                                            | *"assistant"*                                                                                     | :heavy_check_mark:                                                                                | The role of the message sender. Always 'assistant' for model-generated messages.                  |
| `content`                                                                                         | *components.OutputMessageContent*[]                                                               | :heavy_check_mark:                                                                                | Array of content items in the assistant's response. Can contain text outputs or refusal messages. |
| `status`                                                                                          | [components.OutputMessageStatus](../../models/components/outputmessagestatus.md)                  | :heavy_check_mark:                                                                                | The processing status of this message (in_progress, completed, or incomplete).                    |
| `phase`                                                                                           | [components.Phase](../../models/components/phase.md)                                              | :heavy_minus_sign:                                                                                | Labels an assistant message as intermediate commentary or the final answer.                       |