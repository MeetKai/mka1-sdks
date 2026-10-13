# SandboxResourceClass

Server-owned workload sizing classes.

Resource classes are deliberately independent of the language/runtime
profile.  In particular, Coding Harness always uses the Medium class even when a
caller sends a smaller or absent legacy ``memory_mib`` value.

## Example Usage

```typescript
import { SandboxResourceClass } from "@meetkai/mka1/models/components";

let value: SandboxResourceClass = "medium";
```

## Values

```typescript
"medium"
```