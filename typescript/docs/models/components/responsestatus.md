# ResponseStatus

The overall status of the response generation. 'completed' means successfully finished, 'failed' means error occurred, 'in_progress' means currently processing, 'cancelled' means user-cancelled, 'queued' means waiting to start, 'incomplete' means partial completion.

## Example Usage

```typescript
import { ResponseStatus } from "@meetkai/mka1/models/components";

let value: ResponseStatus = "incomplete";
```

## Values

```typescript
"completed" | "failed" | "in_progress" | "cancelled" | "queued" | "incomplete"
```