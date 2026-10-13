# AddAccessMutationRequest

## Example Usage

```typescript
import { AddAccessMutationRequest } from "@meetkai/mka1/models/components";

let value: AddAccessMutationRequest = {
  modelIds: [
    "<value 1>",
    "<value 2>",
  ],
};
```

## Fields

| Field                                                                                           | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `modelIds`                                                                                      | *string*[]                                                                                      | :heavy_check_mark:                                                                              | N/A                                                                                             |
| `activate`                                                                                      | *boolean*                                                                                       | :heavy_minus_sign:                                                                              | Explicitly activate the requested cluster models in the target organization. Defaults to false. |