# VectorStoreFileStatus

The status of the vector store file. 'in_progress' means currently processing, 'completed' indicates the file is ready for use, 'cancelled' means processing was cancelled, 'failed' means an error occurred.

## Example Usage

```typescript
import { VectorStoreFileStatus } from "@meetkai/mka1/models/components";

let value: VectorStoreFileStatus = "failed";
```

## Values

```typescript
"in_progress" | "completed" | "cancelled" | "failed"
```