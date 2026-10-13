# ErrorEvent

## Example Usage

```typescript
import { ErrorEvent } from "@meetkai/mka1/models/components";

let value: ErrorEvent = {
  type: "error",
  sequenceNumber: 857643,
  code: "<value>",
  message: "<value>",
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `type`             | *"error"*          | :heavy_check_mark: | N/A                |
| `sequenceNumber`   | *number*           | :heavy_check_mark: | N/A                |
| `code`             | *string*           | :heavy_check_mark: | N/A                |
| `message`          | *string*           | :heavy_check_mark: | N/A                |
| `param`            | *string*           | :heavy_minus_sign: | N/A                |