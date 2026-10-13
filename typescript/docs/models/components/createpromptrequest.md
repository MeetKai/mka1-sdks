# CreatePromptRequest

## Example Usage

```typescript
import { CreatePromptRequest } from "@meetkai/mka1/models/components";

let value: CreatePromptRequest = {
  name: "<value>",
  template: "<value>",
};
```

## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `name`                                                  | *string*                                                | :heavy_check_mark:                                      | Human-readable prompt name                              |
| `description`                                           | *string*                                                | :heavy_minus_sign:                                      | Detailed description of the prompt                      |
| `template`                                              | *string*                                                | :heavy_check_mark:                                      | The prompt template text with {{variable}} placeholders |
| `metadata`                                              | Record<string, *any*>                                   | :heavy_minus_sign:                                      | Custom metadata key-value pairs                         |