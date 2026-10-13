# SkillReference

## Example Usage

```typescript
import { SkillReference } from "@meetkai/mka1/models/components";

let value: SkillReference = {
  type: "skill_reference",
  skillId: "<id>",
};
```

## Fields

| Field                                                                                             | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `type`                                                                                            | *"skill_reference"*                                                                               | :heavy_check_mark:                                                                                | N/A                                                                                               |
| `skillId`                                                                                         | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the skill to inject into the container.                                                     |
| `version`                                                                                         | *components.SkillReferenceVersion*                                                                | :heavy_minus_sign:                                                                                | Version number, or 'latest' for the most recent version. Defaults to the skill's default_version. |