# InputText

Input text content item: Plain text content to send to the model.

## Example Usage

```typescript
import { InputText } from "@meetkai/mka1/models/components";

let value: InputText = {
  type: "input_text",
  text: "<value>",
};
```

## Fields

| Field                                       | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `type`                                      | *"input_text"*                              | :heavy_check_mark:                          | The content type identifier for text input. |
| `text`                                      | *string*                                    | :heavy_check_mark:                          | The text content to send to the model.      |