# Audio

Audio output configuration. Optional when modalities includes 'audio'; defaults are applied if omitted.

## Example Usage

```typescript
import { Audio } from "@meetkai/mka1/models/components";

let value: Audio = {};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `voice`                                                                                            | *string*                                                                                           | :heavy_minus_sign:                                                                                 | The voice to use for audio output synthesis. Defaults to 'alloy'.                                  |
| `format`                                                                                           | [components.ResponsesCreateRequestFormat](../../models/components/responsescreaterequestformat.md) | :heavy_minus_sign:                                                                                 | The audio format for the output. Defaults to 'wav'.                                                |