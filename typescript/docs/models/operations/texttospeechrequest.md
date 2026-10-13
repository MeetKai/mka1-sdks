# TextToSpeechRequest

## Example Usage

```typescript
import { TextToSpeechRequest } from "@meetkai/mka1/models/operations";

let value: TextToSpeechRequest = {
  textToSpeechRequest: {
    text: "Hello, welcome to our text-to-speech service.",
    language: "en",
  },
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      | Example                                                                          |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                    | *string*                                                                         | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |                                                                                  |
| `textToSpeechRequest`                                                            | [components.TextToSpeechRequest](../../models/components/texttospeechrequest.md) | :heavy_check_mark:                                                               | N/A                                                                              | {<br/>"text": "Hello, welcome to our text-to-speech service.",<br/>"language": "en"<br/>} |