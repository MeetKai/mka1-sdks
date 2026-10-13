# SkillVersionList

## Example Usage

```typescript
import { SkillVersionList } from "@meetkai/mka1/models/components";

let value: SkillVersionList = {
  data: [
    {
      id: "<id>",
      createdAt: 791303,
      description: "sinful fooey vista as failing wherever",
      name: "<value>",
      skillId: "<id>",
      version: "<value>",
    },
  ],
  firstId: "<id>",
  hasMore: true,
  lastId: "<id>",
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `object`                                                             | *"list"*                                                             | :heavy_minus_sign:                                                   | N/A                                                                  |
| `data`                                                               | [components.SkillVersion](../../models/components/skillversion.md)[] | :heavy_check_mark:                                                   | N/A                                                                  |
| `firstId`                                                            | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `hasMore`                                                            | *boolean*                                                            | :heavy_check_mark:                                                   | N/A                                                                  |
| `lastId`                                                             | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |