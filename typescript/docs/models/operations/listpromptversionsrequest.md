# ListPromptVersionsRequest

## Example Usage

```typescript
import { ListPromptVersionsRequest } from "@meetkai/mka1/models/operations";

let value: ListPromptVersionsRequest = {
  id: "prompt_aa87e2b1112a455b8deabed784372198",
};
```

## Fields

| Field                                                                                                        | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  | Example                                                                                                      |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `id`                                                                                                         | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          | prompt_aa87e2b1112a455b8deabed784372198                                                                      |
| `limit`                                                                                                      | *number*                                                                                                     | :heavy_minus_sign:                                                                                           | N/A                                                                                                          |                                                                                                              |
| `order`                                                                                                      | [operations.ListPromptVersionsQueryParamOrder](../../models/operations/listpromptversionsqueryparamorder.md) | :heavy_minus_sign:                                                                                           | Sort order by version number                                                                                 |                                                                                                              |
| `xOnBehalfOf`                                                                                                | *string*                                                                                                     | :heavy_minus_sign:                                                                                           | Optional external end-user identifier forwarded by the API gateway.                                          |                                                                                                              |