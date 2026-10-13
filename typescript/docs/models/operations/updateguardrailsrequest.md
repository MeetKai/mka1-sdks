# UpdateGuardrailsRequest

## Example Usage

```typescript
import { UpdateGuardrailsRequest } from "@meetkai/mka1/models/operations";

let value: UpdateGuardrailsRequest = {
  updateGuardrailsRequest: {
    guardrails: [
      {
        mode: "classifier",
        enabled: true,
        config: {
          model: "Colorado",
          prompt: "<value>",
          onError: "fail_closed",
          rejectionMessage:
            "This request is not allowed by your organization's content policy.",
        },
      },
    ],
  },
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                            | *string*                                                                                 | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |
| `updateGuardrailsRequest`                                                                | [components.UpdateGuardrailsRequest](../../models/components/updateguardrailsrequest.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |