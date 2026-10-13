# CreateBatchRequest

## Example Usage

```typescript
import { CreateBatchRequest } from "@meetkai/mka1/models/operations";

let value: CreateBatchRequest = {
  createBatchRequest: {
    inputFileId: "<id>",
    endpoint: "/v1/images/generations",
    completionWindow: "24h",
  },
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `xOnBehalfOf`                                                                  | *string*                                                                       | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |
| `createBatchRequest`                                                           | [components.CreateBatchRequest](../../models/components/createbatchrequest.md) | :heavy_check_mark:                                                             | N/A                                                                            |