# CreateEvalSuiteRequest

## Example Usage

```typescript
import { CreateEvalSuiteRequest } from "@meetkai/mka1/models/operations";

let value: CreateEvalSuiteRequest = {
  createEvalSuiteRequest: {
    name: "<value>",
    manifest: {
      tasks: [],
    },
  },
};
```

## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `createEvalSuiteRequest`                                                               | [components.CreateEvalSuiteRequest](../../models/components/createevalsuiterequest.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |