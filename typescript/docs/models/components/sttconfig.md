# SttConfig

Optional STT (speech-to-text) VAD configuration for the voice session.

## Example Usage

```typescript
import { SttConfig } from "@meetkai/mka1/models/components";

let value: SttConfig = {};
```

## Fields

| Field                                                                                                               | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `silenceTimeoutMs`                                                                                                  | *number*                                                                                                            | :heavy_minus_sign:                                                                                                  | Server-side VAD silence timeout in ms (100–5000). Controls how long to wait after silence before finalizing speech. |
| `initialSilenceTimeoutMs`                                                                                           | *number*                                                                                                            | :heavy_minus_sign:                                                                                                  | Timeout in ms before any speech is detected (1000–30000).                                                           |