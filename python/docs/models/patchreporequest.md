# PatchRepoRequest

A partial update. Every field is optional; an omitted field is left
unchanged.



## Fields

| Field                                                                                                                  | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `description`                                                                                                          | *Optional[str]*                                                                                                        | :heavy_minus_sign:                                                                                                     | N/A                                                                                                                    |
| `kind`                                                                                                                 | [Optional[models.RepoKind]](../models/repokind.md)                                                                     | :heavy_minus_sign:                                                                                                     | Switch the repository's kind (see the operation description for<br/>the rules). Cannot be `null`: a kind is never un-set.<br/> |
| `name`                                                                                                                 | *Optional[str]*                                                                                                        | :heavy_minus_sign:                                                                                                     | N/A                                                                                                                    |