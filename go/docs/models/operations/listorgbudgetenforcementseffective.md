# ListOrgBudgetEnforcementsEffective

What the spend gate does for this organization when the budget check is unavailable

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ListOrgBudgetEnforcementsEffectiveAllow

// Open enum: custom values can be created with a direct type cast
custom := operations.ListOrgBudgetEnforcementsEffective("custom_value")
```


## Values

| Name                                      | Value                                     |
| ----------------------------------------- | ----------------------------------------- |
| `ListOrgBudgetEnforcementsEffectiveAllow` | allow                                     |
| `ListOrgBudgetEnforcementsEffectiveBlock` | block                                     |