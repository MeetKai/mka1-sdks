# ImageGenerationRequestResponseFormat

The format in which the generated images are returned. 'url' returns a URL to the image, 'b64_json' returns the image as a base64-encoded JSON string. Defaults to 'url'.

## Example Usage

```typescript
import { ImageGenerationRequestResponseFormat } from "@meetkai/mka1/models/components";

let value: ImageGenerationRequestResponseFormat = "b64_json";
```

## Values

```typescript
"url" | "b64_json"
```