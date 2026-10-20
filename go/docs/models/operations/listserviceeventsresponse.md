# ListServiceEventsResponse


## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `HTTPMeta`                                                                          | [components.HTTPMetadata](../../models/components/httpmetadata.md)                  | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `ComputeEventList`                                                                  | [*components.ComputeEventList](../../models/components/computeeventlist.md)         | :heavy_minus_sign:                                                                  | Durable service lifecycle events                                                    |
| `ComputeErrorEnvelope`                                                              | [*components.ComputeErrorEnvelope](../../models/components/computeerrorenvelope.md) | :heavy_minus_sign:                                                                  | API error                                                                           |