# SetOrganizationBillingEnabledStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.SetOrganizationBillingEnabledStatusDisabled

// Open enum: custom values can be created with a direct type cast
custom := operations.SetOrganizationBillingEnabledStatus("custom_value")
```


## Values

| Name                                               | Value                                              |
| -------------------------------------------------- | -------------------------------------------------- |
| `SetOrganizationBillingEnabledStatusDisabled`      | disabled                                           |
| `SetOrganizationBillingEnabledStatusSetupRequired` | setup_required                                     |
| `SetOrganizationBillingEnabledStatusActive`        | active                                             |
| `SetOrganizationBillingEnabledStatusPastDue`       | past_due                                           |