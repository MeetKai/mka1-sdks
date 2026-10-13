# Version

The initial version created with this prompt

## Example Usage

```typescript
import { Version } from "@meetkai/mka1/models/components";

let value: Version = {
  id: "<id>",
  promptId: "<id>",
  version: 478606,
  object: "prompt.version",
  template: "<value>",
  createdAt: new Date("2025-07-20T03:47:30.062Z"),
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `id`                                                                                          | *string*                                                                                      | :heavy_check_mark:                                                                            | Unique version identifier                                                                     |
| `promptId`                                                                                    | *string*                                                                                      | :heavy_check_mark:                                                                            | Parent prompt identifier                                                                      |
| `version`                                                                                     | *number*                                                                                      | :heavy_check_mark:                                                                            | Version number                                                                                |
| `object`                                                                                      | *"prompt.version"*                                                                            | :heavy_check_mark:                                                                            | Object type                                                                                   |
| `template`                                                                                    | *string*                                                                                      | :heavy_check_mark:                                                                            | The prompt template text with {{variable}} placeholders                                       |
| `createdAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | Timestamp when this version was created                                                       |