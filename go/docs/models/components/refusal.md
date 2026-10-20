# Refusal

Refusal response when the model declines to answer due to safety policies, content moderation, or capability limitations.


## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `Type`                                                                           | `string`                                                                         | :heavy_check_mark:                                                               | The content type identifier for refusal responses.                               |
| `Refusal`                                                                        | `string`                                                                         | :heavy_check_mark:                                                               | The refusal message explaining why the model declined to respond to the request. |