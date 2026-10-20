# SandboxResourceClass

Server-owned workload sizing classes.

Resource classes are deliberately independent of the language/runtime
profile.  In particular, Coding Harness always uses the Medium class even when a
caller sends a smaller or absent legacy ``memory_mib`` value.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.SandboxResourceClassMedium

// Open enum: custom values can be created with a direct type cast
custom := components.SandboxResourceClass("custom_value")
```


## Values

| Name                         | Value                        |
| ---------------------------- | ---------------------------- |
| `SandboxResourceClassMedium` | medium                       |