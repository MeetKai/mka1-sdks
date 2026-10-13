# SemanticRule

One per-row check beyond the row schema: what `_semantics` yields and what
`GET /formats/{id}` serves (api.md §4).

## Example Usage

```typescript
import { SemanticRule } from "@meetkai/mka1/models/components";

let value: SemanticRule = {
  code: "<value>",
  severity: "error",
  description: "including impartial extension inside furthermore meh proceed",
};
```

## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `code`                                                                                | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `severity`                                                                            | [components.Severity](../../models/components/severity.md)                            | :heavy_check_mark:                                                                    | Whether an issue stops a consumer (`ERROR`) or is for a human to look at (`WARNING`). |
| `description`                                                                         | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |