# OpenAIRequestMessageContent4


## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `Type`                                                                                   | *string*                                                                                 | :heavy_check_mark:                                                                       | Content type identifier for file content                                                 |
| `File`                                                                                   | [OpenAIRequestMessageFileUnion](../../Types/Components/OpenAIRequestMessageFileUnion.md) | :heavy_check_mark:                                                                       | The file to include in the message, either as raw data or by reference                   |