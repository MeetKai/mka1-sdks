# CreatePromptRequest

## Example Usage

```typescript
import { CreatePromptRequest } from "@meetkai/mka1/models/operations";

let value: CreatePromptRequest = {
  createPromptRequest: {
    name: "<value>",
    template: "<value>",
  },
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                    | *string*                                                                         | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |
| `createPromptRequest`                                                            | [components.CreatePromptRequest](../../models/components/createpromptrequest.md) | :heavy_check_mark:                                                               | N/A                                                                              |