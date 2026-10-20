# NetworkAccess

How much of the internet a Coding Harness guest reaches through the proxy.

Ordered: each level includes the one before it. The model broker and the
``mka1-github`` push/PR tool reach the runner directly, and the
Environment's repositories are cloned on the host before boot, so all of
them work at every level, including ``none``.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.NetworkAccessNone

// Open enum: custom values can be created with a direct type cast
custom := components.NetworkAccess("custom_value")
```


## Values

| Name                           | Value                          |
| ------------------------------ | ------------------------------ |
| `NetworkAccessNone`            | none                           |
| `NetworkAccessPackageManagers` | package_managers               |
| `NetworkAccessFull`            | full                           |