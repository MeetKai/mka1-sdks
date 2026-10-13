# SupervisedHyperparameters

## Example Usage

```typescript
import { SupervisedHyperparameters } from "@meetkai/mka1/models/components";

let value: SupervisedHyperparameters = {};
```

## Fields

| Field                               | Type                                | Required                            | Description                         |
| ----------------------------------- | ----------------------------------- | ----------------------------------- | ----------------------------------- |
| `batchSize`                         | *components.BatchSize*              | :heavy_minus_sign:                  | Number of examples in each batch    |
| `learningRateMultiplier`            | *components.LearningRateMultiplier* | :heavy_minus_sign:                  | Scaling factor for learning rate    |
| `nEpochs`                           | *components.NEpochs*                | :heavy_minus_sign:                  | Number of epochs to train for       |