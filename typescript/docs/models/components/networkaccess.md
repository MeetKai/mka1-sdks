# NetworkAccess

How much of the internet a Coding Harness guest reaches through the proxy.

Ordered: each level includes the one before it. The model broker and the
``mka1-github`` push/PR tool reach the runner directly, and the
Environment's repositories are cloned on the host before boot, so all of
them work at every level, including ``none``.

## Example Usage

```typescript
import { NetworkAccess } from "@meetkai/mka1/models/components";

let value: NetworkAccess = "package_managers";
```

## Values

```typescript
"none" | "package_managers" | "full"
```