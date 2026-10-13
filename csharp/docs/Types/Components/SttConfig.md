# SttConfig

Optional STT (speech-to-text) VAD configuration for the voice session.


## Fields

| Field                                                                                                               | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `SilenceTimeoutMs`                                                                                                  | *long*                                                                                                              | :heavy_minus_sign:                                                                                                  | Server-side VAD silence timeout in ms (100–5000). Controls how long to wait after silence before finalizing speech. |
| `InitialSilenceTimeoutMs`                                                                                           | *long*                                                                                                              | :heavy_minus_sign:                                                                                                  | Timeout in ms before any speech is detected (1000–30000).                                                           |