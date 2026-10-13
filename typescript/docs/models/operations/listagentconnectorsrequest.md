# ListAgentConnectorsRequest

## Example Usage

```typescript
import { ListAgentConnectorsRequest } from "@meetkai/mka1/models/operations";

let value: ListAgentConnectorsRequest = {
  id: "<id>",
};
```

## Fields

| Field                                                                                                          | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                           | *string*                                                                                                       | :heavy_check_mark:                                                                                             | The agent ID.                                                                                                  |
| `limit`                                                                                                        | *number*                                                                                                       | :heavy_minus_sign:                                                                                             | N/A                                                                                                            |
| `order`                                                                                                        | [operations.ListAgentConnectorsQueryParamOrder](../../models/operations/listagentconnectorsqueryparamorder.md) | :heavy_minus_sign:                                                                                             | N/A                                                                                                            |
| `xOnBehalfOf`                                                                                                  | *string*                                                                                                       | :heavy_minus_sign:                                                                                             | Optional external end-user identifier forwarded by the API gateway.                                            |