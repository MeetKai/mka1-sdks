# Tokens

Summed over the run's trials. Each field is null when no trial reported it.


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Input`                                                                               | `*int64`                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `Output`                                                                              | `*int64`                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `Cached`                                                                              | `*int64`                                                                              | :heavy_check_mark:                                                                    | Share of `input` served from the provider's prompt cache.                             |
| `Reasoning`                                                                           | `*int64`                                                                              | :heavy_check_mark:                                                                    | Reasoning tokens inside `output`, over the samples whose provider reported the split. |