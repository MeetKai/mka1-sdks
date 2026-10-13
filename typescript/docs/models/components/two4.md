# Two4

## Example Usage

```typescript
import { Two4 } from "@meetkai/mka1/models/components";

let value: Two4 = {
  type: "file",
  file: {
    filename: "example.file",
    fileData: "<value>",
  },
};
```

## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `type`                                                                 | *"file"*                                                               | :heavy_check_mark:                                                     | Content type identifier for file content                               |
| `file`                                                                 | *components.TwoFile*                                                   | :heavy_check_mark:                                                     | The file to include in the message, either as raw data or by reference |