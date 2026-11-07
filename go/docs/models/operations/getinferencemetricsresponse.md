# GetInferenceMetricsResponse


## Fields

| Field                                                                                   | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `HTTPMeta`                                                                              | [components.HTTPMetadata](../../models/components/httpmetadata.md)                      | :heavy_check_mark:                                                                      | N/A                                                                                     |
| `InferenceMetricsReport`                                                                | [*components.InferenceMetricsReport](../../models/components/inferencemetricsreport.md) | :heavy_minus_sign:                                                                      | Metrics for each model called in the window, busiest first.                             |