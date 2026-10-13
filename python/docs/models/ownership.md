# Ownership

Return only team-owned projects (team) or organization-level projects with a null team_id (organization). organization cannot be combined with team_id.

## Example Usage

```python
from meetkai_mka1.models import Ownership
value: Ownership = "team"
```


## Values

- `"team"`
- `"organization"`
