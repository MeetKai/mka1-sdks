# ListEvalSuiteVersionsData

## Example Usage

```typescript
import { ListEvalSuiteVersionsData } from "@meetkai/mka1/models/operations";

let value: ListEvalSuiteVersionsData = {
  id: "<id>",
  object: "eval.suite.version",
  suiteId: "<id>",
  version: 887581,
  manifest: {
    tasks: [
      "<value 1>",
    ],
  },
  datasetFileIds: [
    "<value 1>",
    "<value 2>",
  ],
  metadata: {
    "key": "<value>",
    "key1": "<value>",
  },
  createdAt: 701840,
};
```

## Fields

| Field                                                                                                                       | Type                                                                                                                        | Required                                                                                                                    | Description                                                                                                                 |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                        | *string*                                                                                                                    | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `object`                                                                                                                    | *"eval.suite.version"*                                                                                                      | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `suiteId`                                                                                                                   | *string*                                                                                                                    | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `version`                                                                                                                   | *number*                                                                                                                    | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `manifest`                                                                                                                  | [operations.ListEvalSuiteVersionsManifest](../../models/operations/listevalsuiteversionsmanifest.md)                        | :heavy_check_mark:                                                                                                          | Persisted eval manifest. Known fields remain validated; unknown stored fields are retained for read/rollback compatibility. |
| `datasetFileIds`                                                                                                            | *string*[]                                                                                                                  | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `metadata`                                                                                                                  | Record<string, *string*>                                                                                                    | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |
| `createdAt`                                                                                                                 | *number*                                                                                                                    | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |