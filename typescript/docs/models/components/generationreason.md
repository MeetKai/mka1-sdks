# GenerationReason

api.md §3 `reason`.

## Example Usage

```typescript
import { GenerationReason } from "@meetkai/mka1/models/components";

let value: GenerationReason = {
  code: "<value>",
  message: "<value>",
};
```

## Fields

| Field                 | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `code`                | *string*              | :heavy_check_mark:    | N/A                   |
| `message`             | *string*              | :heavy_check_mark:    | N/A                   |
| `details`             | Record<string, *any*> | :heavy_minus_sign:    | N/A                   |