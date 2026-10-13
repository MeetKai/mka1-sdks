# GetJwtFromKeyResponseBody

Invalid request body

## Example Usage

```typescript
import { GetJwtFromKeyResponseBody } from "@meetkai/mka1/models/errors";

// No examples available for this model
```

## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `message`                                                                    | *string*                                                                     | :heavy_check_mark:                                                           | Top-level validation error summary for the request body.                     |
| `details`                                                                    | [errors.GetJwtFromKeyDetails](../../models/errors/getjwtfromkeydetails.md)[] | :heavy_check_mark:                                                           | List of field-level validation errors.                                       |