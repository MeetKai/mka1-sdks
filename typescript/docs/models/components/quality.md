# Quality

The quality tier of the generated image. Higher tiers may incur higher latency or cost. 'auto' lets the gateway pick a sensible value per model. 'standard' and 'hd' are accepted as legacy aliases.

## Example Usage

```typescript
import { Quality } from "@meetkai/mka1/models/components";

let value: Quality = "hd";
```

## Values

```typescript
"low" | "medium" | "high" | "auto" | "standard" | "hd"
```