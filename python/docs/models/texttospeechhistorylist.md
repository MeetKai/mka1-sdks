# TextToSpeechHistoryList

A paginated list of text-to-speech history items.


## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `object`                                                                         | *Literal["list"]*                                                                | :heavy_check_mark:                                                               | N/A                                                                              |
| `data`                                                                           | List[[models.TextToSpeechHistoryObject](../models/texttospeechhistoryobject.md)] | :heavy_check_mark:                                                               | N/A                                                                              |
| `first_id`                                                                       | *Optional[str]*                                                                  | :heavy_minus_sign:                                                               | N/A                                                                              |
| `last_id`                                                                        | *Optional[str]*                                                                  | :heavy_minus_sign:                                                               | N/A                                                                              |
| `has_more`                                                                       | *bool*                                                                           | :heavy_check_mark:                                                               | N/A                                                                              |