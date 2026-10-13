# Two2

## Example Usage

```typescript
import { Two2 } from "@meetkai/mka1/models/components";

let value: Two2 = {
  type: "image_url",
  imageUrl: {
    url: "https://frequent-passport.com",
  },
};
```

## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *"image_url"*                                              | :heavy_check_mark:                                         | Content type identifier for image URL content              |
| `imageUrl`                                                 | [components.ImageUrl](../../models/components/imageurl.md) | :heavy_check_mark:                                         | N/A                                                        |