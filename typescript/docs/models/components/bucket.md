# Bucket

Split results into time buckets. Hours, days, and Monday-start weeks begin on the clock of timezone, which defaults to UTC. Empty buckets are omitted.

## Example Usage

```typescript
import { Bucket } from "@meetkai/mka1/models/components";

let value: Bucket = "week";
```

## Values

```typescript
"hour" | "day" | "week"
```