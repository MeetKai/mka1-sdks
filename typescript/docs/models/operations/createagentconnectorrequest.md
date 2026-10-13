# CreateAgentConnectorRequest

## Example Usage

```typescript
import { CreateAgentConnectorRequest } from "@meetkai/mka1/models/operations";

let value: CreateAgentConnectorRequest = {
  id: "<id>",
  createAgentConnectorRequest: {
    provider: "whatsapp",
    credentials: {
      accessToken: "<value>",
      appSecret: "<value>",
    },
    account: {
      appId: "<id>",
      whatsappBusinessAccountId: "<id>",
      phoneNumberId: "<id>",
    },
    access: {
      mode: "allowlist",
      userIds: [
        "<value 1>",
      ],
    },
  },
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | The agent ID.                                                       |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `createAgentConnectorRequest`                                       | *components.CreateAgentConnectorRequest*                            | :heavy_check_mark:                                                  | N/A                                                                 |