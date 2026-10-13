# DeleteResponseObject

Response object returned after successfully deleting a response.

## Example Usage

```typescript
import { DeleteResponseObject } from "@meetkai/mka1/models/components";

let value: DeleteResponseObject = {
  id: "<id>",
  object: "response",
  deleted: false,
};
```

## Fields

| Field                                                                                                           | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | The unique identifier of the deleted response.                                                                  |
| `object`                                                                                                        | *"response"*                                                                                                    | :heavy_check_mark:                                                                                              | The object type, always 'response' for response deletions.                                                      |
| `deleted`                                                                                                       | *boolean*                                                                                                       | :heavy_check_mark:                                                                                              | Confirmation flag indicating whether the response was successfully deleted. Always true on successful deletion. |