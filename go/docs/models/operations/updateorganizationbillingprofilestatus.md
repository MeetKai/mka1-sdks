# UpdateOrganizationBillingProfileStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.UpdateOrganizationBillingProfileStatusDisabled

// Open enum: custom values can be created with a direct type cast
custom := operations.UpdateOrganizationBillingProfileStatus("custom_value")
```


## Values

| Name                                                  | Value                                                 |
| ----------------------------------------------------- | ----------------------------------------------------- |
| `UpdateOrganizationBillingProfileStatusDisabled`      | disabled                                              |
| `UpdateOrganizationBillingProfileStatusSetupRequired` | setup_required                                        |
| `UpdateOrganizationBillingProfileStatusActive`        | active                                                |
| `UpdateOrganizationBillingProfileStatusPastDue`       | past_due                                              |