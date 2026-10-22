# Code

One of server_error, unsupported_file, invalid_file, or duplicate_file (the file was skipped because the store already holds its content; the message names that file).

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
| `CodeDuplicateFile`   | duplicate_file        |