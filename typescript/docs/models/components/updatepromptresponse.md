# UpdatePromptResponse

## Example Usage

```typescript
import { UpdatePromptResponse } from "@meetkai/mka1/models/components";

let value: UpdatePromptResponse = {
  id: "<id>",
  object: "prompt",
  name: "<value>",
  activeVersion: 677536,
  latestVersion: 35698,
  metadata: {},
  createdAt: new Date("2024-09-12T03:08:43.083Z"),
  updatedAt: new Date("2024-06-08T18:03:46.006Z"),
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