# Skill

## Example Usage

```typescript
import { Skill } from "@meetkai/mka1/models/components";

let value: Skill = {
  id: "<id>",
  createdAt: 692479,
  defaultVersion: "<value>",
  description: "incidentally ick candid sharply",
  latestVersion: "<value>",
  name: "<value>",
};
```

## Fields

| Field                                     | Type                                      | Required                                  | Description                               |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| `id`                                      | *string*                                  | :heavy_check_mark:                        | Unique identifier for the skill           |
| `createdAt`                               | *number*                                  | :heavy_check_mark:                        | Unix timestamp when the skill was created |
| `defaultVersion`                          | *string*                                  | :heavy_check_mark:                        | Default version for the skill             |
| `description`                             | *string*                                  | :heavy_check_mark:                        | Description of the skill                  |
| `latestVersion`                           | *string*                                  | :heavy_check_mark:                        | Latest version for the skill              |
| `name`                                    | *string*                                  | :heavy_check_mark:                        | Name of the skill                         |
| `object`                                  | *"skill"*                                 | :heavy_minus_sign:                        | N/A                                       |