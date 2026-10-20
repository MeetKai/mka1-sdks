# GetOrganizationBillingStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.GetOrganizationBillingStatusDisabled

// Open enum: custom values can be created with a direct type cast
custom := operations.GetOrganizationBillingStatus("custom_value")
```


## Values

| Name                                        | Value                                       |
| ------------------------------------------- | ------------------------------------------- |
| `GetOrganizationBillingStatusDisabled`      | disabled                                    |
| `GetOrganizationBillingStatusSetupRequired` | setup_required                              |
| `GetOrganizationBillingStatusActive`        | active                                      |
| `GetOrganizationBillingStatusPastDue`       | past_due                                    |