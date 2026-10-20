# ResponsesCreateRequestServiceTier

Specifies the processing tier for serving the request. 'auto' lets the system choose, 'default' uses standard processing, 'flex' allows flexible scheduling for lower priority, 'priority' provides faster processing. Defaults to 'auto'.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ResponsesCreateRequestServiceTierAuto
```


## Values

| Name                                        | Value                                       |
| ------------------------------------------- | ------------------------------------------- |
| `ResponsesCreateRequestServiceTierAuto`     | auto                                        |
| `ResponsesCreateRequestServiceTierDefault`  | default                                     |
| `ResponsesCreateRequestServiceTierFlex`     | flex                                        |
| `ResponsesCreateRequestServiceTierPriority` | priority                                    |