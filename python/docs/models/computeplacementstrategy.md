# ComputePlacementStrategy

How the candidate menu is ordered. providers is an unordered filter over which providers are eligible; strategy alone decides ordering. capacity_optimized, the default, groups by a curated provider precedence and sorts by price within each group. lowest_cost orders by price alone across whichever providers remain eligible.

## Example Usage

```python
from meetkai_mka1.models import ComputePlacementStrategy
value: ComputePlacementStrategy = "capacity_optimized"
```


## Values

- `"capacity_optimized"`
- `"lowest_cost"`
