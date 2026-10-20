# ListJobsResponse


## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `HTTPMeta`                                                                          | [components.HTTPMetadata](../../models/components/httpmetadata.md)                  | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `ComputeJobList`                                                                    | [*components.ComputeJobList](../../models/components/computejoblist.md)             | :heavy_minus_sign:                                                                  | Tenant jobs                                                                         |
| `ComputeErrorEnvelope`                                                              | [*components.ComputeErrorEnvelope](../../models/components/computeerrorenvelope.md) | :heavy_minus_sign:                                                                  | API error                                                                           |