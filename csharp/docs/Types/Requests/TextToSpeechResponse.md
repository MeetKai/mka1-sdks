# TextToSpeechResponse


## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `HttpMeta`                                             | [HTTPMetadata](../../Types/Components/HTTPMetadata.md) | :heavy_check_mark:                                     | N/A                                                    |
| `Bytes`                                                | *byte[]*                                               | :heavy_minus_sign:                                     | Audio file in WAV format with language code header     |
| `Headers`                                              | Dictionary<String, List<*string*>>                     | :heavy_check_mark:                                     | N/A                                                    |