# GetPromptVersionRequest

## Example Usage

```typescript
import { GetPromptVersionRequest } from "@meetkai/mka1/models/operations";

let value: GetPromptVersionRequest = {
  id: "prompt_aa87e2b1112a455b8deabed784372198",
  version: 1,
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | prompt_aa87e2b1112a455b8deabed784372198                             |
| `version`                                                           | *number*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | 1                                                                   |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |