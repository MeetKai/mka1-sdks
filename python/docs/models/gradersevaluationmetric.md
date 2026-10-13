# GradersEvaluationMetric

## Example Usage

```python
from meetkai_mka1.models import GradersEvaluationMetric

# Open enum: unrecognized values are captured as UnrecognizedStr
value: GradersEvaluationMetric = "cosine"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"cosine"`
- `"fuzzy_match"`
- `"bleu"`
- `"gleu"`
- `"meteor"`
- `"rouge_1"`
- `"rouge_2"`
- `"rouge_3"`
- `"rouge_4"`
- `"rouge_5"`
- `"rouge_l"`
