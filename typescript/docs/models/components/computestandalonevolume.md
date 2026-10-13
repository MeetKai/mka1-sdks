# ComputeStandaloneVolume

## Example Usage

```typescript
import { ComputeStandaloneVolume } from "@meetkai/mka1/models/components";

let value: ComputeStandaloneVolume = {
  accruedCostUsd: 6505.71,
  attachmentCount: 893752,
  cleanupFailure: {
    code: "<value>",
    message: "<value>",
  },
  createdAt: new Date("2025-09-14T01:29:02.585Z"),
  currentStoragePriceUsdHr: 7573.13,
  data: [],
  deletedAt: new Date("2024-11-16T01:30:18.567Z"),
  failure: {
    code: "<value>",
    message: "<value>",
  },
  id: "<id>",
  name: "<value>",
  provisionedAt: new Date("2025-12-08T04:38:32.035Z"),
  status: "creating",
  storageRateUsdPerGibHour: 1871.73,
  storedBytes: 233723,
  storedBytesObservedAt: new Date("2025-02-23T08:54:49.066Z"),
  updatedAt: new Date("2024-01-10T14:39:24.266Z"),
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `accruedCostUsd`                                                                                   | *number*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `attachmentCount`                                                                                  | *number*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `cleanupFailure`                                                                                   | [components.ComputeReason](../../models/components/computereason.md)                               | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `createdAt`                                                                                        | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)      | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `currentStoragePriceUsdHr`                                                                         | *number*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `data`                                                                                             | [components.ComputeVolumeData](../../models/components/computevolumedata.md)[]                     | :heavy_check_mark:                                                                                 | The volume's downloaded repositories; resolved_revision is set once the volume is ready.           |
| `deletedAt`                                                                                        | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)      | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `failure`                                                                                          | [components.ComputeReason](../../models/components/computereason.md)                               | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `id`                                                                                               | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `name`                                                                                             | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `provisionedAt`                                                                                    | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)      | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `status`                                                                                           | [components.ComputeStandaloneVolumeState](../../models/components/computestandalonevolumestate.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `storageRateUsdPerGibHour`                                                                         | *number*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `storedBytes`                                                                                      | *number*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `storedBytesObservedAt`                                                                            | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)      | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `updatedAt`                                                                                        | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)      | :heavy_check_mark:                                                                                 | N/A                                                                                                |