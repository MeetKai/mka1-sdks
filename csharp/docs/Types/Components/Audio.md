# Audio

Audio output configuration. Optional when modalities includes 'audio'; defaults are applied if omitted.


## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `Voice`                                                                                | *string*                                                                               | :heavy_minus_sign:                                                                     | The voice to use for audio output synthesis. Defaults to 'alloy'.                      |
| `Format`                                                                               | [ResponsesCreateRequestFormat](../../Types/Components/ResponsesCreateRequestFormat.md) | :heavy_minus_sign:                                                                     | The audio format for the output. Defaults to 'wav'.                                    |