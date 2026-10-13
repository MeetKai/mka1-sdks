# CreateSessionRequest

## Example Usage

```typescript
import { CreateSessionRequest } from "@meetkai/mka1/models/operations";

let value: CreateSessionRequest = {
  createSessionRequest: {
    sessionId: "<id>",
  },
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                      | *string*                                                                           | :heavy_minus_sign:                                                                 | Optional external end-user identifier forwarded by the API gateway.                |
| `createSessionRequest`                                                             | [components.CreateSessionRequest](../../models/components/createsessionrequest.md) | :heavy_check_mark:                                                                 | N/A                                                                                |