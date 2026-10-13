# GetEvalSuiteVersionManifest

Persisted eval manifest. Known fields remain validated; unknown stored fields are retained for read/rollback compatibility.

## Example Usage

```typescript
import { GetEvalSuiteVersionManifest } from "@meetkai/mka1/models/operations";

let value: GetEvalSuiteVersionManifest = {
  tasks: [
    "<value 1>",
    "<value 2>",
    "<value 3>",
  ],
};
```

## Fields

| Field                  | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `schemaVersion`        | *string*               | :heavy_minus_sign:     | N/A                    |
| `tasks`                | *any*[]                | :heavy_check_mark:     | N/A                    |
| `metadata`             | Record<string, *any*>  | :heavy_minus_sign:     | N/A                    |
| `additionalProperties` | Record<string, *any*>  | :heavy_minus_sign:     | N/A                    |