# OpenAIChatCompletionRequestParamsResponseFormat

An object specifying the format that the model must output. Setting to { 'type': 'json_object' } enables JSON mode.

## Example Usage

```typescript
import { OpenAIChatCompletionRequestParamsResponseFormat } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionRequestParamsResponseFormat = {
  type: "<value>",
};
```

## Fields

| Field                                                                                                               | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `type`                                                                                                              | *components.OpenAIChatCompletionRequestParamsType*                                                                  | :heavy_check_mark:                                                                                                  | The format type. Use 'json_object' to enable JSON mode, guaranteeing the message the model generates is valid JSON. |
| `jsonSchema`                                                                                                        | [components.JsonSchema](../../models/components/jsonschema.md)                                                      | :heavy_minus_sign:                                                                                                  | JSON Schema definition for structured output. Required when type is 'json_schema'.                                  |