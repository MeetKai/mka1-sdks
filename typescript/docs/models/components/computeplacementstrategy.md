# ComputePlacementStrategy

How the candidate menu is ordered. providers is an unordered filter over which providers are eligible; strategy alone decides ordering. capacity_optimized, the default, groups by a curated provider precedence and sorts by price within each group. lowest_cost orders by price alone across whichever providers remain eligible.

## Example Usage

```typescript
import { ComputePlacementStrategy } from "@meetkai/mka1/models/components";

let value: ComputePlacementStrategy = "lowest_cost";
```

## Values

```typescript
"capacity_optimized" | "lowest_cost"
```