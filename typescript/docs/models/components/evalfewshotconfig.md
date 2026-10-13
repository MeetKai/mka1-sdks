# EvalFewshotConfig

## Example Usage

```typescript
import { EvalFewshotConfig } from "@meetkai/mka1/models/components";

let value: EvalFewshotConfig = {};
```

## Fields

| Field                                                                             | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `count`                                                                           | *number*                                                                          | :heavy_minus_sign:                                                                | N/A                                                                               |
| `dataset`                                                                         | [components.EvalDataset](../../models/components/evaldataset.md)                  | :heavy_minus_sign:                                                                | Dataset backing an eval task.                                                     |
| `promptTemplate`                                                                  | *string*                                                                          | :heavy_minus_sign:                                                                | Optional prompt template for few-shot examples. Defaults to task prompt_template. |
| `targetTemplate`                                                                  | *string*                                                                          | :heavy_minus_sign:                                                                | Optional target template for few-shot examples. Defaults to task target_template. |
| `exampleTemplate`                                                                 | *string*                                                                          | :heavy_minus_sign:                                                                | Template for one rendered few-shot example.                                       |
| `separator`                                                                       | *string*                                                                          | :heavy_minus_sign:                                                                | Separator between few-shot examples and the evaluated prompt.                     |
| `strategy`                                                                        | [components.Strategy](../../models/components/strategy.md)                        | :heavy_minus_sign:                                                                | N/A                                                                               |
| `seed`                                                                            | *number*                                                                          | :heavy_minus_sign:                                                                | N/A                                                                               |