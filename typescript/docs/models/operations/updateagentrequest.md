# UpdateAgentRequest

## Example Usage

```typescript
import { UpdateAgentRequest } from "@meetkai/mka1/models/operations";

let value: UpdateAgentRequest = {
  agentId: "<id>",
  updateAgentRequest: {
    model: "functionary-pt",
  },
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `agentId`                                                                      | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `xOnBehalfOf`                                                                  | *string*                                                                       | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |
| `updateAgentRequest`                                                           | [components.UpdateAgentRequest](../../models/components/updateagentrequest.md) | :heavy_check_mark:                                                             | N/A                                                                            |