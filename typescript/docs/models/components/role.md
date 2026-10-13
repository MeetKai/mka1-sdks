# Role

The role of the message author. Determines how the message is interpreted by the model.

## Example Usage

```typescript
import { Role } from "@meetkai/mka1/models/components";

let value: Role = "user";
```

## Values

```typescript
"system" | "user" | "assistant" | "tool" | "developer"
```