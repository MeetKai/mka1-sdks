# GradersEvaluationMetric

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.GradersEvaluationMetricCosine

// Open enum: custom values can be created with a direct type cast
custom := components.GradersEvaluationMetric("custom_value")
```


## Values

| Name                                | Value                               |
| ----------------------------------- | ----------------------------------- |
| `GradersEvaluationMetricCosine`     | cosine                              |
| `GradersEvaluationMetricFuzzyMatch` | fuzzy_match                         |
| `GradersEvaluationMetricBleu`       | bleu                                |
| `GradersEvaluationMetricGleu`       | gleu                                |
| `GradersEvaluationMetricMeteor`     | meteor                              |
| `GradersEvaluationMetricRouge1`     | rouge_1                             |
| `GradersEvaluationMetricRouge2`     | rouge_2                             |
| `GradersEvaluationMetricRouge3`     | rouge_3                             |
| `GradersEvaluationMetricRouge4`     | rouge_4                             |
| `GradersEvaluationMetricRouge5`     | rouge_5                             |
| `GradersEvaluationMetricRougeL`     | rouge_l                             |