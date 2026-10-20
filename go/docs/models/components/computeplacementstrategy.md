# ComputePlacementStrategy

How the candidate menu is ordered. providers is an unordered filter over which providers are eligible; strategy alone decides ordering. capacity_optimized, the default, groups by a curated provider precedence and sorts by price within each group. lowest_cost orders by price alone across whichever providers remain eligible.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ComputePlacementStrategyCapacityOptimized
```


## Values

| Name                                        | Value                                       |
| ------------------------------------------- | ------------------------------------------- |
| `ComputePlacementStrategyCapacityOptimized` | capacity_optimized                          |
| `ComputePlacementStrategyLowestCost`        | lowest_cost                                 |