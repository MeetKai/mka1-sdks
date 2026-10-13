# CreateSkillVersionRequestBody

## Example Usage

```typescript
import { CreateSkillVersionRequestBody } from "@meetkai/mka1/models/operations";

let value: CreateSkillVersionRequestBody = {};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `files`                                                                                    | [operations.CreateSkillVersionFiles](../../models/operations/createskillversionfiles.md)[] | :heavy_minus_sign:                                                                         | Skill version files to upload (must include SKILL.md)                                      |
| `default`                                                                                  | *boolean*                                                                                  | :heavy_minus_sign:                                                                         | Set this version as the default                                                            |