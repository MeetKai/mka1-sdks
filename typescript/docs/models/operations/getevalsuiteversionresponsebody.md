# GetEvalSuiteVersionResponseBody

OK

## Example Usage

```typescript
import { GetEvalSuiteVersionResponseBody } from "@meetkai/mka1/models/operations";

let value: GetEvalSuiteVersionResponseBody = {
  id: "<id>",
  object: "eval.suite.version",
  suiteId: "<id>",
  version: 563078,
  manifest: {
    tasks: [
      "<value 1>",
      "<value 2>",
    ],
  },
  datasetFileIds: [],
  metadata: {
    "key": "<value>",
  },
  createdAt: 447898,
};
```

## Fields

| Field                                                                                                                       | Type                                                                                                                        | Required                                                                                                                    | Description                                                                                                                 |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                        | *string*                                                                                                                    | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `object`                                                                                                                    | *"eval.suite.version"*                                                                                                      | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `suiteId`                                                                                                                   | *string*                                                                                                                    | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `version`                                                                                                                   | *number*                                                                                                                    | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `manifest`                                                                                                                  | [operations.GetEvalSuiteVersionManifest](../../models/operations/getevalsuiteversionmanifest.md)                            | :heavy_check_mark:                                                                                                          | Persisted eval manifest. Known fields remain validated; unknown stored fields are retained for read/rollback compatibility. |
| `datasetFileIds`                                                                                                            | *string*[]                                                                                                                  | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `metadata`                                                                                                                  | Record<string, *string*>                                                                                                    | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `createdAt`                                                                                                                 | *number*                                                                                                                    | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |