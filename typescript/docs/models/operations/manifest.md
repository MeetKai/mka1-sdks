# Manifest

Persisted eval manifest. Known fields remain validated; unknown stored fields are retained for read/rollback compatibility.

## Example Usage

```typescript
import { Manifest } from "@meetkai/mka1/models/operations";

let value: Manifest = {
  tasks: [
    "<value 1>",
    "<value 2>",
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