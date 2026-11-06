# PolicyToolType

The tool type the rule governs. web_search covers every web_search and web_search_preview variant. function, custom and local_shell tools run in the caller's application, and history and sleep are not held for review, so the policy can deny them but not require approval for them.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.PolicyToolTypeFunction
```


## Values

| Name                            | Value                           |
| ------------------------------- | ------------------------------- |
| `PolicyToolTypeFunction`        | function                        |
| `PolicyToolTypeCustom`          | custom                          |
| `PolicyToolTypeLocalShell`      | local_shell                     |
| `PolicyToolTypeFileSearch`      | file_search                     |
| `PolicyToolTypeWebSearch`       | web_search                      |
| `PolicyToolTypeCodeInterpreter` | code_interpreter                |
| `PolicyToolTypeShell`           | shell                           |
| `PolicyToolTypeImageGeneration` | image_generation                |
| `PolicyToolTypeMcp`             | mcp                             |
| `PolicyToolTypeOpenapi`         | openapi                         |
| `PolicyToolTypeAgent`           | agent                           |
| `PolicyToolTypeHistory`         | history                         |
| `PolicyToolTypeSleep`           | sleep                           |