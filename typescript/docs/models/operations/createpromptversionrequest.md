# CreatePromptVersionRequest

## Example Usage

```typescript
import { CreatePromptVersionRequest } from "@meetkai/mka1/models/operations";

let value: CreatePromptVersionRequest = {
  id: "prompt_aa87e2b1112a455b8deabed784372198",
  requestBody: {
    template: "<value>",
  },
};
```

## Fields

| Field                                                                                                  | Type                                                                                                   | Required                                                                                               | Description                                                                                            | Example                                                                                                |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `id`                                                                                                   | *string*                                                                                               | :heavy_check_mark:                                                                                     | N/A                                                                                                    | prompt_aa87e2b1112a455b8deabed784372198                                                                |
| `xOnBehalfOf`                                                                                          | *string*                                                                                               | :heavy_minus_sign:                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                    |                                                                                                        |
| `requestBody`                                                                                          | [operations.CreatePromptVersionRequestBody](../../models/operations/createpromptversionrequestbody.md) | :heavy_check_mark:                                                                                     | N/A                                                                                                    |                                                                                                        |