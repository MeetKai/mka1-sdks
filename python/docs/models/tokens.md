# Tokens

Summed over the run's trials. Each field is null when no trial reported it.


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `input`                                                                               | *Nullable[int]*                                                                       | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `output`                                                                              | *Nullable[int]*                                                                       | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `cached`                                                                              | *Nullable[int]*                                                                       | :heavy_check_mark:                                                                    | Share of `input` served from the provider's prompt cache.                             |
| `reasoning`                                                                           | *Nullable[int]*                                                                       | :heavy_check_mark:                                                                    | Reasoning tokens inside `output`, over the samples whose provider reported the split. |