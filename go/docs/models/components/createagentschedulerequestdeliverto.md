# CreateAgentScheduleRequestDeliverTo

chat: each run replies in the caller's own Telegram chat with this agent, as that chat, in its conversation. The caller must be a chat user of one of this agent's active Telegram connectors (its X-On-Behalf-Of is the chat's external user id). The input must be a single text message, conversation, previous_response_id and context_management cannot be set, a repeat can be at most once an hour (interval_seconds of at least 3600, or a five-field cron with a single minute), and a chat holds at most 20 schedules (409 beyond that). The run sees the input framed as a follow-up the user set up earlier, not as the user speaking, and a whole reply of exactly NO_REPLY sends nothing.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.CreateAgentScheduleRequestDeliverToChat
```


## Values

| Name                                      | Value                                     |
| ----------------------------------------- | ----------------------------------------- |
| `CreateAgentScheduleRequestDeliverToChat` | chat                                      |