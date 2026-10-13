# FeatureFlagCreateRequest

## Example Usage

```typescript
import { FeatureFlagCreateRequest } from "@meetkai/mka1/models/components";

let value: FeatureFlagCreateRequest = {
  defaultValue: "<value>",
  key: "<key>",
  name: "<value>",
  valueType: "string",
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `defaultValue`                                                                     | *any*                                                                              | :heavy_check_mark:                                                                 | Any JSON value; its shape is constrained by the flag's value_type.                 |
| `description`                                                                      | *string*                                                                           | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `key`                                                                              | *string*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `name`                                                                             | *string*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `projectId`                                                                        | *string*                                                                           | :heavy_minus_sign:                                                                 | Project to assign. Defaults to the Default project.                                |
| `valueType`                                                                        | [components.FeatureFlagValueType](../../models/components/featureflagvaluetype.md) | :heavy_check_mark:                                                                 | N/A                                                                                |