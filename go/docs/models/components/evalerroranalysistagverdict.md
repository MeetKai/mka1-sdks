# EvalErrorAnalysisTagVerdict

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.EvalErrorAnalysisTagVerdictModelError

// Open enum: custom values can be created with a direct type cast
custom := components.EvalErrorAnalysisTagVerdict("custom_value")
```


## Values

| Name                                        | Value                                       |
| ------------------------------------------- | ------------------------------------------- |
| `EvalErrorAnalysisTagVerdictModelError`     | model_error                                 |
| `EvalErrorAnalysisTagVerdictJudgeError`     | judge_error                                 |
| `EvalErrorAnalysisTagVerdictReferenceIssue` | reference_issue                             |
| `EvalErrorAnalysisTagVerdictMixed`          | mixed                                       |
| `EvalErrorAnalysisTagVerdictUntagged`       | untagged                                    |