# CreateResponseRequest

## Example Usage

```typescript
import { CreateResponseRequest } from "@meetkai/mka1/models/operations";

let value: CreateResponseRequest = {
  responsesCreateRequest: {
    model: "meetkai:functionary-urdu-mini-pak",
    input: "What is the capital of France?",
  },
};
```

## Fields

| Field                                                                                                        | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  | Example                                                                                                      |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `xOnBehalfOf`                                                                                                | *string*                                                                                                     | :heavy_minus_sign:                                                                                           | Optional external end-user identifier forwarded by the API gateway.                                          |                                                                                                              |
| `responsesCreateRequest`                                                                                     | [components.ResponsesCreateRequest](../../models/components/responsescreaterequest.md)                       | :heavy_check_mark:                                                                                           | N/A                                                                                                          | {<br/>"model": "meetkai:functionary-urdu-mini-pak",<br/>"input": "What is the capital of France?",<br/>"stream": false<br/>} |