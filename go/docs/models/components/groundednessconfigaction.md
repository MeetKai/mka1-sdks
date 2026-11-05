# GroundednessConfigAction

What a score below the threshold does: flag returns the answer with its verdict in `groundedness`; block replaces it with the rejection message

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.GroundednessConfigActionFlag

// Open enum: custom values can be created with a direct type cast
custom := components.GroundednessConfigAction("custom_value")
```


## Values

| Name                            | Value                           |
| ------------------------------- | ------------------------------- |
| `GroundednessConfigActionFlag`  | flag                            |
| `GroundednessConfigActionBlock` | block                           |