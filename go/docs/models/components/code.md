# Code

One of server_error, unsupported_file, or invalid_file.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.CodeServerError

// Open enum: custom values can be created with a direct type cast
custom := components.Code("custom_value")
```


## Values

| Name                  | Value                 |
| --------------------- | --------------------- |
| `CodeServerError`     | server_error          |
| `CodeUnsupportedFile` | unsupported_file      |
| `CodeInvalidFile`     | invalid_file          |