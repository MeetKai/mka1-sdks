# CreateEvalSuiteVersionResponseBody

OK

## Example Usage

```typescript
import { CreateEvalSuiteVersionResponseBody } from "@meetkai/mka1/models/operations";

let value: CreateEvalSuiteVersionResponseBody = {
  id: "<id>",
  object: "eval.suite.version",
  suiteId: "<id>",
  version: 525454,
  manifest: {
    tasks: [
      "<value 1>",
      "<value 2>",
    ],
  },
  datasetFileIds: [
    "<value 1>",
    "<value 2>",
    "<value 3>",
  ],
  metadata: {
    "key": "<value>",
    "key1": "<value>",
  },
  createdAt: 857448,
};
```

## Fields

| Field                                                                                                                       | Type                                                                                                                        | Required                                                                                                                    | Description                                                                                                                 |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                        | *string*                                                                                                                    | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `object`                                                                                                                    | *"eval.suite.version"*                                                                                                      | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `suiteId`                                                                                                                   | *string*                                                                                                                    | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `version`                                                                                                                   | *number*                                                                                                                    | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `manifest`                                                                                                                  | [operations.Manifest](../../models/operations/manifest.md)                                                                  | :heavy_check_mark:                                                                                                          | Persisted eval manifest. Known fields remain validated; unknown stored fields are retained for read/rollback compatibility. |
| `datasetFileIds`                                                                                                            | *string*[]                                                                                                                  | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `metadata`                                                                                                                  | Record<string, *string*>                                                                                                    | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `createdAt`                                                                                                                 | *number*                                                                                                                    | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |