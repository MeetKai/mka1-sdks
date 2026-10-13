# GetPromptRequest

## Example Usage

```typescript
import { GetPromptRequest } from "@meetkai/mka1/models/operations";

let value: GetPromptRequest = {
  id: "prompt_aa87e2b1112a455b8deabed784372198",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | prompt_aa87e2b1112a455b8deabed784372198                             |
| `version`                                                           | *number*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `variables`                                                         | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |