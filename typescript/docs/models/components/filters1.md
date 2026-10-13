# Filters1

A filter used to compare a specified attribute key to a given value using a defined comparison operation.

## Example Usage

```typescript
import { Filters1 } from "@meetkai/mka1/models/components";

let value: Filters1 = {
  type: "lte",
  key: "<key>",
  value: "<value>",
};
```

## Fields

| Field                                                                                                                                                              | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `type`                                                                                                                                                             | [components.FilterFiltersType](../../models/components/filterfilterstype.md)                                                                                       | :heavy_check_mark:                                                                                                                                                 | Comparison operator: eq (equals), ne (not equal), gt (greater than), gte (greater than or equal), lt (less than), lte (less than or equal), in (in), nin (not in). |
| `key`                                                                                                                                                              | *string*                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                 | The key to compare against the value.                                                                                                                              |
| `value`                                                                                                                                                            | *components.FiltersValue*                                                                                                                                          | :heavy_check_mark:                                                                                                                                                 | The value to compare against the attribute key; supports string, number, boolean, or array types.                                                                  |