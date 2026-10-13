# SkillList

## Example Usage

```typescript
import { SkillList } from "@meetkai/mka1/models/components";

let value: SkillList = {
  data: [
    {
      id: "<id>",
      createdAt: 865598,
      defaultVersion: "<value>",
      description:
        "for what celebrated hence to that partially though crushing",
      latestVersion: "<value>",
      name: "<value>",
    },
  ],
  firstId: "<id>",
  hasMore: true,
  lastId: "<id>",
};
```

## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `object`                                               | *"list"*                                               | :heavy_minus_sign:                                     | N/A                                                    |
| `data`                                                 | [components.Skill](../../models/components/skill.md)[] | :heavy_check_mark:                                     | N/A                                                    |
| `firstId`                                              | *string*                                               | :heavy_check_mark:                                     | N/A                                                    |
| `hasMore`                                              | *boolean*                                              | :heavy_check_mark:                                     | N/A                                                    |
| `lastId`                                               | *string*                                               | :heavy_check_mark:                                     | N/A                                                    |