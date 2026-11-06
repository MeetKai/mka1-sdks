# GroundednessClaimVerdict

supported: a source states it; uncertain: a source partly supports it or it is a reasonable inference; unsupported: the sources are silent on it; contradicted: a source gives a different value, date, name, amount or condition, or states the opposite

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.GroundednessClaimVerdictSupported

// Open enum: custom values can be created with a direct type cast
custom := components.GroundednessClaimVerdict("custom_value")
```


## Values

| Name                                   | Value                                  |
| -------------------------------------- | -------------------------------------- |
| `GroundednessClaimVerdictSupported`    | supported                              |
| `GroundednessClaimVerdictUncertain`    | uncertain                              |
| `GroundednessClaimVerdictUnsupported`  | unsupported                            |
| `GroundednessClaimVerdictContradicted` | contradicted                           |