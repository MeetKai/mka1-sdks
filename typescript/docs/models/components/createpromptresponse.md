# CreatePromptResponse

## Example Usage

```typescript
import { CreatePromptResponse } from "@meetkai/mka1/models/components";

let value: CreatePromptResponse = {
  id: "<id>",
  object: "prompt",
  name: "<value>",
  activeVersion: 970886,
  latestVersion: 36999,
  metadata: {
    "key": "<value>",
  },
  createdAt: new Date("2026-09-06T02:25:47.039Z"),
  updatedAt: new Date("2026-08-08T00:47:14.420Z"),
  version: {
    id: "<id>",
    promptId: "<id>",
    version: 86970,
    object: "prompt.version",
    template: "<value>",
    createdAt: new Date("2024-08-19T21:26:27.913Z"),
  },
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
| `version`                                                                                     | [components.Version](../../models/components/version.md)                                      | :heavy_check_mark:                                                                            | The initial version created with this prompt                                                  |