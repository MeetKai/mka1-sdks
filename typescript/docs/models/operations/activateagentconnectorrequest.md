# ActivateAgentConnectorRequest

## Example Usage

```typescript
import { ActivateAgentConnectorRequest } from "@meetkai/mka1/models/operations";

let value: ActivateAgentConnectorRequest = {
  id: "<id>",
  connectorId: "<id>",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | The agent ID.                                                       |
| `connectorId`                                                       | *string*                                                            | :heavy_check_mark:                                                  | The connector ID.                                                   |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |