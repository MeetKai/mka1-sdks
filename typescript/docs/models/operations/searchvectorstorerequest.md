# SearchVectorStoreRequest

## Example Usage

```typescript
import { SearchVectorStoreRequest } from "@meetkai/mka1/models/operations";

let value: SearchVectorStoreRequest = {
  vectorStoreId: "vs_abc123",
  searchVectorStoreRequest: {
    query: "How do I reset my password?",
    maxNumResults: 5,
  },
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                | Example                                                                                    |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `vectorStoreId`                                                                            | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        | vs_abc123                                                                                  |
| `xOnBehalfOf`                                                                              | *string*                                                                                   | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |                                                                                            |
| `searchVectorStoreRequest`                                                                 | [components.SearchVectorStoreRequest](../../models/components/searchvectorstorerequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        | {<br/>"query": "How do I reset my password?",<br/>"max_num_results": 5<br/>}               |