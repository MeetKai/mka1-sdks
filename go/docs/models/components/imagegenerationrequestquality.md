# ImageGenerationRequestQuality

The quality tier of the generated image. Higher tiers may incur higher latency or cost. 'auto' lets the gateway pick a sensible value per model. 'standard' and 'hd' are accepted as legacy aliases.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ImageGenerationRequestQualityLow
```


## Values

| Name                                    | Value                                   |
| --------------------------------------- | --------------------------------------- |
| `ImageGenerationRequestQualityLow`      | low                                     |
| `ImageGenerationRequestQualityMedium`   | medium                                  |
| `ImageGenerationRequestQualityHigh`     | high                                    |
| `ImageGenerationRequestQualityAuto`     | auto                                    |
| `ImageGenerationRequestQualityStandard` | standard                                |
| `ImageGenerationRequestQualityHd`       | hd                                      |