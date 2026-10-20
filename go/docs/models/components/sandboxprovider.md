# SandboxProvider

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.SandboxProviderInMemory

// Open enum: custom values can be created with a direct type cast
custom := components.SandboxProvider("custom_value")
```


## Values

| Name                               | Value                              |
| ---------------------------------- | ---------------------------------- |
| `SandboxProviderInMemory`          | in-memory                          |
| `SandboxProviderRunnerProcess`     | runner-process                     |
| `SandboxProviderRunnerDocker`      | runner-docker                      |
| `SandboxProviderRunnerFirecracker` | runner-firecracker                 |