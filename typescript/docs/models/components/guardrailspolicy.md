# GuardrailsPolicy

## Example Usage

```typescript
import { GuardrailsPolicy } from "@meetkai/mka1/models/components";

let value: GuardrailsPolicy = {
  teamId: "<id>",
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
  updatedAt: 3973,
};
```

## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `teamId`                                               | *string*                                               | :heavy_check_mark:                                     | Team this policy targets; null for the org-wide policy |
| `guardrails`                                           | *components.GuardrailConfig*[]                         | :heavy_check_mark:                                     | N/A                                                    |
| `updatedAt`                                            | *number*                                               | :heavy_check_mark:                                     | Unix timestamp of when the policy was last updated     |