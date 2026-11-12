# Which

Which part of your approval inbox to list: pending (undecided and not expired, oldest first) or decided (decided or expired, most recently closed first). Defaults to pending. Cannot be combined with response_id.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.WhichPending
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `WhichPending` | pending        |
| `WhichDecided` | decided        |