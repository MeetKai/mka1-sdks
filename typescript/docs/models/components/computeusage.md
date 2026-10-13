# ComputeUsage

## Example Usage

```typescript
import { ComputeUsage } from "@meetkai/mka1/models/components";

let value: ComputeUsage = {
  data: [],
  granularity: "minute",
  nextCursor: "<value>",
  summary: {
    jobUsd: 4775.35,
    serviceUsd: 6524.37,
    totalUsd: 8878.62,
    volumeUsd: 4404.2,
  },
  total: 155527,
  volumeAllocation: "uniform_proration",
  volumeLedgerGranularity: "hour",
  volumeUsageComplete: true,
  volumeUsageCompleteThrough: new Date("2025-06-09T15:38:45.336Z"),
  window: {
    from: new Date("2024-01-13T06:25:33.267Z"),
    to: new Date("2025-10-05T08:43:59.509Z"),
  },
};
```

## Fields

| Field                                                                                                     | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `data`                                                                                                    | [components.ComputeUsageData](../../models/components/computeusagedata.md)[]                              | :heavy_check_mark:                                                                                        | N/A                                                                                                       |
| `granularity`                                                                                             | [components.Granularity](../../models/components/granularity.md)                                          | :heavy_check_mark:                                                                                        | Required alignment and allocation granularity of the requested window.                                    |
| `nextCursor`                                                                                              | *string*                                                                                                  | :heavy_check_mark:                                                                                        | N/A                                                                                                       |
| `summary`                                                                                                 | [components.ComputeUsageSummary](../../models/components/computeusagesummary.md)                          | :heavy_check_mark:                                                                                        | N/A                                                                                                       |
| `total`                                                                                                   | *number*                                                                                                  | :heavy_check_mark:                                                                                        | N/A                                                                                                       |
| `volumeAllocation`                                                                                        | [components.VolumeAllocation](../../models/components/volumeallocation.md)                                | :heavy_check_mark:                                                                                        | Finalized hourly volume totals are allocated uniformly over their immutable billable interval.            |
| `volumeLedgerGranularity`                                                                                 | [components.VolumeLedgerGranularity](../../models/components/volumeledgergranularity.md)                  | :heavy_check_mark:                                                                                        | Immutable UTC bucket granularity of standalone-volume billing rows.                                       |
| `volumeUsageComplete`                                                                                     | *boolean*                                                                                                 | :heavy_check_mark:                                                                                        | True only when every relevant standalone volume has a contiguous durable ledger prefix through window.to. |
| `volumeUsageCompleteThrough`                                                                              | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)             | :heavy_check_mark:                                                                                        | Conservative organization-wide standalone-volume ledger watermark, capped to the requested window.        |
| `window`                                                                                                  | [components.Window](../../models/components/window.md)                                                    | :heavy_check_mark:                                                                                        | N/A                                                                                                       |