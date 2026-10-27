# CatalogHealthStatus

Provider health from the latest probe verdict: `available` or `unavailable`. `unknown` when there is no verdict: the definition has no health check, or its check has not run yet or its last verdict expired.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.CatalogHealthStatusAvailable

// Open enum: custom values can be created with a direct type cast
custom := components.CatalogHealthStatus("custom_value")
```


## Values

| Name                             | Value                            |
| -------------------------------- | -------------------------------- |
| `CatalogHealthStatusAvailable`   | available                        |
| `CatalogHealthStatusUnavailable` | unavailable                      |
| `CatalogHealthStatusUnknown`     | unknown                          |