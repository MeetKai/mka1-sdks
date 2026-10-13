# ListSkillsRequest

## Example Usage

```typescript
import { ListSkillsRequest } from "@meetkai/mka1/models/operations";

let value: ListSkillsRequest = {};
```

## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  | Example                                                                                      |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `after`                                                                                      | *string*                                                                                     | :heavy_minus_sign:                                                                           | N/A                                                                                          |                                                                                              |
| `limit`                                                                                      | *number*                                                                                     | :heavy_minus_sign:                                                                           | N/A                                                                                          | 20                                                                                           |
| `order`                                                                                      | [operations.ListSkillsQueryParamOrder](../../models/operations/listskillsqueryparamorder.md) | :heavy_minus_sign:                                                                           | N/A                                                                                          | desc                                                                                         |
| `xOnBehalfOf`                                                                                | *string*                                                                                     | :heavy_minus_sign:                                                                           | Optional external end-user identifier forwarded by the API gateway.                          |                                                                                              |