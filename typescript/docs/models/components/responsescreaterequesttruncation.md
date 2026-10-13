# ResponsesCreateRequestTruncation

The truncation strategy for handling inputs that exceed the model's context window. 'auto' automatically truncates old messages to fit, 'disabled' returns an error if context is too long. Defaults to 'auto'.

## Example Usage

```typescript
import { ResponsesCreateRequestTruncation } from "@meetkai/mka1/models/components";

let value: ResponsesCreateRequestTruncation = "disabled";
```

## Values

```typescript
"auto" | "disabled"
```