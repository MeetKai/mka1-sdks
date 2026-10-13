# CreateImageRequest

## Example Usage

```typescript
import { CreateImageRequest } from "@meetkai/mka1/models/operations";

let value: CreateImageRequest = {
  imageGenerationRequest: {
    prompt: "A serene mountain landscape at sunset with a lake reflection",
    quality: "high",
  },
};
```

## Fields

| Field                                                                                                                                 | Type                                                                                                                                  | Required                                                                                                                              | Description                                                                                                                           | Example                                                                                                                               |
| ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                                                         | *string*                                                                                                                              | :heavy_minus_sign:                                                                                                                    | Optional external end-user identifier forwarded by the API gateway.                                                                   |                                                                                                                                       |
| `imageGenerationRequest`                                                                                                              | [components.ImageGenerationRequest](../../models/components/imagegenerationrequest.md)                                                | :heavy_check_mark:                                                                                                                    | N/A                                                                                                                                   | {<br/>"model": "auto",<br/>"prompt": "A serene mountain landscape at sunset with a lake reflection",<br/>"size": "1024x1024",<br/>"quality": "high"<br/>} |