# CreateGeneration

## Example Usage

```typescript
import { CreateGeneration } from "@meetkai/mka1/models/components";

let value: CreateGeneration = {
  generatorId: "<id>",
  params: {},
  output: {
    repo: "<value>",
  },
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `generatorId`                                                        | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `params`                                                             | Record<string, *any*>                                                | :heavy_check_mark:                                                   | N/A                                                                  |
| `output`                                                             | [components.OutputSpec](../../models/components/outputspec.md)       | :heavy_check_mark:                                                   | N/A                                                                  |
| `inputs`                                                             | Record<string, *string*>                                             | :heavy_minus_sign:                                                   | N/A                                                                  |
| `limits`                                                             | [components.LimitsRequest](../../models/components/limitsrequest.md) | :heavy_minus_sign:                                                   | N/A                                                                  |
| `name`                                                               | *string*                                                             | :heavy_minus_sign:                                                   | N/A                                                                  |
| `derivedFrom`                                                        | *string*[]                                                           | :heavy_minus_sign:                                                   | N/A                                                                  |