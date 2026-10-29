# SetOrgBudgetEnforcementEffective

What the spend gate does for this organization when the budget check is unavailable

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.SetOrgBudgetEnforcementEffectiveAllow

// Open enum: custom values can be created with a direct type cast
custom := operations.SetOrgBudgetEnforcementEffective("custom_value")
```


## Values

| Name                                    | Value                                   |
| --------------------------------------- | --------------------------------------- |
| `SetOrgBudgetEnforcementEffectiveAllow` | allow                                   |
| `SetOrgBudgetEnforcementEffectiveBlock` | block                                   |