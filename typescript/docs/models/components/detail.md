# Detail

The detail level for image processing. 'high' for detailed analysis (higher cost), 'low' for basic analysis (lower cost), 'auto' lets the model choose based on image size, 'original' asks for the image at its native resolution (treated as 'high' by upstreams without that level). Defaults to 'auto'.

## Example Usage

```typescript
import { Detail } from "@meetkai/mka1/models/components";

let value: Detail = "low";
```

## Values

```typescript
"high" | "low" | "auto" | "original"
```