# Bucket

Split results into time buckets. Hours, days, and Monday-start weeks begin on the clock of timezone, which defaults to UTC. Empty buckets are omitted.

## Example Usage

```python
from meetkai_mka1.models import Bucket
value: Bucket = "hour"
```


## Values

- `"hour"`
- `"day"`
- `"week"`
