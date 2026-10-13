# FileCounts

File processing status counts.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `InProgress`                                               | *long*                                                     | :heavy_check_mark:                                         | The number of files that are currently being processed.    |
| `Completed`                                                | *long*                                                     | :heavy_check_mark:                                         | The number of files that have been successfully processed. |
| `Failed`                                                   | *long*                                                     | :heavy_check_mark:                                         | The number of files that have failed to process.           |
| `Cancelled`                                                | *long*                                                     | :heavy_check_mark:                                         | The number of files that were cancelled.                   |
| `Total`                                                    | *long*                                                     | :heavy_check_mark:                                         | The total number of files.                                 |