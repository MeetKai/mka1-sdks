# LivekitTokenRequestServiceTier

Specifies the processing tier for serving the request. 'auto' lets the system choose, 'default' uses standard processing, 'flex' allows flexible scheduling for lower priority, 'priority' provides faster processing. Defaults to 'auto'.

## Example Usage

```typescript
import { LivekitTokenRequestServiceTier } from "@meetkai/mka1/models/components";

let value: LivekitTokenRequestServiceTier = "auto";
```

## Values

```typescript
"auto" | "default" | "flex" | "priority"
```