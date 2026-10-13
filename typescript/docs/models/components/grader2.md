# Grader2

## Example Usage

```typescript
import { Grader2 } from "@meetkai/mka1/models/components";

let value: Grader2 = {
  type: "multi",
  name: "<value>",
  graders: {
    "key": {
      type: "score_model",
      name: "<value>",
      model: "Model Y",
      input: [],
    },
  },
  calculateOutput: "<value>",
};
```

## Fields

| Field                                | Type                                 | Required                             | Description                          |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `type`                               | *"multi"*                            | :heavy_check_mark:                   | N/A                                  |
| `name`                               | *string*                             | :heavy_check_mark:                   | N/A                                  |
| `graders`                            | Record<string, *components.Graders*> | :heavy_check_mark:                   | N/A                                  |
| `calculateOutput`                    | *string*                             | :heavy_check_mark:                   | N/A                                  |