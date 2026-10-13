# ItemReference

Item reference item: A pointer to another response item by ID.

## Example Usage

```typescript
import { ItemReference } from "@meetkai/mka1/models/components";

let value: ItemReference = {
  id: "<id>",
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `type`             | *"item_reference"* | :heavy_minus_sign: | N/A                |
| `id`               | *string*           | :heavy_check_mark: | N/A                |