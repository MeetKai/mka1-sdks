# EvalSuiteManifest

## Example Usage

```typescript
import { EvalSuiteManifest } from "@meetkai/mka1/models/components";

let value: EvalSuiteManifest = {
  tasks: [],
};
```

## Fields

| Field                                                        | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `schemaVersion`                                              | *string*                                                     | :heavy_minus_sign:                                           | N/A                                                          |
| `tasks`                                                      | [components.EvalTask](../../models/components/evaltask.md)[] | :heavy_check_mark:                                           | N/A                                                          |
| `metadata`                                                   | Record<string, *any*>                                        | :heavy_minus_sign:                                           | N/A                                                          |