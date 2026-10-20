# Health

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.HealthHealthy

// Open enum: custom values can be created with a direct type cast
custom := components.Health("custom_value")
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `HealthHealthy`  | healthy          |
| `HealthWarming`  | warming          |
| `HealthDegraded` | degraded         |