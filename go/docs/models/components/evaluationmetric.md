# EvaluationMetric

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.EvaluationMetricCosine

// Open enum: custom values can be created with a direct type cast
custom := components.EvaluationMetric("custom_value")
```


## Values

| Name                         | Value                        |
| ---------------------------- | ---------------------------- |
| `EvaluationMetricCosine`     | cosine                       |
| `EvaluationMetricFuzzyMatch` | fuzzy_match                  |
| `EvaluationMetricBleu`       | bleu                         |
| `EvaluationMetricGleu`       | gleu                         |
| `EvaluationMetricMeteor`     | meteor                       |
| `EvaluationMetricRouge1`     | rouge_1                      |
| `EvaluationMetricRouge2`     | rouge_2                      |
| `EvaluationMetricRouge3`     | rouge_3                      |
| `EvaluationMetricRouge4`     | rouge_4                      |
| `EvaluationMetricRouge5`     | rouge_5                      |
| `EvaluationMetricRougeL`     | rouge_l                      |