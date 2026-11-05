# McpCredentialStatus

needs_reauthorization when the OAuth provider no longer honors the credential.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.McpCredentialStatusActive

// Open enum: custom values can be created with a direct type cast
custom := components.McpCredentialStatus("custom_value")
```


## Values

| Name                                      | Value                                     |
| ----------------------------------------- | ----------------------------------------- |
| `McpCredentialStatusActive`               | active                                    |
| `McpCredentialStatusNeedsReauthorization` | needs_reauthorization                     |