# CreateEvalRunRequest

## Example Usage

```typescript
import { CreateEvalRunRequest } from "@meetkai/mka1/models/operations";

let value: CreateEvalRunRequest = {
  createEvalRunRequest: {
    suiteId: "<id>",
    models: [
      "<value 1>",
      "<value 2>",
    ],
  },
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                      | *string*                                                                           | :heavy_minus_sign:                                                                 | Optional external end-user identifier forwarded by the API gateway.                |
| `createEvalRunRequest`                                                             | [components.CreateEvalRunRequest](../../models/components/createevalrunrequest.md) | :heavy_check_mark:                                                                 | N/A                                                                                |