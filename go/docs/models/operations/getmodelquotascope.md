# GetModelQuotaScope

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.GetModelQuotaScopeGlobal

// Open enum: custom values can be created with a direct type cast
custom := operations.GetModelQuotaScope("custom_value")
```


## Values

| Name                             | Value                            |
| -------------------------------- | -------------------------------- |
| `GetModelQuotaScopeGlobal`       | global                           |
| `GetModelQuotaScopeOrg`          | org                              |
| `GetModelQuotaScopeUser`         | user                             |
| `GetModelQuotaScopeAPIKey`       | apiKey                           |
| `GetModelQuotaScopeExternalUser` | externalUser                     |