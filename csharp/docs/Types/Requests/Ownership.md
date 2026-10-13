# Ownership

Return only team-owned projects (team) or organization-level projects with a null team_id (organization). organization cannot be combined with team_id.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Requests;

var value = Ownership.Team;
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Team`         | team           |
| `Organization` | organization   |