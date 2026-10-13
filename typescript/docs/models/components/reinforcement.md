# Reinforcement

## Example Usage

```typescript
import { Reinforcement } from "@meetkai/mka1/models/components";

let value: Reinforcement = {
  grader: {
    type: "multi",
    name: "<value>",
    graders: {},
    calculateOutput: "<value>",
  },
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `grader`                                                                                           | *components.Grader*                                                                                | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `hyperparameters`                                                                                  | [components.ReinforcementHyperparameters](../../models/components/reinforcementhyperparameters.md) | :heavy_minus_sign:                                                                                 | N/A                                                                                                |