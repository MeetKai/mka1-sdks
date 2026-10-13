# GetFilesUsageRequest

## Example Usage

```typescript
import { GetFilesUsageRequest } from "@meetkai/mka1/models/operations";

let value: GetFilesUsageRequest = {
  startTime: 1704067200,
  endTime: 1704153600,
  limit: 30,
  page: "cursor_abc123",
  userIds: [
    "user_123",
    "user_456",
  ],
  externalUserIds: [
    "sub_123",
  ],
  orgIds: [
    "org_123",
  ],
  groupBy: [
    "user_id",
  ],
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          | Example                                                              |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `startTime`                                                          | *number*                                                             | :heavy_check_mark:                                                   | N/A                                                                  | 1704067200                                                           |
| `endTime`                                                            | *number*                                                             | :heavy_minus_sign:                                                   | N/A                                                                  | 1704153600                                                           |
| `bucketWidth`                                                        | [components.BucketWidth](../../models/components/bucketwidth.md)     | :heavy_minus_sign:                                                   | N/A                                                                  | 1d                                                                   |
| `limit`                                                              | *number*                                                             | :heavy_minus_sign:                                                   | N/A                                                                  | 30                                                                   |
| `page`                                                               | *string*                                                             | :heavy_minus_sign:                                                   | N/A                                                                  | cursor_abc123                                                        |
| `userIds`                                                            | *string*[]                                                           | :heavy_minus_sign:                                                   | N/A                                                                  | [<br/>"user_123",<br/>"user_456"<br/>]                               |
| `externalUserIds`                                                    | *string*[]                                                           | :heavy_minus_sign:                                                   | N/A                                                                  | [<br/>"sub_123"<br/>]                                                |
| `allOrgs`                                                            | *string*                                                             | :heavy_minus_sign:                                                   | N/A                                                                  |                                                                      |
| `orgIds`                                                             | *string*[]                                                           | :heavy_minus_sign:                                                   | N/A                                                                  | [<br/>"org_123"<br/>]                                                |
| `groupBy`                                                            | [components.FilesGroupBy](../../models/components/filesgroupby.md)[] | :heavy_minus_sign:                                                   | N/A                                                                  | [<br/>"user_id"<br/>]                                                |
| `xOnBehalfOf`                                                        | *string*                                                             | :heavy_minus_sign:                                                   | Optional external end-user identifier forwarded by the API gateway.  |                                                                      |