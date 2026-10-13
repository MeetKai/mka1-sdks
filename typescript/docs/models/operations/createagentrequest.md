# CreateAgentRequest

## Example Usage

```typescript
import { CreateAgentRequest } from "@meetkai/mka1/models/operations";

let value: CreateAgentRequest = {
  createAgentRequest: {
    name: "<value>",
    model: "functionary-pt",
  },
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `xOnBehalfOf`                                                                  | *string*                                                                       | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |
| `createAgentRequest`                                                           | [components.CreateAgentRequest](../../models/components/createagentrequest.md) | :heavy_check_mark:                                                             | N/A                                                                            |