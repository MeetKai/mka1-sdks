# LedgerChainVerification


## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `ChainID`                                                      | `string`                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `TotalEntries`                                                 | `int64`                                                        | :heavy_check_mark:                                             | Entries checked.                                               |
| `PrunedThroughSequence`                                        | `*int64`                                                       | :heavy_check_mark:                                             | The last sequence retention deleted; checking starts after it. |
| `LastSequence`                                                 | `*int64`                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `LastHash`                                                     | `*string`                                                      | :heavy_check_mark:                                             | N/A                                                            |
| `IsValid`                                                      | `bool`                                                         | :heavy_check_mark:                                             | N/A                                                            |
| `Issues`                                                       | []`string`                                                     | :heavy_check_mark:                                             | Why the chain is invalid.                                      |