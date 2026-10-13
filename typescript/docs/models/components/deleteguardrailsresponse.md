# DeleteGuardrailsResponse

## Example Usage

```typescript
import { DeleteGuardrailsResponse } from "@meetkai/mka1/models/components";

let value: DeleteGuardrailsResponse = {
  object: "guardrails_settings",
  deleted: true,
  teamId: "<id>",
};
```

## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `object`                                                       | *"guardrails_settings"*                                        | :heavy_check_mark:                                             | N/A                                                            |
| `deleted`                                                      | *boolean*                                                      | :heavy_check_mark:                                             | Whether a policy row was deleted                               |
| `teamId`                                                       | *string*                                                       | :heavy_check_mark:                                             | Team the deleted policy targeted; null for the org-wide policy |