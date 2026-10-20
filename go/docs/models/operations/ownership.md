# Ownership

Return only team-owned projects (team) or organization-level projects with a null team_id (organization). organization cannot be combined with team_id.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.OwnershipTeam
```


## Values

| Name                    | Value                   |
| ----------------------- | ----------------------- |
| `OwnershipTeam`         | team                    |
| `OwnershipOrganization` | organization            |