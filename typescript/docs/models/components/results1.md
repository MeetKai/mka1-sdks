# Results1

Error result when the completion/response ID doesn't exist

## Example Usage

```typescript
import { Results1 } from "@meetkai/mka1/models/components";

let value: Results1 = {
  id: "<id>",
  error: "not_found",
};
```

## Fields

| Field                                       | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `id`                                        | *string*                                    | :heavy_check_mark:                          | The request ID that was queried             |
| `error`                                     | *"not_found"*                               | :heavy_check_mark:                          | Error indicating the resource doesn't exist |