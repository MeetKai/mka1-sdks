# CreateEvalSuiteVersionRequest

## Example Usage

```typescript
import { CreateEvalSuiteVersionRequest } from "@meetkai/mka1/models/components";

let value: CreateEvalSuiteVersionRequest = {
  manifest: {
    tasks: [],
  },
};
```

## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `manifest`                                                                   | [components.EvalSuiteManifest](../../models/components/evalsuitemanifest.md) | :heavy_check_mark:                                                           | N/A                                                                          |
| `metadata`                                                                   | Record<string, *string*>                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |
| `makeActive`                                                                 | *boolean*                                                                    | :heavy_minus_sign:                                                           | N/A                                                                          |