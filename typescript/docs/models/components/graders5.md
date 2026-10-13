# Graders5

## Example Usage

```typescript
import { Graders5 } from "@meetkai/mka1/models/components";

let value: Graders5 = {
  type: "label_model",
  name: "<value>",
  model: "Roadster",
  input: [],
  labels: [],
  passingLabels: [
    "<value 1>",
    "<value 2>",
    "<value 3>",
  ],
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `type`                                                                           | *"label_model"*                                                                  | :heavy_check_mark:                                                               | N/A                                                                              |
| `name`                                                                           | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `model`                                                                          | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `input`                                                                          | [components.MethodGradersInput](../../models/components/methodgradersinput.md)[] | :heavy_check_mark:                                                               | N/A                                                                              |
| `labels`                                                                         | *string*[]                                                                       | :heavy_check_mark:                                                               | N/A                                                                              |
| `passingLabels`                                                                  | *string*[]                                                                       | :heavy_check_mark:                                                               | N/A                                                                              |