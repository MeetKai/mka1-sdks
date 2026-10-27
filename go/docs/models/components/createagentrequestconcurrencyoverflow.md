# CreateAgentRequestConcurrencyOverflow

What a run beyond max_concurrent_runs gets. reject (the default) refuses it with 429 and error code agent_concurrency_limit. queue stores it as waiting and starts it, oldest first, when a run finishes, with the agent configuration current at that time.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.CreateAgentRequestConcurrencyOverflowReject
```


## Values

| Name                                          | Value                                         |
| --------------------------------------------- | --------------------------------------------- |
| `CreateAgentRequestConcurrencyOverflowReject` | reject                                        |
| `CreateAgentRequestConcurrencyOverflowQueue`  | queue                                         |