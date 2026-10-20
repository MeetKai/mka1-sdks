# LivekitTokenRequestTruncation

The truncation strategy for handling inputs that exceed the model's context window. 'auto' automatically truncates old messages to fit, 'disabled' returns an error if context is too long. Defaults to 'auto'.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.LivekitTokenRequestTruncationAuto
```


## Values

| Name                                    | Value                                   |
| --------------------------------------- | --------------------------------------- |
| `LivekitTokenRequestTruncationAuto`     | auto                                    |
| `LivekitTokenRequestTruncationDisabled` | disabled                                |