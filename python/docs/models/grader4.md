# Grader4


## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `type`                                                                 | *Literal["score_model"]*                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `name`                                                                 | *str*                                                                  | :heavy_check_mark:                                                     | N/A                                                                    |
| `model`                                                                | *str*                                                                  | :heavy_check_mark:                                                     | N/A                                                                    |
| `input`                                                                | List[[models.MethodInput1](../models/methodinput1.md)]                 | :heavy_check_mark:                                                     | N/A                                                                    |
| `range`                                                                | List[*float*]                                                          | :heavy_minus_sign:                                                     | N/A                                                                    |
| `sampling_params`                                                      | [OptionalNullable[models.SamplingParams]](../models/samplingparams.md) | :heavy_minus_sign:                                                     | N/A                                                                    |