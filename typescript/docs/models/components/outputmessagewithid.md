# OutputMessageWithId

Output message item: An assistant message containing generated text content or refusal content.

## Example Usage

```typescript
import { OutputMessageWithId } from "@meetkai/mka1/models/components";

let value: OutputMessageWithId = {
  type: "message",
  id: "<id>",
  role: "assistant",
  content: [
    {
      type: "output_text",
      text: "<value>",
    },
  ],
  status: "completed",
};
```

## Fields

| Field                                                                                             | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `type`                                                                                            | *"message"*                                                                                       | :heavy_check_mark:                                                                                | The item type identifier for message outputs.                                                     |
| `id`                                                                                              | *string*                                                                                          | :heavy_check_mark:                                                                                | The unique ID of the message.                                                                     |
| `role`                                                                                            | *"assistant"*                                                                                     | :heavy_check_mark:                                                                                | The role of the message sender. Always 'assistant' for model-generated messages.                  |
| `content`                                                                                         | *components.OutputMessageWithIdContent*[]                                                         | :heavy_check_mark:                                                                                | Array of content items in the assistant's response. Can contain text outputs or refusal messages. |
| `status`                                                                                          | [components.OutputMessageWithIdStatus](../../models/components/outputmessagewithidstatus.md)      | :heavy_check_mark:                                                                                | The processing status of this message (in_progress, completed, or incomplete).                    |
| `phase`                                                                                           | [components.OutputMessageWithIdPhase](../../models/components/outputmessagewithidphase.md)        | :heavy_minus_sign:                                                                                | Labels an assistant message as intermediate commentary or the final answer.                       |
| `responseId`                                                                                      | *string*                                                                                          | :heavy_minus_sign:                                                                                | The ID of the response that created this item, if any.                                            |
| `metadata`                                                                                        | Record<string, *string*>                                                                          | :heavy_minus_sign:                                                                                | Metadata from the response that created this item, if any.                                        |