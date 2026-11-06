# ActionType

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ActionTypeTextFrontend

// Open enum: custom values can be created with a direct type cast
custom := components.ActionType("custom_value")
```


## Values

| Name                          | Value                         |
| ----------------------------- | ----------------------------- |
| `ActionTypeTextFrontend`      | text_frontend                 |
| `ActionTypeServingConfig`     | serving_config                |
| `ActionTypeDecoding`          | decoding                      |
| `ActionTypeTrainingData`      | training_data                 |
| `ActionTypeModelArchitecture` | model_architecture            |
| `ActionTypeJudgeOrMetric`     | judge_or_metric               |
| `ActionTypeBenchmarkFix`      | benchmark_fix                 |