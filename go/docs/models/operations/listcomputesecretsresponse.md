# ListComputeSecretsResponse


## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `HTTPMeta`                                                                          | [components.HTTPMetadata](../../models/components/httpmetadata.md)                  | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `ComputeSecretList`                                                                 | [*components.ComputeSecretList](../../models/components/computesecretlist.md)       | :heavy_minus_sign:                                                                  | Secret metadata                                                                     |
| `ComputeErrorEnvelope`                                                              | [*components.ComputeErrorEnvelope](../../models/components/computeerrorenvelope.md) | :heavy_minus_sign:                                                                  | API error                                                                           |