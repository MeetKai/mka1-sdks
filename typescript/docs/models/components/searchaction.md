# SearchAction

## Example Usage

```typescript
import { SearchAction } from "@meetkai/mka1/models/components";

let value: SearchAction = {
  type: "search",
  query: "<value>",
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `type`                                                                           | *"search"*                                                                       | :heavy_check_mark:                                                               | N/A                                                                              |
| `query`                                                                          | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `sources`                                                                        | [components.SearchActionSource](../../models/components/searchactionsource.md)[] | :heavy_minus_sign:                                                               | N/A                                                                              |