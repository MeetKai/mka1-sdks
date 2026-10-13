# ImageUrl

## Example Usage

```typescript
import { ImageUrl } from "@meetkai/mka1/models/components";

let value: ImageUrl = {
  url: "https://sinful-meal.biz",
};
```

## Fields

| Field                                                                                                                  | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `url`                                                                                                                  | *string*                                                                                                               | :heavy_check_mark:                                                                                                     | The URL of the image, or a base64-encoded image data URL                                                               |
| `detail`                                                                                                               | [components.TwoDetail](../../models/components/twodetail.md)                                                           | :heavy_minus_sign:                                                                                                     | The detail level of the image analysis. 'low' disables high-res mode, 'high' enables it, 'auto' lets the model decide. |