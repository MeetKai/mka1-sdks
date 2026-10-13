# ConnectGitHubAccountRequest

## Example Usage

```typescript
import { ConnectGitHubAccountRequest } from "@meetkai/mka1/models/operations";

let value: ConnectGitHubAccountRequest = {
  connectRequest: {
    code: "<value>",
    state: "Georgia",
  },
};
```

## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `xOnBehalfOf`                                                          | *string*                                                               | :heavy_minus_sign:                                                     | Optional external end-user identifier forwarded by the API gateway.    |
| `connectRequest`                                                       | [components.ConnectRequest](../../models/components/connectrequest.md) | :heavy_check_mark:                                                     | N/A                                                                    |