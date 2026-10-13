# PreconfiguredSkill

## Example Usage

```typescript
import { PreconfiguredSkill } from "@meetkai/mka1/models/components";

let value: PreconfiguredSkill = {
  name: "<value>",
  description: "spellcheck usefully if hmph brand couch nab easily put",
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `name`                                                                         | *string*                                                                       | :heavy_check_mark:                                                             | Skill name, used as { type: 'preconfigured', name: '...' } in tool definitions |
| `description`                                                                  | *string*                                                                       | :heavy_check_mark:                                                             | Description of what the skill does                                             |
| `object`                                                                       | *"preconfigured_skill"*                                                        | :heavy_minus_sign:                                                             | N/A                                                                            |