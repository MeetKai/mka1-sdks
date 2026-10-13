# Graders1

## Example Usage

```typescript
import { Graders1 } from "@meetkai/mka1/models/components";

let value: Graders1 = {
  type: "string_check",
  name: "<value>",
  input: "<value>",
  reference: "<value>",
  operation: "eq",
};
```

## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `type`                                                                     | *"string_check"*                                                           | :heavy_check_mark:                                                         | N/A                                                                        |
| `name`                                                                     | *string*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `input`                                                                    | *string*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `reference`                                                                | *string*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `operation`                                                                | [components.GradersOperation](../../models/components/gradersoperation.md) | :heavy_check_mark:                                                         | N/A                                                                        |