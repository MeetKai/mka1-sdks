# Status

The processing status of an individual item. 'in_progress' means currently processing, 'completed' means finished successfully, 'incomplete' means processing stopped before completion.

## Example Usage

```typescript
import { Status } from "@meetkai/mka1/models/components";

let value: Status = "completed";
```

## Values

```typescript
"in_progress" | "completed" | "incomplete"
```