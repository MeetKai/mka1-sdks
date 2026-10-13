# PreconfiguredSkillList

## Example Usage

```typescript
import { PreconfiguredSkillList } from "@meetkai/mka1/models/components";

let value: PreconfiguredSkillList = {
  data: [
    {
      name: "<value>",
      description: "going blah randomize for or aha quinoa versus own round",
    },
  ],
  firstId: null,
  hasMore: false,
  lastId: null,
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `object`                                                                         | *"list"*                                                                         | :heavy_minus_sign:                                                               | N/A                                                                              |
| `data`                                                                           | [components.PreconfiguredSkill](../../models/components/preconfiguredskill.md)[] | :heavy_check_mark:                                                               | N/A                                                                              |
| `firstId`                                                                        | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `hasMore`                                                                        | *boolean*                                                                        | :heavy_check_mark:                                                               | N/A                                                                              |
| `lastId`                                                                         | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |