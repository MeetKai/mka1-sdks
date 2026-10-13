# Ownership

Return only team-owned projects (team) or organization-level projects with a null team_id (organization). organization cannot be combined with team_id.

## Example Usage

```typescript
import { Ownership } from "@meetkai/mka1/models/operations";

let value: Ownership = "team";
```

## Values

```typescript
"team" | "organization"
```