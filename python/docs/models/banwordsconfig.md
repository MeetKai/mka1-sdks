# BanWordsConfig

Configuration for banned words guardrail


## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `words`                                                | List[*str*]                                            | :heavy_minus_sign:                                     | List of banned words or phrases                        |
| `rejection_message`                                    | *Optional[str]*                                        | :heavy_minus_sign:                                     | The message to return when this guardrail is triggered |