# GetJwtFromKeyDetails

## Example Usage

```typescript
import { GetJwtFromKeyDetails } from "@meetkai/mka1/models/errors";

let value: GetJwtFromKeyDetails = {
  path: "/opt/lib",
  message: "<value>",
};
```

## Fields

| Field                                              | Type                                               | Required                                           | Description                                        |
| -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- |
| `path`                                             | *string*                                           | :heavy_check_mark:                                 | Dot-path of the invalid field in the request body. |
| `message`                                          | *string*                                           | :heavy_check_mark:                                 | Validation error message for the field.            |