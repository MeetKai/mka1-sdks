# Bucket

Split results into time buckets. Hours, days, and Monday-start weeks begin on the clock of timezone, which defaults to UTC. Empty buckets are omitted.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.BucketHour
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `BucketHour` | hour         |
| `BucketDay`  | day          |
| `BucketWeek` | week         |