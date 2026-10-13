# ListPromptsRequest

## Example Usage

```typescript
import { ListPromptsRequest } from "@meetkai/mka1/models/operations";

let value: ListPromptsRequest = {};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `limit`                                                                                        | *number*                                                                                       | :heavy_minus_sign:                                                                             | N/A                                                                                            |
| `after`                                                                                        | *string*                                                                                       | :heavy_minus_sign:                                                                             | N/A                                                                                            |
| `order`                                                                                        | [operations.ListPromptsQueryParamOrder](../../models/operations/listpromptsqueryparamorder.md) | :heavy_minus_sign:                                                                             | Sort order by creation date                                                                    |
| `xOnBehalfOf`                                                                                  | *string*                                                                                       | :heavy_minus_sign:                                                                             | Optional external end-user identifier forwarded by the API gateway.                            |