# InviteClusterOrgMembersStatus

## Example Usage

```python
from meetkai_mka1.models import InviteClusterOrgMembersStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: InviteClusterOrgMembersStatus = "sent"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"sent"`
- `"email_failed"`
- `"already_invited"`
- `"already_member"`
- `"error"`
