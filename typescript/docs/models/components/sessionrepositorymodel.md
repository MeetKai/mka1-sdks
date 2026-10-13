# SessionRepositoryModel

## Example Usage

```typescript
import { SessionRepositoryModel } from "@meetkai/mka1/models/components";

let value: SessionRepositoryModel = {
  repositoryId: 131344,
  owner: "<value>",
  repository: "<value>",
  ref: "<value>",
  baseSha: "<value>",
  checkoutAlias: "<value>",
  checkoutPath: "<value>",
  status: "ready",
  createdAt: new Date("2025-02-10T22:04:21.538Z"),
  updatedAt: new Date("2024-07-11T20:08:47.900Z"),
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `repositoryId`                                                                                     | *number*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `owner`                                                                                            | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `repository`                                                                                       | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `requestedRef`                                                                                     | *string*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `ref`                                                                                              | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `defaultBranch`                                                                                    | *string*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `baseSha`                                                                                          | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `checkoutAlias`                                                                                    | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `checkoutPath`                                                                                     | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `status`                                                                                           | [components.SessionRepositoryModelStatus](../../models/components/sessionrepositorymodelstatus.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `failure`                                                                                          | [components.SessionRepositoryFailure](../../models/components/sessionrepositoryfailure.md)         | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `lastPush`                                                                                         | [components.SessionRepositoryPush](../../models/components/sessionrepositorypush.md)               | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `pullRequest`                                                                                      | [components.SessionRepositoryPullRequest](../../models/components/sessionrepositorypullrequest.md) | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `createdAt`                                                                                        | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)      | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `updatedAt`                                                                                        | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)      | :heavy_check_mark:                                                                                 | N/A                                                                                                |