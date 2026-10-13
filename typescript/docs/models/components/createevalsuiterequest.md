# CreateEvalSuiteRequest

## Example Usage

```typescript
import { CreateEvalSuiteRequest } from "@meetkai/mka1/models/components";

let value: CreateEvalSuiteRequest = {
  name: "<value>",
  manifest: {
    tasks: [],
  },
};
```

## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `name`                                                                       | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `description`                                                                | *string*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |
| `manifest`                                                                   | [components.EvalSuiteManifest](../../models/components/evalsuitemanifest.md) | :heavy_check_mark:                                                           | N/A                                                                          |
| `metadata`                                                                   | Record<string, *string*>                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |