# TextToSpeechStreamingRequest

## Example Usage

```typescript
import { TextToSpeechStreamingRequest } from "@meetkai/mka1/models/operations";

let value: TextToSpeechStreamingRequest = {
  textToSpeechStreamingRequest: {
    text: "<value>",
  },
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                      | *string*                                                                                           | :heavy_minus_sign:                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                |
| `textToSpeechStreamingRequest`                                                                     | [components.TextToSpeechStreamingRequest](../../models/components/texttospeechstreamingrequest.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |