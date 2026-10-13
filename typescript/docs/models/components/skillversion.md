# SkillVersion

## Example Usage

```typescript
import { SkillVersion } from "@meetkai/mka1/models/components";

let value: SkillVersion = {
  id: "<id>",
  createdAt: 972435,
  description:
    "coordinated nervous ouch tightly unnecessarily whose swerve what cram",
  name: "<value>",
  skillId: "<id>",
  version: "<value>",
};
```

## Fields

| Field                                       | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `id`                                        | *string*                                    | :heavy_check_mark:                          | Unique identifier for the version           |
| `createdAt`                                 | *number*                                    | :heavy_check_mark:                          | Unix timestamp when the version was created |
| `description`                               | *string*                                    | :heavy_check_mark:                          | Description of the skill version            |
| `name`                                      | *string*                                    | :heavy_check_mark:                          | Name of the skill version                   |
| `object`                                    | *"skill.version"*                           | :heavy_minus_sign:                          | N/A                                         |
| `skillId`                                   | *string*                                    | :heavy_check_mark:                          | Parent skill identifier                     |
| `version`                                   | *string*                                    | :heavy_check_mark:                          | Version number                              |