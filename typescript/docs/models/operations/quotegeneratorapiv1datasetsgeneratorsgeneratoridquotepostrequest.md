# QuoteGeneratorApiV1DatasetsGeneratorsGeneratorIdQuotePostRequest

## Example Usage

```typescript
import { QuoteGeneratorApiV1DatasetsGeneratorsGeneratorIdQuotePostRequest } from "@meetkai/mka1/models/operations";

let value: QuoteGeneratorApiV1DatasetsGeneratorsGeneratorIdQuotePostRequest = {
  generatorId: "<id>",
  quoteRequest: {
    params: {
      "key": "<value>",
      "key1": "<value>",
      "key2": "<value>",
    },
  },
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `generatorId`                                                       | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `quoteRequest`                                                      | [components.QuoteRequest](../../models/components/quoterequest.md)  | :heavy_check_mark:                                                  | N/A                                                                 |