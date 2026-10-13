# SchemaDeleteResponse

Response from deleting an extraction schema.

## Example Usage

```typescript
import { SchemaDeleteResponse } from "@meetkai/mka1/models/components";

let value: SchemaDeleteResponse = {
  success: false,
  message: "<value>",
};
```

## Fields

| Field                                                | Type                                                 | Required                                             | Description                                          |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `success`                                            | *boolean*                                            | :heavy_check_mark:                                   | Indicates whether the schema deletion was successful |
| `message`                                            | *string*                                             | :heavy_check_mark:                                   | A confirmation message about the deletion            |