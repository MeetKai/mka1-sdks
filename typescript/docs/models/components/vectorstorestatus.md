# VectorStoreStatus

The status of the vector store. 'expired' means the store has expired, 'in_progress' means files are still being processed, 'completed' indicates that the vector store is ready for use.

## Example Usage

```typescript
import { VectorStoreStatus } from "@meetkai/mka1/models/components";

let value: VectorStoreStatus = "expired";
```

## Values

```typescript
"expired" | "in_progress" | "completed"
```