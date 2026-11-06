# StatusComponentID

A service on the status page.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.StatusComponentIDAPIGateway

// Open enum: custom values can be created with a direct type cast
custom := components.StatusComponentID("custom_value")
```


## Values

| Name                              | Value                             |
| --------------------------------- | --------------------------------- |
| `StatusComponentIDAPIGateway`     | api-gateway                       |
| `StatusComponentIDAuthentication` | authentication                    |
| `StatusComponentIDLlm`            | llm                               |
| `StatusComponentIDAuthorization`  | authorization                     |
| `StatusComponentIDAgents`         | agents                            |
| `StatusComponentIDSandbox`        | sandbox                           |
| `StatusComponentIDCompute`        | compute                           |