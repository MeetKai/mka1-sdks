# PreconfiguredSkillReference

## Example Usage

```typescript
import { PreconfiguredSkillReference } from "@meetkai/mka1/models/components";

let value: PreconfiguredSkillReference = {
  type: "preconfigured",
  name: "<value>",
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `type`                                                               | *"preconfigured"*                                                    | :heavy_check_mark:                                                   | N/A                                                                  |
| `name`                                                               | *string*                                                             | :heavy_check_mark:                                                   | Name of a preconfigured skill (e.g., 'pdf', 'docx', 'xlsx', 'pptx'). |