# GetPromptResponse

## Example Usage

```typescript
import { GetPromptResponse } from "@meetkai/mka1/models/components";

let value: GetPromptResponse = {
  id: "<id>",
  object: "prompt",
  name: "<value>",
  activeVersion: 866426,
  latestVersion: 668192,
  metadata: {
    "key": "<value>",
  },
  createdAt: new Date("2024-10-12T23:44:22.745Z"),
  updatedAt: new Date("2025-09-16T12:38:42.043Z"),
  activeTemplate: "<value>",
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `id`                                                                                          | *string*                                                                                      | :heavy_check_mark:                                                                            | Unique prompt identifier                                                                      |
| `object`                                                                                      | *"prompt"*                                                                                    | :heavy_check_mark:                                                                            | Object type                                                                                   |
| `name`                                                                                        | *string*                                                                                      | :heavy_check_mark:                                                                            | Human-readable prompt name                                                                    |
| `description`                                                                                 | *string*                                                                                      | :heavy_minus_sign:                                                                            | Detailed description of the prompt                                                            |
| `activeVersion`                                                                               | *number*                                                                                      | :heavy_check_mark:                                                                            | Currently active version number                                                               |
| `latestVersion`                                                                               | *number*                                                                                      | :heavy_check_mark:                                                                            | Most recent version number                                                                    |
| `metadata`                                                                                    | Record<string, *any*>                                                                         | :heavy_check_mark:                                                                            | Custom metadata key-value pairs                                                               |
| `createdAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | Timestamp when the prompt was created                                                         |
| `updatedAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | Timestamp when the prompt was last updated                                                    |
| `activeTemplate`                                                                              | *string*                                                                                      | :heavy_check_mark:                                                                            | The template text for the requested version                                                   |
| `renderedTemplate`                                                                            | *string*                                                                                      | :heavy_minus_sign:                                                                            | The template with variables substituted — only present when variables are provided            |