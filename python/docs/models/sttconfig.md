# SttConfig

Optional STT (speech-to-text) VAD configuration for the voice session.


## Fields

| Field                                                                                                               | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `silence_timeout_ms`                                                                                                | *Optional[int]*                                                                                                     | :heavy_minus_sign:                                                                                                  | Server-side VAD silence timeout in ms (100–5000). Controls how long to wait after silence before finalizing speech. |
| `initial_silence_timeout_ms`                                                                                        | *Optional[int]*                                                                                                     | :heavy_minus_sign:                                                                                                  | Timeout in ms before any speech is detected (1000–30000).                                                           |