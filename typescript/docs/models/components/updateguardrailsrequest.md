# UpdateGuardrailsRequest

## Example Usage

```typescript
import { UpdateGuardrailsRequest } from "@meetkai/mka1/models/components";

let value: UpdateGuardrailsRequest = {
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
};
```

## Fields

| Field                                                                                                                                                                    | Type                                                                                                                                                                     | Required                                                                                                                                                                 | Description                                                                                                                                                              |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `guardrails`                                                                                                                                                             | *components.GuardrailConfig*[]                                                                                                                                           | :heavy_check_mark:                                                                                                                                                       | List of guardrails to configure                                                                                                                                          |
| `teamId`                                                                                                                                                                 | *string*                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                       | Target team for this policy. Omit or pass null to set the org-wide policy that applies to every team (org admin only). Non-admin callers may only target their own team. |