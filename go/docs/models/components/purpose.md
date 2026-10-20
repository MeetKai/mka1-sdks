# Purpose

The intended purpose of the file

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.PurposeAssistants

// Open enum: custom values can be created with a direct type cast
custom := components.Purpose("custom_value")
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `PurposeAssistants` | assistants          |
| `PurposeBatch`      | batch               |
| `PurposeFineTune`   | fine-tune           |
| `PurposeVision`     | vision              |
| `PurposeUserData`   | user_data           |
| `PurposeEvals`      | evals               |