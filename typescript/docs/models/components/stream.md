# Stream

The stream the line was written to. Native services report one combined stream as stdout: Kubernetes merges a container's two streams.

## Example Usage

```typescript
import { Stream } from "@meetkai/mka1/models/components";

let value: Stream = "stderr";
```

## Values

```typescript
"stdout" | "stderr"
```