# InputImageDetail

The detail level for image processing. 'high' for detailed analysis (higher cost), 'low' for basic analysis (lower cost), 'auto' lets the model choose based on image size, 'original' asks for the image at its native resolution (treated as 'high' by upstreams without that level). Defaults to 'auto'.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.InputImageDetailHigh

// Open enum: custom values can be created with a direct type cast
custom := components.InputImageDetail("custom_value")
```


## Values

| Name                       | Value                      |
| -------------------------- | -------------------------- |
| `InputImageDetailHigh`     | high                       |
| `InputImageDetailLow`      | low                        |
| `InputImageDetailAuto`     | auto                       |
| `InputImageDetailOriginal` | original                   |