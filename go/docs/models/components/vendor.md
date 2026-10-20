# Vendor

Present on every gpu-class entry, absent on cpu-class entries.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.VendorNvidia

// Open enum: custom values can be created with a direct type cast
custom := components.Vendor("custom_value")
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `VendorNvidia` | nvidia         |
| `VendorAmd`    | amd            |