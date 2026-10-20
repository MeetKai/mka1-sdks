# TerminateJobResponse


## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `HTTPMeta`                                                                          | [components.HTTPMetadata](../../models/components/httpmetadata.md)                  | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `ComputeJob`                                                                        | [*components.ComputeJob](../../models/components/computejob.md)                     | :heavy_minus_sign:                                                                  | Current job after idempotent termination request                                    |
| `ComputeErrorEnvelope`                                                              | [*components.ComputeErrorEnvelope](../../models/components/computeerrorenvelope.md) | :heavy_minus_sign:                                                                  | API error                                                                           |