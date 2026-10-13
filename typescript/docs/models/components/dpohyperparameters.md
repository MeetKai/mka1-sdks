# DpoHyperparameters

## Example Usage

```typescript
import { DpoHyperparameters } from "@meetkai/mka1/models/components";

let value: DpoHyperparameters = {};
```

## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `batchSize`                                           | *components.DpoHyperparametersBatchSize*              | :heavy_minus_sign:                                    | Number of examples in each batch                      |
| `beta`                                                | *components.Beta*                                     | :heavy_minus_sign:                                    | DPO beta parameter controlling alignment strictness   |
| `learningRateMultiplier`                              | *components.DpoHyperparametersLearningRateMultiplier* | :heavy_minus_sign:                                    | Scaling factor for learning rate                      |
| `nEpochs`                                             | *components.DpoHyperparametersNEpochs*                | :heavy_minus_sign:                                    | Number of epochs to train for                         |