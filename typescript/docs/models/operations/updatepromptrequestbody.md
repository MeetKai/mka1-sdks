# UpdatePromptRequestBody

## Example Usage

```typescript
import { UpdatePromptRequestBody } from "@meetkai/mka1/models/operations";

let value: UpdatePromptRequestBody = {};
```

## Fields

| Field                                    | Type                                     | Required                                 | Description                              |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| `name`                                   | *string*                                 | :heavy_minus_sign:                       | Updated prompt name                      |
| `description`                            | *string*                                 | :heavy_minus_sign:                       | Updated description — pass null to clear |
| `metadata`                               | Record<string, *any*>                    | :heavy_minus_sign:                       | Updated metadata — replaces existing     |