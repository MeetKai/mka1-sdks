# Reasoning

Reasoning item: Model reasoning metadata, including summary text and optional detailed reasoning content.


## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `Type`                                                         | *string*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `Id`                                                           | *string*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `Summary`                                                      | List<[SummaryText](../../Types/Components/SummaryText.md)>     | :heavy_check_mark:                                             | N/A                                                            |
| `Content`                                                      | List<[ReasoningText](../../Types/Components/ReasoningText.md)> | :heavy_minus_sign:                                             | N/A                                                            |
| `EncryptedContent`                                             | *string*                                                       | :heavy_minus_sign:                                             | N/A                                                            |
| `Status`                                                       | [Status](../../Types/Components/Status.md)                     | :heavy_minus_sign:                                             | N/A                                                            |