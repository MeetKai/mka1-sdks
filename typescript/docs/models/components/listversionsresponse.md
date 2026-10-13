# ListVersionsResponse

## Example Usage

```typescript
import { ListVersionsResponse } from "@meetkai/mka1/models/components";

let value: ListVersionsResponse = {
  object: "list",
  data: [],
};
```

## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `object`                                                                               | *"list"*                                                                               | :heavy_check_mark:                                                                     | Object type                                                                            |
| `data`                                                                                 | [components.CreateVersionResponse](../../models/components/createversionresponse.md)[] | :heavy_check_mark:                                                                     | Array of version objects                                                               |