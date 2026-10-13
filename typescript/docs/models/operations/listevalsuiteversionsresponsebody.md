# ListEvalSuiteVersionsResponseBody

OK

## Example Usage

```typescript
import { ListEvalSuiteVersionsResponseBody } from "@meetkai/mka1/models/operations";

let value: ListEvalSuiteVersionsResponseBody = {
  object: "list",
  data: [
    {
      id: "<id>",
      object: "eval.suite.version",
      suiteId: "<id>",
      version: 626110,
      manifest: {
        tasks: [
          "<value 1>",
        ],
      },
      datasetFileIds: [
        "<value 1>",
      ],
      metadata: {
        "key": "<value>",
      },
      createdAt: 390909,
    },
  ],
  hasMore: true,
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `object`                                                                                       | *"list"*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `data`                                                                                         | [operations.ListEvalSuiteVersionsData](../../models/operations/listevalsuiteversionsdata.md)[] | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `firstId`                                                                                      | *string*                                                                                       | :heavy_minus_sign:                                                                             | N/A                                                                                            |
| `lastId`                                                                                       | *string*                                                                                       | :heavy_minus_sign:                                                                             | N/A                                                                                            |
| `hasMore`                                                                                      | *boolean*                                                                                      | :heavy_check_mark:                                                                             | N/A                                                                                            |