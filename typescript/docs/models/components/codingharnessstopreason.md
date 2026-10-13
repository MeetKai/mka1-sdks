# CodingHarnessStopReason

Why a Coding Harness allocation entered ``stopped``.

Recorded on the session row at the stop transition and cleared by resume,
so a client that finds a stopped session can say whether the owner
suspended it, the idle or absolute clock ran out, or the runner released
it. Every value is resumable; termination is a different status.

## Example Usage

```typescript
import { CodingHarnessStopReason } from "@meetkai/mka1/models/components";

let value: CodingHarnessStopReason = "idle_expired";
```

## Values

```typescript
"user_suspend" | "idle_expired" | "absolute_expired" | "runner_drain" | "runner_recovery"
```