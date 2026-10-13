# ComputePlacementStrategy

How the candidate menu is ordered. providers is an unordered filter over which providers are eligible; strategy alone decides ordering. capacity_optimized, the default, groups by a curated provider precedence and sorts by price within each group. lowest_cost orders by price alone across whichever providers remain eligible.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = ComputePlacementStrategy.CapacityOptimized;
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `CapacityOptimized` | capacity_optimized  |
| `LowestCost`        | lowest_cost         |