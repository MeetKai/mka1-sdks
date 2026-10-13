# EvalHistoricalImportObject

## Example Usage

```typescript
import { EvalHistoricalImportObject } from "@meetkai/mka1/models/components";

let value: EvalHistoricalImportObject = {
  object: "eval.import",
  source: {
    type: "huggingface",
    repo: "<value>",
    revision: "<value>",
  },
  suiteId: "<id>",
  suiteVersion: 112967,
  createdSuite: true,
  createdSuiteVersion: false,
  dryRun: true,
  discoveredFiles: 126725,
  importedRuns: 918904,
  skippedRuns: 304629,
  importedSamples: 760271,
};
```

## Fields

| Field                                                                                                      | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `object`                                                                                                   | *"eval.import"*                                                                                            | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `source`                                                                                                   | [components.EvalHistoricalImportObjectSource](../../models/components/evalhistoricalimportobjectsource.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `suiteId`                                                                                                  | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `suiteVersion`                                                                                             | *number*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `createdSuite`                                                                                             | *boolean*                                                                                                  | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `createdSuiteVersion`                                                                                      | *boolean*                                                                                                  | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `dryRun`                                                                                                   | *boolean*                                                                                                  | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `discoveredFiles`                                                                                          | *number*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `importedRuns`                                                                                             | *number*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `skippedRuns`                                                                                              | *number*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `importedSamples`                                                                                          | *number*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |