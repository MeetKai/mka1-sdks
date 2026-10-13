# UpdateResponseFeedbackRequest

## Example Usage

```typescript
import { UpdateResponseFeedbackRequest } from "@meetkai/mka1/models/operations";

let value: UpdateResponseFeedbackRequest = {
  id: "resp-xyz789",
  requestBody: {},
};
```

## Fields

| Field                                                                                                        | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  | Example                                                                                                      |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `id`                                                                                                         | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          | resp-xyz789                                                                                                  |
| `xOnBehalfOf`                                                                                                | *string*                                                                                                     | :heavy_minus_sign:                                                                                           | Optional external end-user identifier forwarded by the API gateway.                                          |                                                                                                              |
| `requestBody`                                                                                                | [operations.UpdateResponseFeedbackRequestBody](../../models/operations/updateresponsefeedbackrequestbody.md) | :heavy_check_mark:                                                                                           | N/A                                                                                                          |                                                                                                              |