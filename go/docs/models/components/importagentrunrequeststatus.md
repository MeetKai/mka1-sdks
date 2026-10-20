# ImportAgentRunRequestStatus

`failed` means no score was produced at all. An agent timeout is NOT that — the harness still runs the verifier and scores the trial, so it stays `completed` and carries its exception in `error`.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ImportAgentRunRequestStatusCompleted
```


## Values

| Name                                   | Value                                  |
| -------------------------------------- | -------------------------------------- |
| `ImportAgentRunRequestStatusCompleted` | completed                              |
| `ImportAgentRunRequestStatusFailed`    | failed                                 |