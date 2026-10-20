# MemoryStoreMountAccess

Whether the mounted memory store can be modified.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.MemoryStoreMountAccessReadOnly

// Open enum: custom values can be created with a direct type cast
custom := components.MemoryStoreMountAccess("custom_value")
```


## Values

| Name                              | Value                             |
| --------------------------------- | --------------------------------- |
| `MemoryStoreMountAccessReadOnly`  | read_only                         |
| `MemoryStoreMountAccessReadWrite` | read_write                        |