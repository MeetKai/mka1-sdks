# VectorStoreConnectorBrowseList


## Fields

| Field                                                        | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `Object`                                                     | `string`                                                     | :heavy_check_mark:                                           | N/A                                                          |
| `Data`                                                       | [][components.Data](../../models/components/data.md)         | :heavy_check_mark:                                           | Ordered by path. A page may hold fewer entries than `limit`. |
| `HasMore`                                                    | `bool`                                                       | :heavy_check_mark:                                           | N/A                                                          |
| `NextCursor`                                                 | `*string`                                                    | :heavy_check_mark:                                           | Pass as `cursor` for the next page; null on the last one.    |