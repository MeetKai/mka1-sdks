# GrammarFormat

## Example Usage

```typescript
import { GrammarFormat } from "@meetkai/mka1/models/components";

let value: GrammarFormat = {
  type: "grammar",
  definition: "<value>",
  syntax: "regex",
};
```

## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `type`                                                 | *"grammar"*                                            | :heavy_check_mark:                                     | N/A                                                    |
| `definition`                                           | *string*                                               | :heavy_check_mark:                                     | N/A                                                    |
| `syntax`                                               | [components.Syntax](../../models/components/syntax.md) | :heavy_check_mark:                                     | N/A                                                    |