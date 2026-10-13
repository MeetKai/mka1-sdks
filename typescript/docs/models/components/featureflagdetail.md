# FeatureFlagDetail

## Example Usage

```typescript
import { FeatureFlagDetail } from "@meetkai/mka1/models/components";

let value: FeatureFlagDetail = {
  archivedAt: new Date("2025-09-30T10:48:51.191Z"),
  createdAt: new Date("2025-04-09T00:23:15.914Z"),
  defaultValue: "<value>",
  description: "by along soft gosh aha before dish",
  key: "<key>",
  name: "<value>",
  projectId: "7051dadc-f8c9-4ce8-98c3-c6f73f16365a",
  updatedAt: new Date("2025-12-27T10:35:09.118Z"),
  valueType: "json",
  states: {},
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `archivedAt`                                                                                  | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `createdAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `defaultValue`                                                                                | *any*                                                                                         | :heavy_check_mark:                                                                            | Any JSON value; its shape is constrained by the flag's value_type.                            |
| `description`                                                                                 | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `key`                                                                                         | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `name`                                                                                        | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `projectId`                                                                                   | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `updatedAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `valueType`                                                                                   | [components.FeatureFlagValueType](../../models/components/featureflagvaluetype.md)            | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `states`                                                                                      | Record<string, [components.FeatureFlagState](../../models/components/featureflagstate.md)>    | :heavy_check_mark:                                                                            | N/A                                                                                           |