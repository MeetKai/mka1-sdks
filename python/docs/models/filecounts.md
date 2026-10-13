# FileCounts

File processing status counts.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `in_progress`                                              | *int*                                                      | :heavy_check_mark:                                         | The number of files that are currently being processed.    |
| `completed`                                                | *int*                                                      | :heavy_check_mark:                                         | The number of files that have been successfully processed. |
| `failed`                                                   | *int*                                                      | :heavy_check_mark:                                         | The number of files that have failed to process.           |
| `cancelled`                                                | *int*                                                      | :heavy_check_mark:                                         | The number of files that were cancelled.                   |
| `total`                                                    | *int*                                                      | :heavy_check_mark:                                         | The total number of files.                                 |