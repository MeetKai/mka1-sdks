# EvalSuiteObject

## Example Usage

```typescript
import { EvalSuiteObject } from "@meetkai/mka1/models/components";

let value: EvalSuiteObject = {
  id: "<id>",
  object: "eval.suite",
  name: "<value>",
  description: "unto yum sense now quantify inveigle well-off",
  orgId: "<id>",
  teamId: "<id>",
  activeVersion: 780061,
  latestVersion: 134640,
  metadata: {},
  createdAt: 324092,
  updatedAt: 126078,
};
```

## Fields

| Field                          | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `id`                           | *string*                       | :heavy_check_mark:             | N/A                            |
| `object`                       | *"eval.suite"*                 | :heavy_check_mark:             | N/A                            |
| `name`                         | *string*                       | :heavy_check_mark:             | N/A                            |
| `description`                  | *string*                       | :heavy_check_mark:             | N/A                            |
| `orgId`                        | *string*                       | :heavy_check_mark:             | The org that owns this suite.  |
| `teamId`                       | *string*                       | :heavy_check_mark:             | The team that owns this suite. |
| `activeVersion`                | *number*                       | :heavy_check_mark:             | N/A                            |
| `latestVersion`                | *number*                       | :heavy_check_mark:             | N/A                            |
| `metadata`                     | Record<string, *string*>       | :heavy_check_mark:             | N/A                            |
| `createdAt`                    | *number*                       | :heavy_check_mark:             | N/A                            |
| `updatedAt`                    | *number*                       | :heavy_check_mark:             | N/A                            |