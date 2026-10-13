# Audio

Audio output configuration. Optional when modalities includes 'audio'; defaults are applied if omitted.


## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `voice`                                                                                    | *Optional[str]*                                                                            | :heavy_minus_sign:                                                                         | The voice to use for audio output synthesis. Defaults to 'alloy'.                          |
| `format_`                                                                                  | [Optional[models.ResponsesCreateRequestFormat]](../models/responsescreaterequestformat.md) | :heavy_minus_sign:                                                                         | The audio format for the output. Defaults to 'wav'.                                        |