# FeatureFlagListItem

## Example Usage

```typescript
import { FeatureFlagListItem } from "@meetkai/mka1/models/components";

let value: FeatureFlagListItem = {
  archivedAt: new Date("2024-07-29T11:43:28.710Z"),
  createdAt: new Date("2025-08-13T06:19:40.350Z"),
  defaultValue: "<value>",
  description:
    "unbearably paralyse fellow lest soupy obedient underneath exacerbate duh bright",
  key: "<key>",
  name: "<value>",
  projectId: "b10a8896-9dd6-41e5-81b1-91ffdc432a32",
  updatedAt: new Date("2026-02-11T07:22:02.069Z"),
  valueType: "string",
  states: {
    "key": {
      enabled: false,
      overrideCount: 615181,
      rolloutPercentage: 686822,
      ruleCount: 703395,
    },
  },
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `archivedAt`                                                                                             | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)            | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `createdAt`                                                                                              | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)            | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `defaultValue`                                                                                           | *any*                                                                                                    | :heavy_check_mark:                                                                                       | Any JSON value; its shape is constrained by the flag's value_type.                                       |
| `description`                                                                                            | *string*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `key`                                                                                                    | *string*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `name`                                                                                                   | *string*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `projectId`                                                                                              | *string*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `updatedAt`                                                                                              | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)            | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `valueType`                                                                                              | [components.FeatureFlagValueType](../../models/components/featureflagvaluetype.md)                       | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `states`                                                                                                 | Record<string, [components.FeatureFlagStateSummary](../../models/components/featureflagstatesummary.md)> | :heavy_check_mark:                                                                                       | N/A                                                                                                      |