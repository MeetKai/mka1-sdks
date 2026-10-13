# AppendAgentTrialsRequestStatus

`failed` means no score was produced at all. An agent timeout is NOT that — the harness still runs the verifier and scores the trial, so it stays `completed` and carries its exception in `error`.

## Example Usage

```typescript
import { AppendAgentTrialsRequestStatus } from "@meetkai/mka1/models/components";

let value: AppendAgentTrialsRequestStatus = "failed";
```

## Values

```typescript
"completed" | "failed"
```