# ListServicesResponse


## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `HTTPMeta`                                                                          | [components.HTTPMetadata](../../models/components/httpmetadata.md)                  | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `ComputeServiceList`                                                                | [*components.ComputeServiceList](../../models/components/computeservicelist.md)     | :heavy_minus_sign:                                                                  | Tenant services                                                                     |
| `ComputeErrorEnvelope`                                                              | [*components.ComputeErrorEnvelope](../../models/components/computeerrorenvelope.md) | :heavy_minus_sign:                                                                  | API error                                                                           |