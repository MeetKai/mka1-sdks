# Filter1

A filter used to compare a specified attribute key to a given value using a defined comparison operation.

## Example Usage

```typescript
import { Filter1 } from "@meetkai/mka1/models/components";

let value: Filter1 = {
  type: "gt",
  key: "<key>",
  value: true,
};
```

## Fields

| Field                                                                                                                                                              | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `type`                                                                                                                                                             | [components.FilterType](../../models/components/filtertype.md)                                                                                                     | :heavy_check_mark:                                                                                                                                                 | Comparison operator: eq (equals), ne (not equal), gt (greater than), gte (greater than or equal), lt (less than), lte (less than or equal), in (in), nin (not in). |
| `key`                                                                                                                                                              | *string*                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                 | The key to compare against the value.                                                                                                                              |
| `value`                                                                                                                                                            | *components.FilterValue*                                                                                                                                           | :heavy_check_mark:                                                                                                                                                 | The value to compare against the attribute key; supports string, number, boolean, or array types.                                                                  |