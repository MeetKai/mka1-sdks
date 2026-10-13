# DeletePromptResponse

## Example Usage

```typescript
import { DeletePromptResponse } from "@meetkai/mka1/models/components";

let value: DeletePromptResponse = {
  id: "<id>",
  object: "prompt.deleted",
  deleted: true,
};
```

## Fields

| Field                 | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `id`                  | *string*              | :heavy_check_mark:    | The deleted prompt ID |
| `object`              | *"prompt.deleted"*    | :heavy_check_mark:    | Object type           |
| `deleted`             | *true*                | :heavy_check_mark:    | Deletion confirmation |