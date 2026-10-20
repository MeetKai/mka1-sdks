# EvalScheduleOverlapPolicy

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.EvalScheduleOverlapPolicySkip

// Open enum: custom values can be created with a direct type cast
custom := components.EvalScheduleOverlapPolicy("custom_value")
```


## Values

| Name                                 | Value                                |
| ------------------------------------ | ------------------------------------ |
| `EvalScheduleOverlapPolicySkip`      | skip                                 |
| `EvalScheduleOverlapPolicyBufferOne` | buffer_one                           |
| `EvalScheduleOverlapPolicyAllowAll`  | allow_all                            |