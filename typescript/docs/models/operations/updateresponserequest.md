# UpdateResponseRequest

## Example Usage

```typescript
import { UpdateResponseRequest } from "@meetkai/mka1/models/operations";

let value: UpdateResponseRequest = {
  responseId: "resp_abc123",
  updateResponseRequest: {
    metadata: {
      "status": "reviewed",
      "reviewer": "john_doe",
    },
  },
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          | Example                                                                              |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `responseId`                                                                         | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  | resp_abc123                                                                          |
| `xOnBehalfOf`                                                                        | *string*                                                                             | :heavy_minus_sign:                                                                   | Optional external end-user identifier forwarded by the API gateway.                  |                                                                                      |
| `updateResponseRequest`                                                              | [components.UpdateResponseRequest](../../models/components/updateresponserequest.md) | :heavy_check_mark:                                                                   | N/A                                                                                  | {<br/>"metadata": {<br/>"status": "reviewed",<br/>"reviewer": "john_doe"<br/>}<br/>} |