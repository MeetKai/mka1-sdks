# One5

## Example Usage

```typescript
import { One5 } from "@meetkai/mka1/models/components";

let value: One5 = {
  type: "label_model",
  name: "<value>",
  model: "Cruze",
  input: [
    {
      role: "<value>",
      content: "<value>",
    },
  ],
  labels: [],
  passingLabels: [
    "<value 1>",
    "<value 2>",
    "<value 3>",
  ],
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `type`                                                               | *"label_model"*                                                      | :heavy_check_mark:                                                   | N/A                                                                  |
| `name`                                                               | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `model`                                                              | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `input`                                                              | [components.Method1Input](../../models/components/method1input.md)[] | :heavy_check_mark:                                                   | N/A                                                                  |
| `labels`                                                             | *string*[]                                                           | :heavy_check_mark:                                                   | N/A                                                                  |
| `passingLabels`                                                      | *string*[]                                                           | :heavy_check_mark:                                                   | N/A                                                                  |