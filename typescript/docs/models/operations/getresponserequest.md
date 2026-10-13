# GetResponseRequest

## Example Usage

```typescript
import { GetResponseRequest } from "@meetkai/mka1/models/operations";

let value: GetResponseRequest = {
  responseId: "resp_get123",
  include: [
    "file_search_call.results",
    "message.output_text.logprobs",
  ],
  includeObfuscation: false,
  startingAfter: 42,
  stream: false,
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `responseId`                                                        | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | resp_get123                                                         |
| `include`                                                           | [operations.Include](../../models/operations/include.md)[]          | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"file_search_call.results",<br/>"message.output_text.logprobs"<br/>] |
| `includeObfuscation`                                                | *boolean*                                                           | :heavy_minus_sign:                                                  | N/A                                                                 | false                                                               |
| `startingAfter`                                                     | *number*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | 42                                                                  |
| `stream`                                                            | *boolean*                                                           | :heavy_minus_sign:                                                  | N/A                                                                 | false                                                               |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |