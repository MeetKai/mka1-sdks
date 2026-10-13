# InputItemListObject

Paginated list object containing input items for a response with cursor-based pagination metadata.

## Example Usage

```typescript
import { InputItemListObject } from "@meetkai/mka1/models/components";

let value: InputItemListObject = {
  object: "list",
  data: [
    {
      type: "local_shell_call",
      id: "<id>",
      callId: "<id>",
      action: {
        type: "exec",
        command: [
          "<value 1>",
          "<value 2>",
        ],
        env: {
          "key": "<value>",
          "key1": "<value>",
          "key2": "<value>",
        },
      },
      status: "<value>",
    },
  ],
  hasMore: true,
};
```

## Fields

| Field                                                                                                                                                           | Type                                                                                                                                                            | Required                                                                                                                                                        | Description                                                                                                                                                     |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `object`                                                                                                                                                        | *"list"*                                                                                                                                                        | :heavy_check_mark:                                                                                                                                              | The object type, always 'list' for paginated list responses.                                                                                                    |
| `data`                                                                                                                                                          | *components.Item*[]                                                                                                                                             | :heavy_check_mark:                                                                                                                                              | Array of input items (messages, prompts, instructions) that were provided when creating the response. Each item contains its type, content, role, and metadata. |
| `firstId`                                                                                                                                                       | *string*                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                              | The ID of the first item in the current page. Used as a reference point for pagination.                                                                         |
| `lastId`                                                                                                                                                        | *string*                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                              | The ID of the last item in the current page. Used as a cursor for fetching the next page.                                                                       |
| `hasMore`                                                                                                                                                       | *boolean*                                                                                                                                                       | :heavy_check_mark:                                                                                                                                              | Indicates whether there are more items available beyond the current page. True if additional pages exist, false otherwise.                                      |