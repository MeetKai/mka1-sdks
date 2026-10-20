# Severity

Whether an issue stops a consumer (`ERROR`) or is for a human to look at (`WARNING`).

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.SeverityError

// Open enum: custom values can be created with a direct type cast
custom := components.Severity("custom_value")
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `SeverityError`   | error             |
| `SeverityWarning` | warning           |