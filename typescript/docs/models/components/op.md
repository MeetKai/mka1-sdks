# Op

Comparison operator. gt, gte, lt, and lte require a numeric value. exists and not_exists check whether the property is present and do not take a value.

## Example Usage

```typescript
import { Op } from "@meetkai/mka1/models/components";

let value: Op = "not_exists";
```

## Values

```typescript
"eq" | "neq" | "gt" | "gte" | "lt" | "lte" | "exists" | "not_exists"
```