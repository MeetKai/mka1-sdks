# McpCredentialList

## Example Usage

```typescript
import { McpCredentialList } from "@meetkai/mka1/models/components";

let value: McpCredentialList = {
  object: "list",
  data: [],
  firstId: null,
  hasMore: false,
  lastId: "<id>",
};
```

## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `object`                                                               | *"list"*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `data`                                                                 | [components.McpCredential](../../models/components/mcpcredential.md)[] | :heavy_check_mark:                                                     | N/A                                                                    |
| `firstId`                                                              | *string*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `hasMore`                                                              | *boolean*                                                              | :heavy_check_mark:                                                     | N/A                                                                    |
| `lastId`                                                               | *string*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |