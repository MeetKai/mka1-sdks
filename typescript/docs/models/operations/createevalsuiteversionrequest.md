# CreateEvalSuiteVersionRequest

## Example Usage

```typescript
import { CreateEvalSuiteVersionRequest } from "@meetkai/mka1/models/operations";

let value: CreateEvalSuiteVersionRequest = {
  suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
  createEvalSuiteVersionRequest: {
    manifest: {
      tasks: [],
    },
  },
};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          | Example                                                                                              |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `suiteId`                                                                                            | *string*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  | eval_suite_aa87e2b1112a455b8deabed784372198                                                          |
| `xOnBehalfOf`                                                                                        | *string*                                                                                             | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |                                                                                                      |
| `createEvalSuiteVersionRequest`                                                                      | [components.CreateEvalSuiteVersionRequest](../../models/components/createevalsuiteversionrequest.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |                                                                                                      |