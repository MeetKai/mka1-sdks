# FileStatus

DEPRECATED: File processing status

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.FileStatusUploaded

// Open enum: custom values can be created with a direct type cast
custom := components.FileStatus("custom_value")
```


## Values

| Name                  | Value                 |
| --------------------- | --------------------- |
| `FileStatusUploaded`  | uploaded              |
| `FileStatusProcessed` | processed             |
| `FileStatusError`     | error                 |