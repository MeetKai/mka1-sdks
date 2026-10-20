# PatchRepoRequest

A partial update. Every field is optional; an omitted field is left
unchanged.



## Fields

| Field                                                                                                                  | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `Description`                                                                                                          | `*string`                                                                                                              | :heavy_minus_sign:                                                                                                     | N/A                                                                                                                    |
| `Kind`                                                                                                                 | [*components.RepoKind](../../models/components/repokind.md)                                                            | :heavy_minus_sign:                                                                                                     | Switch the repository's kind (see the operation description for<br/>the rules). Cannot be `null`: a kind is never un-set.<br/> |
| `Name`                                                                                                                 | `*string`                                                                                                              | :heavy_minus_sign:                                                                                                     | N/A                                                                                                                    |