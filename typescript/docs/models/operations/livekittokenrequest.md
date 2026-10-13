# LivekitTokenRequest

## Example Usage

```typescript
import { LivekitTokenRequest } from "@meetkai/mka1/models/operations";

let value: LivekitTokenRequest = {
  livekitTokenRequest: {
    llm: {
      model: "El Camino",
    },
  },
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                    | *string*                                                                         | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |
| `livekitTokenRequest`                                                            | [components.LivekitTokenRequest](../../models/components/livekittokenrequest.md) | :heavy_check_mark:                                                               | N/A                                                                              |