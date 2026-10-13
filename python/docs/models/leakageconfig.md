# LeakageConfig

Configuration for system prompt leakage detection guardrail


## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `threshold`                                            | *Optional[float]*                                      | :heavy_minus_sign:                                     | Detection threshold (0-1)                              |
| `rejection_message`                                    | *Optional[str]*                                        | :heavy_minus_sign:                                     | The message to return when this guardrail is triggered |