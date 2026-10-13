# RepoError

The uniform error envelope. `error` is a stable machine-readable code
(never an internal reason); `correlation_id` echoes the request's
`X-Correlation-ID` for log correlation.


## Example Usage

```typescript
import { RepoError } from "@meetkai/mka1/models/errors";

// No examples available for this model
```

## Fields

| Field              | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `correlationId`    | *string*           | :heavy_check_mark: | N/A                |                    |
| `error`            | *string*           | :heavy_check_mark: | N/A                | not_found          |