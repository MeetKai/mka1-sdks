# TerminateJobResponse


## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `HttpMeta`                                                             | [HTTPMetadata](../../Types/Components/HTTPMetadata.md)                 | :heavy_check_mark:                                                     | N/A                                                                    |
| `ComputeJob`                                                           | [ComputeJob](../../Types/Components/ComputeJob.md)                     | :heavy_minus_sign:                                                     | Current job after idempotent termination request                       |
| `ComputeErrorEnvelope`                                                 | [ComputeErrorEnvelope](../../Types/Components/ComputeErrorEnvelope.md) | :heavy_minus_sign:                                                     | API error                                                              |