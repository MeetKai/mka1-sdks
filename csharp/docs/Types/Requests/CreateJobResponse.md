# CreateJobResponse


## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `HttpMeta`                                                             | [HTTPMetadata](../../Types/Components/HTTPMetadata.md)                 | :heavy_check_mark:                                                     | N/A                                                                    |
| `ComputeJob`                                                           | [ComputeJob](../../Types/Components/ComputeJob.md)                     | :heavy_minus_sign:                                                     | Equivalent idempotent replay                                           |
| `ComputeErrorEnvelope`                                                 | [ComputeErrorEnvelope](../../Types/Components/ComputeErrorEnvelope.md) | :heavy_minus_sign:                                                     | API error                                                              |