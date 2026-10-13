# Data

## Example Usage

```typescript
import { Data } from "@meetkai/mka1/models/components";

let value: Data = {
  embedding: "<value>",
  index: 6622.99,
};
```

## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `object`                                                                      | *"embedding"*                                                                 | :heavy_minus_sign:                                                            | N/A                                                                           |
| `embedding`                                                                   | *components.Embedding*                                                        | :heavy_check_mark:                                                            | The embedding vector, either as an array of floats or a base64-encoded string |
| `index`                                                                       | *number*                                                                      | :heavy_check_mark:                                                            | N/A                                                                           |