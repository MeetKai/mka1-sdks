# MeasureEvalSuiteTokensBody

## Example Usage

```typescript
import { MeasureEvalSuiteTokensBody } from "@meetkai/mka1/models/components";

let value: MeasureEvalSuiteTokensBody = {};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `limit`                                                                        | *number*                                                                       | :heavy_minus_sign:                                                             | How many runs to measure in this call. Call again until `remaining_runs` is 0. |