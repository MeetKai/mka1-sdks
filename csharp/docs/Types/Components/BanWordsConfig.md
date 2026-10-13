# BanWordsConfig

Configuration for banned words guardrail


## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `Words`                                                | List<*string*>                                         | :heavy_minus_sign:                                     | List of banned words or phrases                        |
| `RejectionMessage`                                     | *string*                                               | :heavy_minus_sign:                                     | The message to return when this guardrail is triggered |