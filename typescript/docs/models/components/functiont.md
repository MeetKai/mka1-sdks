# FunctionT

The function definition

## Example Usage

```typescript
import { FunctionT } from "@meetkai/mka1/models/components";

let value: FunctionT = {
  name: "<value>",
};
```

## Fields

| Field                                                                                                                         | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `name`                                                                                                                        | *string*                                                                                                                      | :heavy_check_mark:                                                                                                            | The name of the function to be called. Must be a-z, A-Z, 0-9, underscores and dashes, with a maximum length of 64 characters. |
| `description`                                                                                                                 | *string*                                                                                                                      | :heavy_minus_sign:                                                                                                            | A description of what the function does. Used by the model to choose when and how to call the function.                       |
| `parameters`                                                                                                                  | *any*                                                                                                                         | :heavy_minus_sign:                                                                                                            | The parameters the function accepts, described as a JSON Schema object. Omit to accept no parameters.                         |