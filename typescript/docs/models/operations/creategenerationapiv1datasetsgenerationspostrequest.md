# CreateGenerationApiV1DatasetsGenerationsPostRequest

## Example Usage

```typescript
import { CreateGenerationApiV1DatasetsGenerationsPostRequest } from "@meetkai/mka1/models/operations";

let value: CreateGenerationApiV1DatasetsGenerationsPostRequest = {
  idempotencyKey: "<value>",
  createGeneration: {
    generatorId: "<id>",
    params: {},
    output: {
      repo: "<value>",
    },
  },
};
```

## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `idempotencyKey`                                                           | *string*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `xOnBehalfOf`                                                              | *string*                                                                   | :heavy_minus_sign:                                                         | Optional external end-user identifier forwarded by the API gateway.        |
| `createGeneration`                                                         | [components.CreateGeneration](../../models/components/creategeneration.md) | :heavy_check_mark:                                                         | N/A                                                                        |