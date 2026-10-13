# CustomToolChoice

Custom tool choice: Forces a specific custom tool by name.

## Example Usage

```typescript
import { CustomToolChoice } from "@meetkai/mka1/models/components";

let value: CustomToolChoice = {
  type: "custom",
  name: "<value>",
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `type`             | *"custom"*         | :heavy_check_mark: | N/A                |
| `name`             | *string*           | :heavy_check_mark: | N/A                |