# LanguageSource

Where `language` comes from: `detected` is the provider's own answer; `requested` means the provider named no language (plain json answers) and the value echoes the caller's `language` hint.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.LanguageSourceDetected

// Open enum: custom values can be created with a direct type cast
custom := components.LanguageSource("custom_value")
```


## Values

| Name                      | Value                     |
| ------------------------- | ------------------------- |
| `LanguageSourceDetected`  | detected                  |
| `LanguageSourceRequested` | requested                 |