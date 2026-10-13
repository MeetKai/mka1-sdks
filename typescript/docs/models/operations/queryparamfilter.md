# QueryParamFilter

Filter by file status. One of in_progress, completed, failed, cancelled.

## Example Usage

```typescript
import { QueryParamFilter } from "@meetkai/mka1/models/operations";

let value: QueryParamFilter = "completed";
```

## Values

```typescript
"in_progress" | "completed" | "failed" | "cancelled"
```