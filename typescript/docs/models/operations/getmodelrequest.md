# GetModelRequest

## Example Usage

```typescript
import { GetModelRequest } from "@meetkai/mka1/models/operations";

let value: GetModelRequest = {
  modelId: "meetkai:functionary-urdu-mini-pak",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `modelId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | meetkai:functionary-urdu-mini-pak                                   |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |