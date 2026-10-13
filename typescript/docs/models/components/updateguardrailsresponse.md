# UpdateGuardrailsResponse

## Example Usage

```typescript
import { UpdateGuardrailsResponse } from "@meetkai/mka1/models/components";

let value: UpdateGuardrailsResponse = {
  object: "guardrails_settings",
  guardrails: [],
  teamId: null,
  updatedAt: 8677.85,
};
```

## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `object`                                               | *"guardrails_settings"*                                | :heavy_check_mark:                                     | N/A                                                    |
| `guardrails`                                           | *components.GuardrailConfig*[]                         | :heavy_check_mark:                                     | N/A                                                    |
| `teamId`                                               | *string*                                               | :heavy_check_mark:                                     | Team this policy targets; null for the org-wide policy |
| `updatedAt`                                            | *number*                                               | :heavy_check_mark:                                     | Unix timestamp of when the policy was updated          |