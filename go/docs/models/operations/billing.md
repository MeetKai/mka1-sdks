# Billing

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.BillingOk

// Open enum: custom values can be created with a direct type cast
custom := operations.Billing("custom_value")
```


## Values

| Name                  | Value                 |
| --------------------- | --------------------- |
| `BillingOk`           | ok                    |
| `BillingFailed`       | failed                |
| `BillingUnconfigured` | unconfigured          |