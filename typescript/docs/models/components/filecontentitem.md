# FileContentItem

A content item from a vector store file.

## Example Usage

```typescript
import { FileContentItem } from "@meetkai/mka1/models/components";

let value: FileContentItem = {
  type: "text",
  text: "<value>",
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `type`             | *"text"*           | :heavy_check_mark: | The content type.  |
| `text`             | *string*           | :heavy_check_mark: | The text content.  |