# ListServicesResponse


## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `HttpMeta`                                                             | [HTTPMetadata](../../Types/Components/HTTPMetadata.md)                 | :heavy_check_mark:                                                     | N/A                                                                    |
| `ComputeServiceList`                                                   | [ComputeServiceList](../../Types/Components/ComputeServiceList.md)     | :heavy_minus_sign:                                                     | Tenant services                                                        |
| `ComputeErrorEnvelope`                                                 | [ComputeErrorEnvelope](../../Types/Components/ComputeErrorEnvelope.md) | :heavy_minus_sign:                                                     | API error                                                              |