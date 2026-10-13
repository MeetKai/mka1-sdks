# ComputeError

## Example Usage

```typescript
import { ComputeError } from "@meetkai/mka1/models/components";

let value: ComputeError = {
  code: "<value>",
  message: "<value>",
  requestId: "<id>",
};
```

## Fields

| Field                 | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `code`                | *string*              | :heavy_check_mark:    | N/A                   |
| `details`             | Record<string, *any*> | :heavy_minus_sign:    | N/A                   |
| `message`             | *string*              | :heavy_check_mark:    | N/A                   |
| `requestId`           | *string*              | :heavy_check_mark:    | N/A                   |