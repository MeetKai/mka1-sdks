# VectorStoreFileBatchStatus

The status of the vector store files batch. 'in_progress' means files are being processed, 'completed' means all files have been processed, 'cancelled' means the batch was cancelled, 'failed' means the batch failed.

## Example Usage

```typescript
import { VectorStoreFileBatchStatus } from "@meetkai/mka1/models/components";

let value: VectorStoreFileBatchStatus = "failed";
```

## Values

```typescript
"in_progress" | "completed" | "cancelled" | "failed"
```