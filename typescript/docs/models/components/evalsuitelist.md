# EvalSuiteList

## Example Usage

```typescript
import { EvalSuiteList } from "@meetkai/mka1/models/components";

let value: EvalSuiteList = {
  object: "list",
  data: [],
  hasMore: true,
};
```

## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `object`                                                                   | *"list"*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `data`                                                                     | [components.EvalSuiteObject](../../models/components/evalsuiteobject.md)[] | :heavy_check_mark:                                                         | N/A                                                                        |
| `firstId`                                                                  | *string*                                                                   | :heavy_minus_sign:                                                         | N/A                                                                        |
| `lastId`                                                                   | *string*                                                                   | :heavy_minus_sign:                                                         | N/A                                                                        |
| `hasMore`                                                                  | *boolean*                                                                  | :heavy_check_mark:                                                         | N/A                                                                        |